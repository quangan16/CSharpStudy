using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vector
{
    public class Vector
    {
        private double x;
        private double y;
        public Vector(){

        }
        public Vector(double _x, double _y){
            this.x = _x;
            this.y = _y;
        }

        public void Print(){
            Console.WriteLine($"X value = {this.x:F3} / Y value = {this.y:F3}");
        }

        public static Vector operator+(Vector v1, Vector v2){
            Vector v3 = new Vector();
            v3.x = v1.x + v2.x;
            v3.y = v1.y + v2.y;
            return v3;
        }

        public static Vector operator*(Vector v1, Vector v2){
            double x = v1.x * v2.x;
            double y = v1.y * v2.y;
            Vector v3 = new Vector(x, y);
            return v3;
            
        }

        public static Vector operator*(Vector v1, double d){
            double x = v1.x * d;
            double y = v1.y * d;
            Vector v3 = new Vector(x, y);
            return v3;
            
        }

        public double this[double x]{
            set{
                switch(x){
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    default:
                        throw new Exception("Wrong Input!!!");
                    
                }
            }
            get{
                switch(x){
                    case 0:
                        return this.x;
                    case 1:
                        return this.y;
                    default:
                         throw new Exception("Wrong Input!!!");
                }
            }
        }
    }
}