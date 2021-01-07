namespace PrismJPKEditor.Business.Models
{
    public class JPK
    {
        public Buy Buy { get; set; }
        public Declaration Declaration { get; set; }
        public Sell Sell { get; set; }

        public JPK()
        {
            Buy = new Buy();
            Declaration = new Declaration();
            Sell = new Sell();
        }
    }
}
