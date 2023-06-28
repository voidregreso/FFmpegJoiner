using System;
using System.Windows.Forms;

namespace FFmpeg_Joiner
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003B6C File Offset: 0x00001D6C
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
