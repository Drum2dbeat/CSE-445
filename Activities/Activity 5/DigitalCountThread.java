package activity_5;

/*
 * Name:	Oscar Jara
 * Date:	1/25/19
 * Class:	CSE 445
 */

public class DigitalCountThread extends Thread{

	int count;
	String str;
	
	public DigitalCountThread(String str) {
		count = 0;
		this.str = str;
	}
	
	public void run() {
		count();
	}
	
	public void count() {
		for (int i = 0; i < str.length(); i++)
			if(Character.isDigit(str.charAt(i)))
				count++;
	}
	
	public int getCount() {
		return count;
	}
}
