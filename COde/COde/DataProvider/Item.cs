using System;

namespace COde.DataProvider
{
    /// <summary>
    /// 
    /// </summary>
    internal class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ManufactoredDate { get; set; }
        public bool Original { get; set; }
    }
}