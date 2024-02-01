namespace C_SHARP_CODING
{
    public abstract class BaseClass
    {
        public bool IsNew { get; set; }
        public bool HasChanges { get; set; }
        public ObjectStateOptions ObjectState { get; set; }
        public bool DataIsCorrect
        {
            get
            {
                return validate();
            }
        }

        public abstract bool validate();
    }

    public enum ObjectStateOptions
    {
        Active,
        Deleted
    }
}
