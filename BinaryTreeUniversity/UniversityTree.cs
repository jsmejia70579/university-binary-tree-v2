using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;

        public void CreatePosition(PositionNode parent, Position positionToCreate, string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;
            
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            if(parent == null)
            {
                return;
            }

            if(parent.Position.Name == parentPositionName)

            {
                if (parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }
                parent.Right = newNode;
                return;
            }

            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);
        }

        public void PrintTree(PositionNode from)
        {
            if(from == null)
            {
                return;
            }

            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");

            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        public float AddSalaries(PositionNode from)
        {
            if(from==null)
            {
                return 0;
            }
            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right);
        }

        //SECOND PART OF THE EXCERCISE
        //Get the longest salary (without including "the principal". Point 1
        public float longestSalary(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Name == "Rector")
            {
                if (longestSalary(from.Left) > longestSalary(from.Right))
                {
                    return longestSalary(from.Left);
                }
                else
                {
                    return longestSalary(from.Right);
                }
            }
            else
            {
                if (longestSalary(from.Left)>from.Position.Salary || longestSalary(from.Right) > from.Position.Salary)
                {
                    if (longestSalary(from.Left) > longestSalary(from.Right))
                    {
                        return longestSalary(from.Left);
                    }
                    else
                    {
                        return longestSalary(from.Right);
                    }
                }
                else
                {
                    return from.Position.Salary;
                }
            }
        }

        //Sum of the number of people that the tree has
        public float amountPersonal(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return 1 + amountPersonal(from.Left) + amountPersonal(from.Right);
        }

        //Calculate the salary average, point 2
        public float averageSalaries(PositionNode from)
        {
            return AddSalaries(from) / amountPersonal(from);
        }

        //How much is the salary given a certain position, Point 3
        public float salaryEmployee(PositionNode from,string name)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Name == name)
            {
                return from.Position.Salary;
            }
            return salaryEmployee(from.Left, name) + salaryEmployee(from.Right, name);
        }

        //Add salary tax (percentaje 0%-30%), each position has a different tax percentaje, Point 4
        public float taxSalary(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return (from.Position.Salary * Convert.ToSingle(from.Position.Tax)) + taxSalary(from.Left) + taxSalary(from.Right);

        }
    }
}
