namespace CSharp_Attribute
{
    class Person
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public bool Married { get; set; }
    }
}
