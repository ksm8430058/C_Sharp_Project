using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moogabox
{
    class StoreOrder
    {
        // 메뉴 한 개당 곱해야할 가격 종류
        private int won2500 = 2500, won3000 = 3000, won4000 = 4000, won5000 = 5000, won6000 = 6000, won9000 = 9000, 
            won12000 = 12000, won14000 = 14000, won6500 = 6500;

        // 각 메뉴별 카운트 ( 수량이랑 금액 계산때문에 1로 둠)
        private int popcorn1Count = 1, popcorn2Count = 1, popcorn3Count = 1, popcorn4Count = 1, drink1Count = 1,
            drink2Count = 1, drink3Count = 1, drink4Count = 1, set1Count = 1, set2Count = 1, set3Count = 1, set4Count = 1;

        // 각 메뉴별 주문한 총 금액
        private int popcorn1Cash = 0, popcorn2Cash = 0, popcorn3Cash = 0, popcorn4Cash = 0, drink1Cash = 0,
            drink2Cash = 0, drink3Cash = 0, drink4Cash = 0, set1Cash = 0, set2Cash = 0, set3Cash = 0, set4Cash = 0;

        // 메뉴 수량 프로퍼티
        public int popcorn1Cnt
        {
            get { return popcorn1Count; }
            set { popcorn1Count = value; }
        }

        public int popcorn2Cnt
        {
            get { return popcorn2Count; }
            set { popcorn2Count = value; }
        }

        public int popcorn3Cnt
        {
            get { return popcorn3Count; }
            set { popcorn3Count = value; }
        }

        public int popcorn4Cnt
        {
            get { return popcorn4Count; }
            set { popcorn4Count = value; }
        }

        public int drink1Cnt
        {
            get { return drink1Count; }
            set { drink1Count = value; }
        }

        public int drink2Cnt
        {
            get { return drink2Count; }
            set { drink2Count = value; }
        }

        public int drink3Cnt
        {
            get { return drink3Count; }
            set { drink3Count = value; }
        }

        public int drink4Cnt
        {
            get { return drink4Count; }
            set { drink4Count = value; }
        }

        public int set1Cnt
        {
            get { return set1Count; }
            set { set1Count = value; }
        }

        public int set2Cnt
        {
            get { return set2Count; }
            set { set2Count = value; }
        }

        public int set3Cnt
        {
            get { return set3Count; }
            set { set3Count = value; }
        }

        public int set4Cnt
        {
            get { return set4Count; }
            set { set4Count = value; }
        }

        // 메뉴 금액 프로퍼티
        public int popcorn1Price
        {
            get { return popcorn1Cash; }
            set { popcorn1Cash = value; }
        }

        public int popcorn2Price
        {
            get { return popcorn2Cash; }
            set { popcorn2Cash = value; }
        }

        public int popcorn3Price
        {
            get { return popcorn3Cash; }
            set { popcorn3Cash = value; }
        }

        public int popcorn4Price
        {
            get { return popcorn4Cash; }
            set { popcorn4Cash = value; }
        }

        public int drink1Price
        {
            get { return drink1Cash; }
            set { drink1Cash = value; }
        }

        public int drink2Price
        {
            get { return drink2Cash; }
            set { drink2Cash = value; }
        }

        public int drink3Price
        {
            get { return drink3Cash; }
            set { drink3Cash = value; }
        }

        public int drink4Price
        {
            get { return drink4Cash; }
            set { drink4Cash = value; }
        }

        public int set1Price
        {
            get { return set1Cash; }
            set { set1Cash = value; }
        }

        public int set2Price
        {
            get { return set2Cash; }
            set { set2Cash = value; }
        }

        public int set3Price
        {
            get { return set3Cash; }
            set { set3Cash = value; }
        }

        public int set4Price
        {
            get { return set4Cash; }
            set { set4Cash = value; }
        }

        // 메뉴 총 금액 프로퍼티
        public int popcorn1Sum()
        {
            popcorn1Cash = popcorn1Count * won4000;
            return popcorn1Cash;
        }

        public int popcorn2Sum()
        {
            popcorn2Cash = popcorn2Count * won5000;
            return popcorn2Cash;
        }

        public int popcorn3Sum()
        {
            popcorn3Cash = popcorn3Count * won5000;
            return popcorn3Cash;
        }

        public int popcorn4Sum()
        {
            popcorn4Cash = popcorn4Count * won6000;
            return popcorn4Cash;
        }

        public int drink1Sum()
        {
            drink1Cash = drink1Count * won2500;
            return drink1Cash;
        }

        public int drink2Sum()
        {
            drink2Cash = drink2Count * won3000;
            return drink2Cash;
        }

        public int drink3Sum()
        {
            drink3Cash = drink3Count * won2500;
            return drink3Cash;
        }

        public int drink4Sum()
        {
            drink4Cash = drink4Count * won3000;
            return drink4Cash;
        }

        public int set1Sum()
        {
            set1Cash = set1Count * won9000;
            return set1Cash;
        }

        public int set2Sum()
        {
            set2Cash = set2Count * won12000;
            return set2Cash;
        }

        public int set3Sum()
        {
            set3Cash = set3Count * won14000;
            return set3Cash;
        }

        public int set4Sum()
        {
            set4Cash = set4Count * won6500;
            return set4Cash;
        }
    }
}
