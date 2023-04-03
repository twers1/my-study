
import java.util.Scanner;
public class Main
{
    // 6.Дано натуральное число. Напишите программу, которая вычисляет:количество цифр 3 в нем;
    // сколько раз в нем встречается последняя цифра;количество четных цифр;сумму его цифр, больших пяти;
    // произведение цифр, больших семи (если цифр больших семи нет, то вывести 1, если такая цифра одна, то вывести ее);
    // сколько раз в нем встречается цифры 0 и 5 (всего суммарно).
        public static void main(String[] args) {
            Scanner sc = new Scanner(System.in);
            System.out.println("Введите любое число: ");
            int n = sc.nextInt();
            int count3 = 0;
            int countLast = 0;
            int countChet = 0;
            int sumBig5 = 0;
            int multyBig7 = 1;
            int count05 = 0;
            int last = n % 10;
            while(n>0) {
                int x = n %10;
                if(x==3) {
                    count3+=1;
                }
                if(x==last){
                    countLast +=1;
                }
                if(x%2==0){
                    countChet+=1;
                }
                if(x>5) {
                    sumBig5 +=x;
                }
                if(x>7) {
                    multyBig7 *=x;
                }
                if(x==0 || x==5){
                    count05+=1;
                }
                n/=10;
            }
            System.out.println(count3);
            System.out.println(countLast);
            System.out.println(countChet);
            System.out.println(sumBig5);
            System.out.println(multyBig7);
            System.out.println(count05);
            
        }

}  


