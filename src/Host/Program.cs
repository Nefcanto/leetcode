using System;
using System.Diagnostics;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            // [5,4,8,11,null,13,4,7,2,null,null,null,1]
            var result = new PathSum().HasPathSum(

                new TreeNode(5,
                    new TreeNode(4,
                        new TreeNode(11,
                            new TreeNode(7),
                            new TreeNode(2)
                            ),
                        null
                    ),
                    new TreeNode(8,
                            new TreeNode(13),
                            new TreeNode(4,
                                null,
                                new TreeNode(1)
                                )
                        )
                ),
                22

                );

        }
    }
}
