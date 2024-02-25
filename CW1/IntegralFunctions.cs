//

namespace RPS_Labs.CW1 {
    public class IntegralFunctions {
        public double TrapezoidalMethod(Func<double, double> func, double a, double b, double eps) {
            double[] res = new double[100];
            int j = 0;

            for (int i = 0; i <= 99; i++) {
                res[i] = 0;
            }

            double result;

            double h;
            double summa;

            for (int i_3 = 1; ; i_3 *= 2) {
                summa = 0;
                h = (b - a) / i_3;

                if (i_3 == 1) {
                    double x = a;
                    summa = func(x) * (h / 2);
                    x = b;
                    summa += func(x) * (h / 2);
                }
                else {
                    for (int i = 0; i <= i_3; i++) {
                        double x = a + i * h;
                        summa += func(x) * h;
                    }

                    double startX = a;
                    double endX = b;
                    summa -= func(startX) * (h / 2);
                    summa -= func(endX) * (h / 2);
                }

                j += 1;
                res[j] = summa;

                if (res[2] != 0) {
                    result = res[j] - res[j - 1];

                    if (Math.Abs(result) < eps) {
                        return summa;
                    }
                }
            }
        }
        
        public double ParabolicMethod(Func<double, double> func, double a, double b, double eps) {
            double[] res = new double[100];
            int j = 0;

            for (int i = 0; i <= 99; i++) {
                res[i] = 0;
            }

            double result;
            double h;
            double summa;

            for (int i_4 = 2; ; i_4 *= 2) {
                summa = 0;
                h = (b - a) / i_4;

                if (i_4 == 2) {
                    double x = a;
                    summa += func(x) * (h / 3);
                    x = b;
                    summa += func(x) * (h / 3);
                    x = a + h;
                    summa += 4 * func(x) * (h / 3);
                }
                else {
                    for (int i = 2; i <= (i_4 - 2); i += 2) {
                        double x = a + i * h;
                        summa += 2 * func(x) * (h / 3);
                    }

                    for (int i = 1; i <= (i_4 - 1); i += 2) {
                        double x = a + i * h;
                        summa += 4 * func(x) * (h / 3);
                    }

                    double startX = a;
                    double endX = b;
                    summa += func(startX) * (h / 3);
                    summa += func(endX) * (h / 3);
                }

                j += 1;
                res[j] = summa;

                if (res[2] != 0) {
                    result = res[j] - res[j - 1];

                    if (Math.Abs(result) < eps) {
                        return summa;
                    }
                }

                i_4 = 2 * i_4;
            }
        }
    }
}

/*
function Integral_3(obj,a_3,b_3,eps_3)
 {
   var fs = obj.func.value 

   var a_ = parseFloat(a_3)
   var b_ = parseFloat(b_3)
   var eps_ = parseFloat(eps_3)

   var i,j
   var Res_3 = new Array()
   var Result
   var h,Summa

   for(j=0;j<=99;j++) Res_3[j] = 0;

   j = 0

   for(i_3 = 1;;i_3 = 2 * i_3)
    {
      Summa = 0

      h = (b_ - a_) / i_3

      if(i_3==1)
       {
         x = a_
         Summa = eval(fs) * (h / 2)
         x = b_
         Summa+= eval(fs) * (h / 2)
       }
      else
       {
         for(i = 0;i<=i_3;i++)
          {
            x = a_ + i * h 
            Summa+=eval(fs) * h
          }
   
         x = a_
         Summa-=eval(fs) * (h / 2);
         x = b_
         Summa-=eval(fs) * (h / 2);
       }
      j+=1

      Res_3[j] = Summa

      window.status='Программа работает методом трапеций'

      if(Res_3[2])
       {
         Result = Res_3[j] - Res_3[j - 1]

         if(Math.abs(Result) < eps_)
          {
            return Summa
          }
       }
    }
 }

function Integral_4(obj,a_4,b_4,eps_4)
 {
   var fs = obj.func.value 

   var a_ = parseFloat(a_4)
   var b_ = parseFloat(b_4)
   var eps_ = parseFloat(eps_4)

   var h,Summa
   var Res_4 = new Array()
   var Result

   for(j=0;j<=99;j++) Res_4[j] = 0

   j = 0;

   for(i_4 = 2;;i_4 = 2 * i_4)
    {
      Summa = 0;

      h = (b_ - a_) / i_4;

      if(i_4==2)
       {
         x = a_ 
         Summa+= eval(fs) * (h / 3)
         x = b_
         Summa+= eval(fs) * (h / 3)
         x = a_ + h
         Summa+= 4 * eval(fs) * (h / 3)
      }

     else
      {
        for(i = 2;i<=(i_4 - 2);i+=2)
         {
           x = a_ + i * h 
	   Summa+=2 * eval(fs) * (h / 3)
         }
    
        for(i = 1;i<=(i_4 - 1);i+=2)
         {
           x = a_ + i * h  
           Summa+=4 * eval(fs) * (h / 3)
         }
    
       x = a_
       Summa+=eval(fs) * (h / 3);
       x = b_
       Summa+=eval(fs) * (h / 3);
      }

     j+=1

     Res_4[j] = Summa

     window.status='Программа работает методом Симпсона'

     if(Res_4[2])
      {
        Result = Res_4[j] - Res_4[j - 1]

        if(Math.abs(Result) < eps_)
         {
           return Summa
         }
      }
    }
  }
*/