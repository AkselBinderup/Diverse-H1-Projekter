using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using OOP_intro.Settings;

namespace OOP_intro.Repositories;

internal partial class CommonDBModule<T>
{
    private readonly string file = "C:\\Users\\Z6APT\\Documents\\Programmering\\C#\\MontyHall\\OOP-intro\\Settings\\dbsettings.Json";
    protected SqlConnection GetConnection()
    {
        Directory.SetCurrentDirectory(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\.."));
        string filePath = @"Settings/dbsettings.Json";
        var ConfigSettingsContent = ReadConfigSettings.ReadSettings(file);
        var settings = Settings<DBSettings>.ReadintoObject(ConfigSettingsContent);
        var conn = new SqlConnection(settings.ConnectionString);
        conn.Open();
        return conn;
    }
    protected bool ExecuteCommand(string command)
    {
        try
        {
            using (var connection = GetConnection())
            {
                var rowsAffected = connection.Execute(command);
                return rowsAffected > 0;
            }
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
    protected int QuerySingleCommand(string command)
    {
        try
        {
            using (var connection = GetConnection())
                return int.Parse(connection.QueryFirst(command));
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            throw;
        }
    }
    protected List<T> ExecuteReader<T>(string command)
    {
        try
        {
            using (var connection = GetConnection())
            {
                var results = connection.Query<T>(command).ToList();
                return results;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            throw;
        }
    }
}
