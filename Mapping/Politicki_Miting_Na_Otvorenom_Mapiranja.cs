﻿using FluentNHibernate.Mapping;
using Izbori.Entities;

namespace Izbori.Mapping
{
    class Politicki_Miting_Na_Otvorenom_Mapiranja : SubclassMap<Politicki_Miting_Na_Otvorenom>
    {
        public Politicki_Miting_Na_Otvorenom_Mapiranja()
        {
            Table("POLITICKI_MITING_NA_OTVORENOM");

            KeyColumn("ID_IZBORNE_AKTIVNOSTI");

        }
    }

}
