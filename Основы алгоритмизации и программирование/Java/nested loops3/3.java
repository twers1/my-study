import java.util.Scanner;
public class Main
{
    // 3.Напишите программу для графического изображения делимости чисел от 1 до n 
    // (значение переменной n вводится с клавиатуры). В каждой строке надо вывести число и столько плюсов,
    //  сколько делителей у этого числа (считая и единицу, и само число). 
    // Например, если исходное данное - число 4, то на экран должно быть выведено: 1+ 2++ 3++ 4+++
	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for(int i=0; i<n; i++){
            for(int j=0; j<n-i; j++) {
                System.out.println(" ");
            }
            for(int k=0;k<=i;k++){
                System.out.println(k + "+ ");
            }
        }

}  
}

