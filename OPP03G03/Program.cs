using System.Timers;

namespace OPP03G03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //a) Overloading بيكون في نفس الكلاس بنفس الاسم بس بباراميترز مختلفة. أما Overriding فبيكون بين كلاس أساسي وكلاس فرعي لنفس الميثود باستخدام override
            //b)Static binding بيحصل وقت الـ Compile-time(في الـ Overloading).أما Dynamic binding بيحصل وقت الـ Run-time بناءً على نوع الكائن الفعلي في الـ Overriding
            #endregion
            #region 02
            //a)منع أي كلاس تاني إنه يورث من الكلاس ده(Stop inheritance)
           
            //b)الـ Sealed class بيمنع وراثة الكلاس بالكامل.الـ Sealed method بيسمح بوراثة الكلاس عادي، بس بيمنع الكلاسات الفرعية إنها تعمل Override للميثود دي
           
            //c)لا، لأن كلمة sealed بتمنع أي تعديل أو Override عليها في الكلاسات الوراثي
            #endregion

        }
    }
}
