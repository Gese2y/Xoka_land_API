namespace XOKA.Domain.Entities.Budget
{
    public class Document_Archive
    {
		public string Document_Number { get; set; }
		public string Title_Deed_No { get; set; }
		public System.DateTime? Regstration_Date { get; set; }
		public string Application_No  { get; set; }
		public string Room  { get; set; }
		public string Site  { get; set; }
		public string Block_Floor  { get; set; }
		public string Shelf_NO  { get; set; }
		public string Shelf_Raw  { get; set; }
		public string Shelf_Column  { get; set; }
		public System.Guid? Created_By  { get; set; }
		public System.Guid? Updated_By  { get; set; }
		public System.Guid? Deleted_By  { get; set; }
		public bool? Is_Deleted  { get; set; }
		public System.DateTime? Created_Date  { get; set; }
		public System.DateTime? Updated_Date  { get; set; }
		public System.DateTime? Deleted_Date   { get; set; }
    }
}
