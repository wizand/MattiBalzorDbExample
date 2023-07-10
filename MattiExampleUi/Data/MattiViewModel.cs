using MattiDb.Entities;

namespace MattiExampleUi.Data
{
    public class MattiViewModel
    {


        public MattiViewModel()
        {
                MittaustulosModel = new Mittaustulos();
        }
        public MattiViewModel(Mittaustulos mittaustulos) 
        {
            MittaustulosModel = mittaustulos;
        }
        
        public Mittaustulos MittaustulosModel { get; set; }
        public int Id { get => MittaustulosModel.MittaustulosId; set => MittaustulosModel.MittaustulosId = value; }
        public string Nimi { get => MittaustulosModel.Nimi; set => MittaustulosModel.Nimi = value; }

        public int Arvo

        {
            get
            {
                if (MittaustulosModel.Arvo == null)
                {
                    return -1;
                }

                return MittaustulosModel.Arvo.Value;
            }
            set => MittaustulosModel.Arvo = value;
        } 
    }
}