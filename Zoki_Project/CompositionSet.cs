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
    
    public partial class CompositionSet
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdProvider { get; set; }
        public int Number { get; set; }
    
        public virtual ProductSet ProductSet { get; set; }
        public virtual ProviderSet ProviderSet { get; set; }
    }
}
