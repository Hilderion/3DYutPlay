using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;


public class Generator
{
    #region singleton
    private static Generator _instance;

    public static Generator Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Generator();

            return _instance;
        }
    }

    private Generator()
    {
    }
    #endregion

    private int _number;

    public void Run()
    {
        var args1 = OnNumberGeneratingForOut();

        _number += args1.Interval;
        OnNumberGenerated(_number);

        var arg2 = OnStringGeneratingForOut();
        OnStringGenerated(arg2.Name);
    }

    #region StringGenerating event things for C# 3.0
    public event EventHandler<StringGeneratingEventArgs> StringGenerating;

    protected virtual void OnStringGenerating(StringGeneratingEventArgs e)
    {
        if (StringGenerating != null)
            StringGenerating(this, e);
    }

    private StringGeneratingEventArgs OnStringGenerating(string name)
    {
        StringGeneratingEventArgs args = new StringGeneratingEventArgs(name);
        OnStringGenerating(args);

        return args;
    }

    private StringGeneratingEventArgs OnStringGeneratingForOut()
    {
        StringGeneratingEventArgs args = new StringGeneratingEventArgs();
        OnStringGenerating(args);

        return args;
    }

    public class StringGeneratingEventArgs : EventArgs
    {
        public string Name { get; set; }

        public StringGeneratingEventArgs()
        {
        }

        public StringGeneratingEventArgs(string name)
        {
            Name = name;
        }
    }
    #endregion

    #region StringGenerated event things for C# 3.0
    public event EventHandler<StringGeneratedEventArgs> StringGenerated;

    protected virtual void OnStringGenerated(StringGeneratedEventArgs e)
    {
        if (StringGenerated != null)
            StringGenerated(this, e);
    }

    private StringGeneratedEventArgs OnStringGenerated(string name)
    {
        StringGeneratedEventArgs args = new StringGeneratedEventArgs(name);
        OnStringGenerated(args);

        return args;
    }

    private StringGeneratedEventArgs OnStringGeneratedForOut()
    {
        StringGeneratedEventArgs args = new StringGeneratedEventArgs();
        OnStringGenerated(args);

        return args;
    }

    public class StringGeneratedEventArgs : EventArgs
    {
        public string Name { get; set; }

        public StringGeneratedEventArgs()
        {
        }

        public StringGeneratedEventArgs(string name)
        {
            Name = name;
        }
    }
    #endregion

    #region NumberGenerating event things for C# 3.0
    public event EventHandler<NumberGeneratingEventArgs> NumberGenerating;

    protected virtual void OnNumberGenerating(NumberGeneratingEventArgs e)
    {
        if (NumberGenerating != null)
            NumberGenerating(this, e);
    }

    private NumberGeneratingEventArgs OnNumberGenerating(int interval)
    {
        NumberGeneratingEventArgs args = new NumberGeneratingEventArgs(interval);
        OnNumberGenerating(args);

        return args;
    }

    private NumberGeneratingEventArgs OnNumberGeneratingForOut()
    {
        NumberGeneratingEventArgs args = new NumberGeneratingEventArgs();
        OnNumberGenerating(args);

        return args;
    }

    public class NumberGeneratingEventArgs : EventArgs
    {
        public int Interval { get; set; }

        public NumberGeneratingEventArgs()
        {
        }

        public NumberGeneratingEventArgs(int interval)
        {
            Interval = interval;
        }
    }
    #endregion

    #region NumberGenerated event things for C# 3.0
    public event EventHandler<NumberGeneratedEventArgs> NumberGenerated;

    protected virtual void OnNumberGenerated(NumberGeneratedEventArgs e)
    {
        if (NumberGenerated != null)
            NumberGenerated(this, e);
    }

    private NumberGeneratedEventArgs OnNumberGenerated(int generatedNumber)
    {
        NumberGeneratedEventArgs args = new NumberGeneratedEventArgs(generatedNumber);
        OnNumberGenerated(args);

        return args;
    }

    private NumberGeneratedEventArgs OnNumberGeneratedForOut()
    {
        NumberGeneratedEventArgs args = new NumberGeneratedEventArgs();
        OnNumberGenerated(args);

        return args;
    }

    public class NumberGeneratedEventArgs : EventArgs
    {
        public int GeneratedNumber { get; set; }

        public NumberGeneratedEventArgs()
        {
        }

        public NumberGeneratedEventArgs(int generatedNumber)
        {
            GeneratedNumber = generatedNumber;
        }
    }
    #endregion
}