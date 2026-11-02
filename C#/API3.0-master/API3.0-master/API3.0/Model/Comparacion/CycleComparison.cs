using API3._0.Model.PostgreSQL;
using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;
using System.Reflection;

namespace API3._0.Model.Comparacion
{
    public class CycleComparison
    {
        public static bool CompareObjects(Cycle source, CyclePost target)
        {
            var sourceProps = typeof(Cycle).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var targetProps = typeof(CyclePost).GetProperties(BindingFlags.Public | BindingFlags.Instance);

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

        public static void UpdatePostgresEntity(Cycle source, CyclePost target)
        {
            var sourceProps = typeof(Cycle).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var targetProps = typeof(CyclePost).GetProperties(BindingFlags.Public | BindingFlags.Instance);

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

        public static void CopyToCycleJM(CyclePost source, CycleJM target)
        {
            target.Id = source.Id;
            target.BatchId = source.BatchId;
            target.ExpiryDate = EnsureUtc(source.ExpiryDate);
            target.ClosingDate = EnsureUtc(source.ClosingDate);
            target.ManualPulsesDispensed = source.ManualPulsesDispensed;
            target.Operator = source.Operator;
            target.CreationDate = EnsureUtc(source.CreationDate);
            target.RadiopharmaceuticalId = source.RadiopharmaceuticalId;
            target.SalineBatch = source.SalineBatch;
            target.SalineExpiryDate = EnsureUtc(source.SalineExpiryDate);
            target.State = source.State;
            target.SystemInitialized = source.SystemInitialized;
            target.PipesFull = source.PipesFull;
            target.AttWaste = source.AttWaste;
            target.TimeWaste = EnsureUtc(source.TimeWaste);
            target.SyringesBatch = source.SyringesBatch;
            target.SyringesExpiryDate = EnsureUtc(source.SyringesExpiryDate);
            target.DefluxBatch = source.DefluxBatch;
            target.DefluxExpiryDate = EnsureUtc(source.DefluxExpiryDate);
            target.CnnConnectorId = source.CnnConnectorId;
            target.SyncDate = source.SyncDate;

            // Campo adicional en la tabla JM
            target.ModifyDate = DateTime.UtcNow;
        }


        private static DateTime? EnsureUtc(DateTime? dt)
        {
            return dt.HasValue ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc) : null;
        }












    }
}
