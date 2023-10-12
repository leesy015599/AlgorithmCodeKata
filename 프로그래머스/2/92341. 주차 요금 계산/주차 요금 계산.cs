using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] fees, string[] records) {
        Dictionary<int, int> parked = new Dictionary<int, int> ();
        Dictionary<int, int> carFee = new Dictionary<int, int> ();
        
        int time, car, prevTime;
        
        for (int i = 0; i < records.Length; i++)
        {
            time = TimeToMin(records[i].Substring(0, 5));
            car = int.Parse(records[i].Substring(6, 4));
            bool isIN = (records[i].Length == 13);
            if (isIN)
                parked.Add(car, time);
            else
            {
                parked.TryGetValue(car, out prevTime);
                if (carFee.ContainsKey(car))
                    carFee[car] = carFee[car] + time - prevTime;
                else
                    carFee.Add(car, time - prevTime);
                parked.Remove(car);
            }
        }
        
            foreach (KeyValuePair<int, int> item in parked)
            {
                car = item.Key;
                time = TimeToMin("23:59");
                prevTime = item.Value;
                if (carFee.ContainsKey(car))
                    carFee[car] = carFee[car] + time - prevTime;
                else
                    carFee.Add(car, time - prevTime);
                Console.WriteLine($"> {car}, {carFee[car]} <");
            }
        
        Dictionary<int, int> answer = new Dictionary<int, int> ();
        foreach (KeyValuePair<int, int> item in carFee)
        {
            int ceil = (int)Math.Ceiling((double)(item.Value - fees[0]) / (double)fees[2]);
            if (ceil < 0)
                ceil = 0;
            answer.Add(item.Key, fees[1] + ceil * fees[3]);
            Console.WriteLine($"{item.Key}, {fees[1]} + {ceil} * {fees[3]}");
        }
        
        return answer.OrderBy(item => item.Key).ToDictionary(x=>x.Key, x=>x.Value).Values.ToList().ToArray();
    }
    
    private int TimeToMin(string timeStr)
    {
        int timeMin = 0;
        
        timeMin += int.Parse(timeStr.Substring(0, 2)) * 60;
        timeMin += int.Parse(timeStr.Substring(3, 2));
        
        return timeMin;
    }
}