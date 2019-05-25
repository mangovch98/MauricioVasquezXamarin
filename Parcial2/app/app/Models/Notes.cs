using System;

namespace app.Models
{
    public class Notes
    {
        [Key]
        public int NotesId { get; set; }
        public string Contents { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Notes()
        {
            this.CreatedDate = DateTime.Equals;
            this.ModifiedDate = DateTime.Now;
        }

    }
}
