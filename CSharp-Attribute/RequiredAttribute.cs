
namespace CSharp_Attribute
{
    class RequiredAttribute: System.Attribute
    {
        public static bool IsPropertyRequired(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var p in properties)
            {
                var attributes = p.GetCustomAttributes(typeof(RequiredAttribute), false);
                if (attributes.Length > 0 )
                {
                    if (null == p.GetValue(obj, null))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
