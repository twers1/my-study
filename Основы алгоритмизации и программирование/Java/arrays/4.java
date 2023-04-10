import java.util.Scanner;
public class Main
{
    // 4.Вводится массив (сначала количество элементов, потом сами элементы). Найдите сумму его элементов 
    // с чётными индексами и выведите её. А потом выведите числа, которые суммировались.
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    System.out.println("Введите количество элементов:");
    int num = sc.nextInt();
    int arr[] = new int[num];
    System.out.println("Введите элементы: ");
    for (int i = 0; i < num; i++) {
        arr[i] = sc.nextInt();
    }
    int sum = 0;
    System.out.println("Выводим сумму элементов с четными индексами и числа: ");
    for (int i = 0; i < arr.length; i++) {
        
        if(i%2==0){
            sum+=arr[i];
            System.out.println("Числа: "+ arr[i]);
        }
        
    }
    System.out.println("Сумма: " + sum);
    

}  
}


