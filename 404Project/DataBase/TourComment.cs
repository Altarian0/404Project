//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _404Project.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class TourComment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Nullable<int> Rating { get; set; }
        public int TourId { get; set; }
        public Nullable<int> AuthorId { get; set; }
    
        public virtual Tour Tour { get; set; }
        public virtual User User { get; set; }
    }
}
