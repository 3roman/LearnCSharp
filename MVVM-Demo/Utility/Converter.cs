using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace MVVMDemo.Utility
{
    class Converter
    {
        public static List<T> DataTable2List<T>(DataTable dt)
        {
            // 通过反射获取对象公有成员信息
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            var objectProperties = typeof(T).GetProperties(flags);

            // 获取datatable列名
            var columnNames = dt.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName)
                .ToList();

            var targetList = dt.AsEnumerable().Select(dataRow =>
            {
                // 创建一个类型为T的对象
                var instanceOfT = Activator.CreateInstance<T>();

                foreach (var properties in objectProperties.Where(properties => columnNames.Contains(properties.Name) && dataRow[properties.Name] != DBNull.Value))
                {
                    properties.SetValue(instanceOfT, dataRow[properties.Name], null);
                }
                return instanceOfT;
            }).ToList();

            return targetList;
        }
    }
}
