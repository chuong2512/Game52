// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("+v/nePcpZpegywTb8WCOs0pbkfydplAdKkACvvyKfb6AFU09reZhWbQYG8814qbBSaQ3bo9Jk2Ne8O2quREgnwY9etiPh1Jj2zlqYrCbOHjuUS8q6wLbKDx/6M1q65Xn2CTtbY0/vJ+NsLu0lzv1O0qwvLy8uL2+P7yyvY0/vLe/P7y8vWdstpE8B1VmgN9rVJC9pDW3vM8vQF/VreXu6j8Frt9rcY0HGIHJrLoWebZD5wMIKsbHDpLmFvvOtGaQDulpmyNugRDm6nW0UNTdxoLvWl+zV9XcrX2mVlFTfUoBUP12frffLX/MgU+bC6C00GNK5JnSL6+yGfq9wmbAImi9p6Fbrm3rroGAXHRxoHCHbWvgsfdCyjvtONsq3IgciL++vL28");
        private static int[] order = new int[] { 8,7,11,13,10,8,7,13,9,12,12,11,13,13,14 };
        private static int key = 189;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
