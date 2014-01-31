namespace SetMeta.Web.ViewModels
{
    public class MetaDataViewModel : BaseViewModel
    {
        public string TypeName { get; set; }
        public string ParentName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }

        public override bool IsValid()
        {
            return true;
        }
    }
}