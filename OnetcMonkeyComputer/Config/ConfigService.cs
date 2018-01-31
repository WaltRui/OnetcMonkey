using OnetcMonkeyComputer.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnetcMonkeyComputer.Services.HnbcServices.Dtos;
using OnetcMonkeyComputer.Tools.Encrypt;
using OnetcMonkeyEncrypt;

namespace OnetcMonkeyComputer.Config
{
    public class ConfigService : IConfigService
    {
        private string fileName = "appconfig.json";
        private string overviewDataFile = "overview.json";
        private string appconfigFile= "";
        private string serverconfigFile = "servers.json";
        public ConfigService()
        {
            string exePath = System.Windows.Forms.Application.StartupPath;
            appconfigFile = Path.Combine(exePath, fileName);
        }


        public AppConfig ReadConfig()
        {
            AppConfig config = Default;
            try
            {
                if (!File.Exists(appconfigFile))
                {
                    Save(config);
                    return config;
                }
                var json_str = FileHelper.ReadFile(appconfigFile);
                config = JsonHelper.JsonToObject<AppConfig>(json_str);
                return config;
            }catch(Exception e)
            {
                Save(config);
                return config;
            }
        }
        public void Save(AppConfig config)
        {
            try
            {
                if (config == null)
                    return;
                var json_string = JsonHelper.ObjectToJson(config);
                FileHelper.WriteFile(appconfigFile, json_string);
            }catch(Exception e)
            {
                throw new Exception($"保存配置信息失败：{e.Message}");
            }
        }

        private AppConfig Default = new AppConfig()
        {
            ServerToken = null,
            Token=null,
            Wallet=null
        };

               
        public List<OverViewDataDto> ReadOverViewData()
        {
            List<OverViewDataDto> list  = new List<OverViewDataDto>();
            try
            {
                if (!File.Exists(overviewDataFile))
                {
                    SaveOverViewData(list);
                    return list;
                }
                var json_str = FileHelper.ReadFile(overviewDataFile);
                list = JsonHelper.JsonToObject<List<OverViewDataDto>>(json_str);
                return list;
            }
            catch (Exception e)
            {
                SaveOverViewData(list);
                return list;
            }
        }

        public void SaveOverViewData(List<OverViewDataDto> data)
        {
            try
            {
                if (data == null)
                    return;
                var json_string = JsonHelper.ObjectToJson(data);
                FileHelper.WriteFile(overviewDataFile, json_string);
            }
            catch (Exception e)
            {
                throw new Exception($"保存数据信息失败：{e.Message}");
            }
        }

        public List<ServerInfo> ReadMonkeyServers()
        {
            List<ServerInfo> servers = new List<ServerInfo>();
            try
            {
                if (!File.Exists(serverconfigFile))
                {
                    SaveMonkeyServers(servers);
                    return servers;
                }
                var json_str = FileHelper.ReadFile(serverconfigFile);
                servers = JsonHelper.JsonToObject<List<ServerInfo>>(json_str);
                return servers;
            }
            catch (Exception e)
            {
                SaveMonkeyServers(servers);
                return servers;
            }
        }
        public void SaveMonkeyServers(List<ServerInfo> servers)
        {
            try
            {
                if (servers == null)
                    return;
                var json_string = JsonHelper.ObjectToJson(servers);
                FileHelper.WriteFile(serverconfigFile, json_string);
            }
            catch (Exception e)
            {
                throw new Exception($"保存配置信息失败：{e.Message}");
            }
        }


        public UserConfig GetUserConfig()
        {
            if (!File.Exists(appconfigFile))
            {
                return new UserConfig { IsSearchEnable = false,Disabled =false };
            }
            var json_str = FileHelper.ReadFile(appconfigFile);
            var config = JsonHelper.JsonToObject<AppConfig>(json_str);

            var a= config.UserConfig;
            try
            {
                var str = UserConfigEncrypt.Symmetry_Decode(a);
                var userconfig =JsonHelper.JsonToObject<UserConfig>(str);
                if(userconfig.Wallet !=config.Wallet)
                    return new UserConfig { IsSearchEnable = false, Disabled = false };
                return userconfig;
            }
            catch {
                return new UserConfig { IsSearchEnable = false, Disabled = false };
            }

        }
    }
}
