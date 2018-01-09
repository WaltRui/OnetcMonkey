using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Eggs
{
    public class AvatarEggs
    {
        public static List<Egg> Eggs = new List<Egg>() {
            //绿帽子梗
            new Egg(51,"2","哎哟，帽子不错哟，颜色挺鲜艳的！"),
            new Egg(51,"2","看这帽子颜色，就知道，你也是个有故事的猴子！"),
            new Egg(51,"2","当然选择原谅TA咯，不然怎么办？"),
            new Egg(51,"2","我能怎么办，生出来就戴着这个帽子啊，还不能换！"),
            new Egg(51,"2","绿色的！"),
            new Egg(51,"2","看到没，这就是缘分，我跟主人戴了同一款帽子！"),

            //Winer
            new Egg(62,"d","看到老子胸前的字了吗，爱买买，不买滚！"),
            new Egg(62,"d","我和隔壁那傻缺Loser不一样，老子天生的Winer！"),
            new Egg(62,"d","谁说没有人是天生的成功者的，我是啊"),
            new Egg(62,"d","0代猴牛逼啊，1代猴牛逼啊？老子才是Winer！"),
            new Egg(62,"d","看什么看，买不起就滚，你个Loser！"),

            //Loser
            new Egg(62,"a","不说话，看我胸前的字，你个..."),
            new Egg(62,"a","哪个傻叉生的我，生我就生吧，还在胸口刻上这个字..."),
            new Egg(62,"a","都说世界上没有天生的Winer，但我是天生的Loser！"),
            new Egg(62,"a","老子就是穷，就是不涨肉，你咬我啊，你个Loser！"),
            new Egg(62,"a","看着我的胸前的字，跟我一起读：我是 L o s e r ！"),

            //Loser
            new Egg(62,"b","我爸爸姓雷，只能说这么多了。"),
            new Egg(62,"b","那天，听完你在印度演讲，我默默的在胸前写下这几个字"),
            new Egg(62,"b","我记得有首歌，是雷军专门为我唱的。"),
            new Egg(62,"b","别看我是只猴子，我爸是玩客云和星域CDN的股东"),
            new Egg(62,"b","如果你用小米手机，建议你买下我，咱们是一家人！"),

            //Loser
            new Egg(62,"e","我是BED BOY，不是BAD BOY"),
            new Egg(62,"e","谁能告诉我，我胸前的字什么意思？"),
        };

    }
    public class Egg
    {
        public Egg(int index,string value,string text)
        {
            Index = index;
            Value = value;
            Text = text;
        }
        public int Index { get; set; }

        public string Value { get; set; }

        public string Text { get; set; }
    }
}
