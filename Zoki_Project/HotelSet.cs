//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zoki_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelSet
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int NumberRoom { get; set; }
        public string TypeRoom { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual ClientSet ClientSet { get; set; }
    }
}
