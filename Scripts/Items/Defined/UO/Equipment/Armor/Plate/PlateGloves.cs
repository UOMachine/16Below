using System;

namespace Server.Items
{
    [FlipableAttribute(0x1414, 0x1418)]
    public class PlateGloves : BaseArmor
    {
        [Constructable]
        public PlateGloves()
            : base(0x1414)
        {
            this.Weight = 2.0;
        }

        public PlateGloves(Serial serial)
            : base(serial)
        {
        }


        public override int InitMinHits
        {
            get
            {
                return 50;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 65;
            }
        }

        public override int OldStrReq
        {
            get
            {
                return 30;
            }
        }
        public override int OldDexBonus
        {
            get
            {
                return -2;
            }
        }
        public override int ArmorBase
        {
            get
            {
                return 40;
            }
        }
        public override ArmorMaterialType MaterialType
        {
            get
            {
                return ArmorMaterialType.Plate;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (this.Weight == 1.0)
                this.Weight = 2.0;
        }
    }
}