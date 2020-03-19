using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using FFCtoDB.Models;
using FFCtoDB.Data;

namespace FFCtoDB
{
    public class Program
    { 
        static void Main(string[] args)
        {
            using (var db = new ReferenceContext())
            {
                db.Add(new Reference { xPoint = 0, yPoint = 0, RSSI = 0 });
            }
        }
    }
}
