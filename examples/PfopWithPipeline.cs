using Qiniu.Util;
using Qiniu.Http;
using Qiniu.Processing;
    
namespace QiniuDemo
{
    public class PfopWithPipeline
    { 
        public static void pfopAndSave()
        {	
	        string bucket = "BUCKET"; 
			string key = "FILE";  
			string pipeline = "MEDIAPROC_PIPELINE"; 
			string notifyUrl = "NOTIFY_URL";
			bool   force = false;	
            
			string saveAsUri = StringUtils.urlSafeBase64Encode("<SAVEAS_BUCKET>:<SAVEAS_KEY>");	
			string fops = "<FOPS>" + "|saveas/" + saveAsUri;

			Mac mac = new Mac(Settings.AccessKey,Settings.SecretKey);
			Pfop px = new Pfop(mac);
			PfopResult result = px.pfop(bucket, key, fops, pipeline, notifyUrl, force);

			System.Console.WriteLine(result.Response);

            // �Ժ���Ը���PersistentId��ѯ�������/���
            string persistentId = result.PersistentId;
            Prefop pz = new Prefop(persistentId);
            PrefopResult zr = pz.prefop();
            System.Console.WriteLine(zr.Response);

		}
	}
}