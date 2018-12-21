using System;

namespace CSharp_Attribute
{
    // 规定这个attribute只能用来修饰类
    [AttributeUsage(AttributeTargets.Class)]
    class VersionAttribute:Attribute
    {
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public string Description { get; set; }
    }
}
