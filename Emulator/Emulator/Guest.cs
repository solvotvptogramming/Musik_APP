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
    
    public partial class Guest
    {
        public int ID { get; set; }
        public int PListID { get; set; }
        public Nullable<int> ReceiveListId { get; set; }
        public Nullable<int> CompanyReceive { get; set; }
        public Nullable<int> SectionReceive { get; set; }
        public string Comment { get; set; }
        public string Avto { get; set; }
        public string AutoNumber { get; set; }
        public string Automarka { get; set; }
        public string AutoColor { get; set; }
        public Nullable<int> AutoNigth { get; set; }
        public Nullable<System.DateTime> DateVisit { get; set; }
        public string ReceiveGuestName { get; set; }
        public string ReceiveGuestFamaly { get; set; }
        public string ReceiveGuestSecondName { get; set; }
        public string ReceiveGuestRoom { get; set; }
        public string ReceiveGuestPhone { get; set; }
        public string goalvisit { get; set; }
        public Nullable<int> RuleAccess { get; set; }
        public Nullable<int> IDNoFace { get; set; }
        public Nullable<System.DateTime> DateVisitEnd { get; set; }
        public Nullable<int> RecRoomID { get; set; }
    
        public virtual pList pList { get; set; }
    }
}