 public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        
        [ForeignKey("State")]
		public int StateId{get;set;}
		

        public virtual State State { get; set; }
    }