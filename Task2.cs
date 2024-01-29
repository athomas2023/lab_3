using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{

    public double bookCoverPrice;
    public int bookCopiesSold;
    private double discountPercent = 0.40;
    private double fistCopyShippingCost = 3;
    private double copyShippingCost = 0.75;


    // Start is called before the first frame update
    void Start()
    {
        double costs = Math.Round(GetCosts(), 2);
        double profits = Math.Round(GetProfits(costs));

        Debug.Log($"If the book cover price was ${bookCoverPrice} and it sold {bookCopiesSold} copies, then it would have shipping costs of ${costs} and make ${profits} in profits");
    }


    double GetCosts()
    {
        double totalCosts = 0;
        int bookCopies = bookCopiesSold;

        bookCopies--;
        totalCosts += fistCopyShippingCost;

        if (bookCopies > 0)
        {
            totalCosts += bookCopies * copyShippingCost;
            return totalCosts;
        }
        else
        {
            return totalCosts;
        }
    }

    double GetProfits(double costs)
    {
        double totalprofits = 0;

        totalprofits = ((bookCoverPrice * discountPercent) * bookCopiesSold) - costs;

        return totalprofits; 
    }
}
