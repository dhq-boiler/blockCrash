using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    enum EStageType
    {
        UNKNOWN,
        ONAJIMISAN,
        FOURTOWER,
        CROSSCROSS,
        LAWOFCYCLES,
        PRODUCTORISUS
    }

    abstract class StageBuilder
    {
        abstract public void CreateStage(out Block[] block, ref int sumblock, bool extendOn);

        public static StageBuilder CreateStageBuilder(EStageType StageType)
        {
            StageBuilder builder = null;

            switch (StageType)
            {
                case EStageType.ONAJIMISAN:
                    builder = new OnajimisanBuilder();
                    break;
                case EStageType.FOURTOWER:
                    builder = new FourTowerBuilder();
                    break;
                case EStageType.CROSSCROSS:
                    builder = new CrossCrossBuilder();
                    break;
                case EStageType.LAWOFCYCLES:
                    builder = new LawOfCyclesBuilder();
                    break;
                case EStageType.PRODUCTORISUS:
                    builder = new ProductorIsUsBuilder();
                    break;
                default:
                    builder = null;
                    break;
            }

            return builder;
        }
    }
}
