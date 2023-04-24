import java.util.Scanner;
public class Main
{
    // 1.Вводится натуральное число n (n > 1). На следующей строчке вводятся n целых чисел. 
    // Считайте их как массив на n элементов. Найдите количество элементов, которые больше предыдущего элемента.
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
	System.out.println("Введите количество элементов: (должно быть больше одного)");
    int n = sc.nextInt();
    
    
    int[] arr = new int[n];
    System.out.println("Введите элементы:");
	for (int i = 0; i < n; i++) {
	    arr[i] = sc.nextInt();
	} 
    int count = 0;
    System.out.println("Ответ на задание: ");
    for(int i=1; i< arr.length; i++){
        if(arr[i] > arr[i-1]) {
            count++;
        }
    }

    System.out.println(count);
   
	
	
	
    

}  
}


