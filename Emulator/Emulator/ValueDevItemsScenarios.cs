//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emulator
{
    using System;
    using System.Collections.Generic;
    
    public partial class ValueDevItemsScenarios
    {
        public int ID { get; set; }
        public int ID_Device { get; set; }
        public int ID_DeviceType { get; set; }
        public int ID_RefItemsScen { get; set; }
    
        public virtual ReferenceItemsScenarios ReferenceItemsScenarios { get; set; }
    }
}
