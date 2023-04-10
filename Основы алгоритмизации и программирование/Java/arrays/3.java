import java.util.Scanner;
public class Main
{
    // 3.Вводится список (сначала количество элементов, потом сами элементы). 
    // Найдите сумму всех элементов и выведите её. А потом выведите введённые числа в обратном порядке.
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    System.out.println("Введите количество элементов:");
    int num = sc.nextInt();
    int arr[] = new int[num];
    System.out.println("Введите элементы: ");
    for (int i = 0; i < num; i++) {
        arr[i] = sc.nextInt();
    }
    int sum =0;
    for(int i=0; i < arr.length; i++){
        sum+=arr[i];
    }
    System.out.println("Сумма элементов: " + sum);
    System.out.println("Элементы в обратном порядке: ");
    for (int i = arr.length - 1; i >= 0; i--) {
        System.out.println(arr[i]);
    }

}  
}


