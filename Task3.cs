using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public int moneyPaid;
    private int moneyPaidRemaining;
    void Start()
    {
        moneyPaidRemaining = moneyPaid;
        int hundredDollarAmount = CheckHowManyInside(100);
        int fiftyDollarAmount = CheckHowManyInside(50);
        int twentyDollarAmount = CheckHowManyInside(20);
        int tenDollarAmount = CheckHowManyInside(10);
        int fiveDollarAmount = CheckHowManyInside(5);
        int oneDollarAmount = CheckHowManyInside(1);

        Debug.Log($"There are {hundredDollarAmount} hundred dollar bills, {fiftyDollarAmount} fifty dollar bills, {twentyDollarAmount} twenty dollar bills, {tenDollarAmount} ten dollar bills, {fiveDollarAmount} five dollar bills, and {oneDollarAmount} one dollar bills in {moneyPaid}");
    }



    private int CheckHowManyInside(int dollarAmount)
    {
        int billsCounted = 0;
        int moneyCounting = moneyPaidRemaining;

        while (moneyCounting > 0 && moneyCounting >= dollarAmount)
        {
            moneyCounting = moneyCounting - dollarAmount;
            Debug.Log(moneyCounting);

            if (moneyCounting < 0)
            {
                return billsCounted;
            }
            billsCounted++;
        }
        moneyPaidRemaining = moneyCounting;
        Debug.Log(moneyPaidRemaining);
        return billsCounted;
    }
}
