namespace API3._0.Model.MAPEO
{
    public static class Extensions
    {
        public static void CopyPropertiesTo<T>(this T source, T target, params string[] excludedProperties)
        {
            var props = typeof(T).GetProperties()
                .Where(p => p.CanRead && p.CanWrite && !excludedProperties.Contains(p.Name));

            foreach (var prop in props)
            {
                var value = prop.GetValue(source, null);
                prop.SetValue(target, value, null);
            }
        }

        public static T CloneTo<T>(this object source, params string[] excludedProperties) where T : new()
        {
            var target = new T();
            var sourceProps = source.GetType().GetProperties()
                .Where(p => p.CanRead && !excludedProperties.Contains(p.Name));

            var targetProps = typeof(T).GetProperties()
                .Where(p => p.CanWrite);

            foreach (var sourceProp in sourceProps)
            {
                var targetProp = targetProps.FirstOrDefault(p => p.Name == sourceProp.Name && p.PropertyType == sourceProp.PropertyType);
                if (targetProp != null)
                {
                    targetProp.SetValue(target, sourceProp.GetValue(source, null), null);
                }
            }

            return target;
        }
    }
}
