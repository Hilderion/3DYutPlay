using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class MapObject
    {
        //필드, 지하, 산
        //스탯변동, 산적, 우물, 교차점

        String mapType, tag;
        public List<Unit> P1units;
        public List<Unit> P2units;

        public void setmapType(String mapType)
        {
            this.mapType = mapType;
        }

        public String getmapType()
        {
            return mapType;
        }

        public void setTag(String tag)
        {
            this.tag = tag;
        }

        public String getTag()
        {
            return tag;
        }
    }
}