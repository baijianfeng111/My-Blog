//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerNew.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class bjf_block
    {
        public int id { get; set; }
        public string blockname { get; set; }
        public int isuse { get; set; }
        public int sortcode { get; set; }
        public bool isdelete { get; set; }
        public Nullable<System.DateTime> deletetime { get; set; }
        public int createid { get; set; }
        public System.DateTime createtime { get; set; }
        public int updateid { get; set; }
        public System.DateTime updatetime { get; set; }
    }
}
