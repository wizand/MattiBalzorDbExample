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
        public bool HasChanges = false;
        public int Id 
        {
            get => MittaustulosModel.MittaustulosId; 
        }

        public string Nimi { get => MittaustulosModel.Nimi; 
            set 
            {
                if (MittaustulosModel.Nimi == value) 
                { 
                    return; 
                }
                MittaustulosModel.Nimi = value;
                HasChanges = true;
            }
        }

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
            set
            {
                if (MittaustulosModel.Arvo == value)
                {
                    return;
                }

                MittaustulosModel.Arvo = value;
                HasChanges = true;
            }
        }

        public string InsertDate
        {
            get
            {
                return MittaustulosModel.InsertDate.ToString();
            } 
        }

        public string UpdateDate
        {
            get
            {
                return MittaustulosModel.UpdateDate.ToString();
            }
        }
    }
}