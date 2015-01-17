/*
* MATLAB Compiler: 4.17 (R2012a)
* Date: Fri Nov 15 15:25:35 2013
* Arguments: "-B" "macro_default" "-W" "dotnet:VECMATLIB,Transformation,0.0,private" "-T"
* "link:lib" "-d" "C:\Users\Gus\Desktop\vec\LIB\VECMATLIB\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{Transformation:C:\Users\Gus\Documents\MATLAB\fkin.m,C:\Users\Gus\Documents\MATLAB
* \LTransform.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace VECMATLIB
{

  /// <summary>
  /// The Transformation class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Gus\Documents\MATLAB\fkin.m
  /// <newpara></newpara>
  /// C:\Users\Gus\Documents\MATLAB\LTransform.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Transformation : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static Transformation()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "VECMATLIB.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Transformation class.
    /// </summary>
    public Transformation()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Transformation()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the fkin M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// q list of numbers, commands 1-5
    /// toolLength = 8 or 12 for long short tool
    /// T1b is transofrmation from T.m
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fkin()
    {
      return mcr.EvaluateFunction("fkin", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the fkin M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// q list of numbers, commands 1-5
    /// toolLength = 8 or 12 for long short tool
    /// T1b is transofrmation from T.m
    /// </remarks>
    /// <param name="q">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fkin(MWArray q)
    {
      return mcr.EvaluateFunction("fkin", q);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the fkin M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// q list of numbers, commands 1-5
    /// toolLength = 8 or 12 for long short tool
    /// T1b is transofrmation from T.m
    /// </remarks>
    /// <param name="q">Input argument #1</param>
    /// <param name="toolLength">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fkin(MWArray q, MWArray toolLength)
    {
      return mcr.EvaluateFunction("fkin", q, toolLength);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the fkin M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// q list of numbers, commands 1-5
    /// toolLength = 8 or 12 for long short tool
    /// T1b is transofrmation from T.m
    /// </remarks>
    /// <param name="q">Input argument #1</param>
    /// <param name="toolLength">Input argument #2</param>
    /// <param name="T1b">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fkin(MWArray q, MWArray toolLength, MWArray T1b)
    {
      return mcr.EvaluateFunction("fkin", q, toolLength, T1b);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the fkin M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// q list of numbers, commands 1-5
    /// toolLength = 8 or 12 for long short tool
    /// T1b is transofrmation from T.m
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fkin(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fkin", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the fkin M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// q list of numbers, commands 1-5
    /// toolLength = 8 or 12 for long short tool
    /// T1b is transofrmation from T.m
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="q">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fkin(int numArgsOut, MWArray q)
    {
      return mcr.EvaluateFunction(numArgsOut, "fkin", q);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the fkin M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// q list of numbers, commands 1-5
    /// toolLength = 8 or 12 for long short tool
    /// T1b is transofrmation from T.m
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="q">Input argument #1</param>
    /// <param name="toolLength">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fkin(int numArgsOut, MWArray q, MWArray toolLength)
    {
      return mcr.EvaluateFunction(numArgsOut, "fkin", q, toolLength);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the fkin M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// q list of numbers, commands 1-5
    /// toolLength = 8 or 12 for long short tool
    /// T1b is transofrmation from T.m
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="q">Input argument #1</param>
    /// <param name="toolLength">Input argument #2</param>
    /// <param name="T1b">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fkin(int numArgsOut, MWArray q, MWArray toolLength, MWArray T1b)
    {
      return mcr.EvaluateFunction(numArgsOut, "fkin", q, toolLength, T1b);
    }


    /// <summary>
    /// Provides an interface for the fkin function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// q list of numbers, commands 1-5
    /// toolLength = 8 or 12 for long short tool
    /// T1b is transofrmation from T.m
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void fkin(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("fkin", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the LTransform M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// m1=COMP(1:20,:);
    /// m2=long(1:20,:);
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LTransform()
    {
      return mcr.EvaluateFunction("LTransform", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the LTransform M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// m1=COMP(1:20,:);
    /// m2=long(1:20,:);
    /// </remarks>
    /// <param name="m1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LTransform(MWArray m1)
    {
      return mcr.EvaluateFunction("LTransform", m1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the LTransform M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// m1=COMP(1:20,:);
    /// m2=long(1:20,:);
    /// </remarks>
    /// <param name="m1">Input argument #1</param>
    /// <param name="commands">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LTransform(MWArray m1, MWArray commands)
    {
      return mcr.EvaluateFunction("LTransform", m1, commands);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the LTransform M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// m1=COMP(1:20,:);
    /// m2=long(1:20,:);
    /// </remarks>
    /// <param name="m1">Input argument #1</param>
    /// <param name="commands">Input argument #2</param>
    /// <param name="ToolLength">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LTransform(MWArray m1, MWArray commands, MWArray ToolLength)
    {
      return mcr.EvaluateFunction("LTransform", m1, commands, ToolLength);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the LTransform M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// m1=COMP(1:20,:);
    /// m2=long(1:20,:);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LTransform(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "LTransform", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the LTransform M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// m1=COMP(1:20,:);
    /// m2=long(1:20,:);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LTransform(int numArgsOut, MWArray m1)
    {
      return mcr.EvaluateFunction(numArgsOut, "LTransform", m1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the LTransform M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// m1=COMP(1:20,:);
    /// m2=long(1:20,:);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m1">Input argument #1</param>
    /// <param name="commands">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LTransform(int numArgsOut, MWArray m1, MWArray commands)
    {
      return mcr.EvaluateFunction(numArgsOut, "LTransform", m1, commands);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the LTransform M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// m1=COMP(1:20,:);
    /// m2=long(1:20,:);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m1">Input argument #1</param>
    /// <param name="commands">Input argument #2</param>
    /// <param name="ToolLength">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LTransform(int numArgsOut, MWArray m1, MWArray commands, MWArray 
                          ToolLength)
    {
      return mcr.EvaluateFunction(numArgsOut, "LTransform", m1, commands, ToolLength);
    }


    /// <summary>
    /// Provides an interface for the LTransform function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// m1=COMP(1:20,:);
    /// m2=long(1:20,:);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void LTransform(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("LTransform", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
