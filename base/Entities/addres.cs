using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;

namespace Entities
{
    public class addres
    {
        public addres()
        {
            public virtual int id { get; set; }
            public virtual string addres { get; set; }
        public virtual void add(addres _addres)
            {
                using (var session FluentNHibernateHelper.OpenSession()) 
            } 
        }
    }
}