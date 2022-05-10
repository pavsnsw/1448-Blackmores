using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using QSYSControlV4_2;

namespace UserModule_Q_SYS_CORE_V5_0_0
{
    public class UserModuleClass_Q_SYS_CORE_V5_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.AnalogInput DEBUG;
        Crestron.Logos.SplusObjects.AnalogInput POLL_RATE;
        Crestron.Logos.SplusObjects.StringInput HOST;
        Crestron.Logos.SplusObjects.StringInput CUSTOM_STRING;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput CONNECTED;
        Crestron.Logos.SplusObjects.DigitalOutput ISREDUNDANTCORE;
        Crestron.Logos.SplusObjects.DigitalOutput ISEMULATOR;
        Crestron.Logos.SplusObjects.AnalogOutput ERRORS_LOGGED;
        Crestron.Logos.SplusObjects.StringOutput PLATFORM;
        Crestron.Logos.SplusObjects.StringOutput STATE;
        Crestron.Logos.SplusObjects.StringOutput DESIGNNAME;
        UShortParameter CORE_ID;
        StringParameter LOGIN_USER;
        UShortParameter LOGIN_PIN;
        ushort GIID = 0;
        CrestronString GSHOST;
        QSYSControlV4_2.QSYSCore MYCORE;
        public void CBF_ERRORLOGGED ( ushort ERRCOUNT ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 63;
                ERRORS_LOGGED  .Value = (ushort) ( ERRCOUNT ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void CBF_INITIALIZED ( ushort INITVALUE ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 67;
                INITIALIZED  .Value = (ushort) ( INITVALUE ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void CORECHANGEEVENT ( object __sender__ /*QSYSControlV4_2.QSYSCore SENDER */, QSYSControlV4_2.QSYSCoreChangeArgs E ) 
            { 
            QSYSCore  SENDER  = (QSYSCore )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 73;
                CONNECTED  .Value = (ushort) ( E.Status ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void CORESTATUSCHANGEEVENT ( object __sender__ /*QSYSControlV4_2.QSYSCore SENDER */, QSYSControlV4_2.QSYSStatusChangeArgs E ) 
            { 
            QSYSCore  SENDER  = (QSYSCore )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 77;
                PLATFORM  .UpdateValue ( E . Platform  ) ; 
                __context__.SourceCodeLine = 78;
                STATE  .UpdateValue ( E . State  ) ; 
                __context__.SourceCodeLine = 79;
                DESIGNNAME  .UpdateValue ( E . DesignName  ) ; 
                __context__.SourceCodeLine = 80;
                ISREDUNDANTCORE  .Value = (ushort) ( E.IsRedundant ) ; 
                __context__.SourceCodeLine = 81;
                ISEMULATOR  .Value = (ushort) ( E.IsEmulator ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INITIALIZE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 87;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( GSHOST ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 89;
                    MYCORE . User  =  ( LOGIN_USER  )  .ToString() ; 
                    __context__.SourceCodeLine = 90;
                    MYCORE . Pin = (ushort) ( LOGIN_PIN  .Value ) ; 
                    __context__.SourceCodeLine = 92;
                    MYCORE . CoreID = (ushort) ( GIID ) ; 
                    __context__.SourceCodeLine = 93;
                    MYCORE . _CoreIPAddress  =  ( GSHOST  )  .ToString() ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DEBUG_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 101;
            MYCORE . CoreDebug = (ushort) ( DEBUG  .UshortValue ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object HOST_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 106;
        GSHOST  .UpdateValue ( HOST  ) ; 
        __context__.SourceCodeLine = 107;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 109;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( GSHOST ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 111;
                MYCORE . User  =  ( LOGIN_USER  )  .ToString() ; 
                __context__.SourceCodeLine = 112;
                MYCORE . Pin = (ushort) ( LOGIN_PIN  .Value ) ; 
                __context__.SourceCodeLine = 114;
                MYCORE . CoreID = (ushort) ( GIID ) ; 
                __context__.SourceCodeLine = 115;
                MYCORE . _CoreIPAddress  =  ( GSHOST  )  .ToString() ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_RATE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 122;
        MYCORE . _pollRate = (int) ( POLL_RATE  .IntValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CUSTOM_STRING_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 126;
        MYCORE . QSYSCustomString ( CUSTOM_STRING .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 139;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 140;
        GIID = (ushort) ( CORE_ID  .Value ) ; 
        __context__.SourceCodeLine = 141;
        GSHOST  .UpdateValue ( HOST  ) ; 
        __context__.SourceCodeLine = 142;
        MYCORE . User  =  ( LOGIN_USER  )  .ToString() ; 
        __context__.SourceCodeLine = 143;
        MYCORE . Pin = (ushort) ( LOGIN_PIN  .Value ) ; 
        __context__.SourceCodeLine = 147;
        // RegisterEvent( MYCORE , ONCORECHANGEEVENT , CORECHANGEEVENT ) 
        try { g_criticalSection.Enter(); MYCORE .onCoreChangeEvent  += CORECHANGEEVENT; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 148;
        // RegisterEvent( MYCORE , ONCORESTATUSCHANGEEVENT , CORESTATUSCHANGEEVENT ) 
        try { g_criticalSection.Enter(); MYCORE .onCoreStatusChangeEvent  += CORESTATUSCHANGEEVENT; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 149;
        // RegisterDelegate( MYCORE , DELCOREERRORS , CBF_ERRORLOGGED ) 
        MYCORE .delCoreErrors  = CBF_ERRORLOGGED; ; 
        __context__.SourceCodeLine = 150;
        // RegisterDelegate( MYCORE , DELINITIALIZED , CBF_INITIALIZED ) 
        MYCORE .delInitialized  = CBF_INITIALIZED; ; 
        __context__.SourceCodeLine = 152;
        Functions.Delay (  (int) ( 500 ) ) ; 
        __context__.SourceCodeLine = 154;
        if ( Functions.TestForTrue  ( ( INITIALIZE  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 157;
            MYCORE . CoreID = (ushort) ( GIID ) ; 
            __context__.SourceCodeLine = 158;
            MYCORE . _CoreIPAddress  =  ( GSHOST  )  .ToString() ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    GSHOST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZED__DigitalOutput__, INITIALIZED );
    
    CONNECTED = new Crestron.Logos.SplusObjects.DigitalOutput( CONNECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONNECTED__DigitalOutput__, CONNECTED );
    
    ISREDUNDANTCORE = new Crestron.Logos.SplusObjects.DigitalOutput( ISREDUNDANTCORE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ISREDUNDANTCORE__DigitalOutput__, ISREDUNDANTCORE );
    
    ISEMULATOR = new Crestron.Logos.SplusObjects.DigitalOutput( ISEMULATOR__DigitalOutput__, this );
    m_DigitalOutputList.Add( ISEMULATOR__DigitalOutput__, ISEMULATOR );
    
    DEBUG = new Crestron.Logos.SplusObjects.AnalogInput( DEBUG__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DEBUG__AnalogSerialInput__, DEBUG );
    
    POLL_RATE = new Crestron.Logos.SplusObjects.AnalogInput( POLL_RATE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( POLL_RATE__AnalogSerialInput__, POLL_RATE );
    
    ERRORS_LOGGED = new Crestron.Logos.SplusObjects.AnalogOutput( ERRORS_LOGGED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ERRORS_LOGGED__AnalogSerialOutput__, ERRORS_LOGGED );
    
    HOST = new Crestron.Logos.SplusObjects.StringInput( HOST__AnalogSerialInput__, 500, this );
    m_StringInputList.Add( HOST__AnalogSerialInput__, HOST );
    
    CUSTOM_STRING = new Crestron.Logos.SplusObjects.StringInput( CUSTOM_STRING__AnalogSerialInput__, 500, this );
    m_StringInputList.Add( CUSTOM_STRING__AnalogSerialInput__, CUSTOM_STRING );
    
    PLATFORM = new Crestron.Logos.SplusObjects.StringOutput( PLATFORM__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PLATFORM__AnalogSerialOutput__, PLATFORM );
    
    STATE = new Crestron.Logos.SplusObjects.StringOutput( STATE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( STATE__AnalogSerialOutput__, STATE );
    
    DESIGNNAME = new Crestron.Logos.SplusObjects.StringOutput( DESIGNNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DESIGNNAME__AnalogSerialOutput__, DESIGNNAME );
    
    CORE_ID = new UShortParameter( CORE_ID__Parameter__, this );
    m_ParameterList.Add( CORE_ID__Parameter__, CORE_ID );
    
    LOGIN_PIN = new UShortParameter( LOGIN_PIN__Parameter__, this );
    m_ParameterList.Add( LOGIN_PIN__Parameter__, LOGIN_PIN );
    
    LOGIN_USER = new StringParameter( LOGIN_USER__Parameter__, this );
    m_ParameterList.Add( LOGIN_USER__Parameter__, LOGIN_USER );
    
    
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_0, false ) );
    DEBUG.OnAnalogChange.Add( new InputChangeHandlerWrapper( DEBUG_OnChange_1, false ) );
    HOST.OnSerialChange.Add( new InputChangeHandlerWrapper( HOST_OnChange_2, false ) );
    POLL_RATE.OnAnalogChange.Add( new InputChangeHandlerWrapper( POLL_RATE_OnChange_3, false ) );
    CUSTOM_STRING.OnSerialChange.Add( new InputChangeHandlerWrapper( CUSTOM_STRING_OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYCORE  = new QSYSControlV4_2.QSYSCore();
    
    
}

public UserModuleClass_Q_SYS_CORE_V5_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INITIALIZE__DigitalInput__ = 0;
const uint DEBUG__AnalogSerialInput__ = 0;
const uint POLL_RATE__AnalogSerialInput__ = 1;
const uint HOST__AnalogSerialInput__ = 2;
const uint CUSTOM_STRING__AnalogSerialInput__ = 3;
const uint INITIALIZED__DigitalOutput__ = 0;
const uint CONNECTED__DigitalOutput__ = 1;
const uint ISREDUNDANTCORE__DigitalOutput__ = 2;
const uint ISEMULATOR__DigitalOutput__ = 3;
const uint ERRORS_LOGGED__AnalogSerialOutput__ = 0;
const uint PLATFORM__AnalogSerialOutput__ = 1;
const uint STATE__AnalogSerialOutput__ = 2;
const uint DESIGNNAME__AnalogSerialOutput__ = 3;
const uint CORE_ID__Parameter__ = 10;
const uint LOGIN_USER__Parameter__ = 11;
const uint LOGIN_PIN__Parameter__ = 12;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
