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
    
    public partial class Comps
    {
        public int ID { get; set; }
        public int Gindex { get; set; }
        public string Name { get; set; }
        public string Psevdonim { get; set; }
        public string TCP_IP { get; set; }
        public int Gtype { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<int> Works { get; set; }
        public Nullable<int> TypeEvents { get; set; }
        public string IpReservSrv { get; set; }
        public string AbonentNumber { get; set; }
        public Nullable<System.Guid> ApplicationGuid { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public string Workstation { get; set; }
        public string Comment { get; set; }
    }
}