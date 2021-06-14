namespace FifthGenKpop
{
    public class KpopGroup
    {

        public string visual { get; set; }
        
        public string mainVocalist { get; set; }
        public string leadVocalist { get; set; }
        public string mainDancer { get; set; }
        public string leadDancer { get; set; }
        public string rapper { get; set; }

        public KpopGroup()
        {
            
        }
        
        public KpopGroup(KpopGroup k)
        {
            visual = k.visual;
            mainVocalist = k.mainVocalist;
            leadVocalist = k.leadVocalist;
            mainDancer = k.mainDancer;
            leadDancer = k.leadDancer;
            rapper = k.rapper;
        }
        public KpopGroup(string _visual, string _mainVocalist, string _leadVocalist, string _mainDancer, string _leadDancer, string _rapper)
        {
            visual = _visual;
            mainVocalist = _mainVocalist;
            leadVocalist = _leadVocalist;
            mainDancer = _mainDancer;
            leadDancer = _leadDancer;
            rapper = _rapper;
        }
        public KpopGroup(string mainDancer, string leadDancer)
        {
            this.mainDancer = mainDancer;
            this.leadDancer = leadDancer;
        }
    }
}
