﻿using FluentNHibernate.Mapping;
using Izbori.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapping
{
    class Email_Mapiranja : ClassMap<Email>
    {
        public Email_Mapiranja()
        {
            Table("EMAIL");

            CompositeId(x => x.Id)
                .KeyReference(x => x.Aktivista, "ID_AKTIVISTE_STRANKE")
                .KeyProperty(x => x.Email, "EMAIL");

        }
    }
}
