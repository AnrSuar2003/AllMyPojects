using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;
using System.Reflection;

namespace API3._0.Model.Comparisons
{
    public class SyringeComparison
    {
        public static bool CompareObjects(Syringe source, SyringePost target)
        {
            var sourceProps = typeof(Syringe).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var targetProps = typeof(SyringePost).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var sourceProp in sourceProps)
            {
                if (sourceProp.Name == "SyncDate") continue;

                var targetProp = targetProps.FirstOrDefault(p => p.Name == sourceProp.Name);
                if (targetProp == null) continue;

                var sourceValue = sourceProp.GetValue(source);
                var targetValue = targetProp.GetValue(target);

                if (!Equals(sourceValue, targetValue))
                {
                    return false;
                }
            }
            return true;
        }

        public static void UpdatePostgresEntity(Syringe source, SyringePost target)
        {
            var sourceProps = typeof(Syringe).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var targetProps = typeof(SyringePost).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var sourceProp in sourceProps)
            {
                if (sourceProp.Name == "SyncDate") continue;

                var targetProp = targetProps.FirstOrDefault(p => p.Name == sourceProp.Name);
                if (targetProp == null || !targetProp.CanWrite) continue;

                var newValue = sourceProp.GetValue(source);

                if (newValue is DateTime dt && dt.Kind == DateTimeKind.Unspecified)
                {
                    // Aseguramos que el valor tenga Kind=Utc
                    newValue = DateTime.SpecifyKind(dt, DateTimeKind.Utc);
                }

                targetProp.SetValue(target, newValue);
            }
        }

        public static void EnsureDateTimesAreUtc(object entity)
        {
            var props = entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                if (prop.PropertyType == typeof(DateTime) && prop.CanRead && prop.CanWrite)
                {
                    var value = (DateTime)prop.GetValue(entity);
                    if (value.Kind == DateTimeKind.Unspecified)
                    {
                        prop.SetValue(entity, DateTime.SpecifyKind(value, DateTimeKind.Utc));
                    }
                }
                else if (prop.PropertyType == typeof(DateTime?) && prop.CanRead && prop.CanWrite)
                {
                    var value = (DateTime?)prop.GetValue(entity);
                    if (value.HasValue && value.Value.Kind == DateTimeKind.Unspecified)
                    {
                        prop.SetValue(entity, DateTime.SpecifyKind(value.Value, DateTimeKind.Utc));
                    }
                }
            }
        }




        public static void CopyToSyringeJM(SyringePost source, SyringeJM target)
        {
            target.Id = source.Id;
            target.CycleId = source.CycleId;

            // Conversión explícita de double? a float?
            target.AttReq = (float?)source.AttReq;
            target.VolReq = (float?)source.VolReq;

            target.TimeReq = EnsureUtc(source.TimeReq);
            target.IsAdjusted = source.IsAdjusted;
            target.DateOfBirth = EnsureUtc(source.DateOfBirth);
            target.Gender = source.Gender;

            // Conversión explícita de double? a float?
            target.Height = (float?)source.Height;
            target.Weight = (float?)source.Weight;

            target.LastName = source.LastName;
            target.Name = source.Name;
            target.Notes = source.Notes;
            target.State = source.State;
            target.UniqueId = source.UniqueId;

            // Conversión explícita de double? a float?
            target.AttDispensed = (float?)source.AttDispensed;

            target.TimeDispensed = EnsureUtc(source.TimeDispensed);
            target.AttMc = (float?)source.AttMc;

            target.TimeMc = EnsureUtc(source.TimeMc);
            target.PulsesVolumeDispensedSb2 = source.PulsesVolumeDispensedSb2;
            target.PulsesAirDispensedSb2 = source.PulsesAirDispensedSb2;
            target.DispensingOrder = source.DispensingOrder;
            target.Background = (float?)source.Background;

            target.TimeBackground = EnsureUtc(source.TimeBackground);
            target.DirectInfusion = source.DirectInfusion;
            target.AttReqOriginal = (float?)source.AttReqOriginal;

            target.TimeReqOriginal = EnsureUtc(source.TimeReqOriginal);
            target.IsOverDosed = source.IsOverDosed;
            target.IsUnderDosed = source.IsUnderDosed;
            target.SyringeOrder = source.SyringeOrder;
            target.IsVmEmpty = source.IsVmEmpty;
            target.DispensingMode = source.DispensingMode;
            target.InjectionMode = source.InjectionMode;
            target.IsTransferFailed = source.IsTransferFailed;
            target.EnviroRecHeaderId = source.EnviroRecHeaderId;
            target.DispensedBy = source.DispensedBy;
            target.UploadError = source.UploadError;
            target.IsInjected = source.IsInjected;
            target.InjectionTime = EnsureUtc(source.InjectionTime);
            target.VialTransfer = source.VialTransfer;
            target.Study = source.Study;
            target.SyncDate = source.SyncDate;

            // Asignar ModifyDate al momento actual (en UTC)
            target.ModifyDate = DateTime.UtcNow;
        }

        private static DateTime? EnsureUtc(DateTime? dt)
        {
            return dt.HasValue ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc) : null;
        }



    }
}
