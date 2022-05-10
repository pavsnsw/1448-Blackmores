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

namespace UserModule_AV_SCHEDULE_V1_1
{
    public class UserModuleClass_AV_SCHEDULE_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SCHEDULE_ACTIVE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput SET_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput RESET_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput ON_ACTIVE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput SET_ON_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput RESET_ON_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput OFF_ACTIVE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput SET_OFF_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput RESET_OFF_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput ON_HOUR_UP;
        Crestron.Logos.SplusObjects.DigitalInput ON_HOUR_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput ON_MIN_UP;
        Crestron.Logos.SplusObjects.DigitalInput ON_MIN_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput OFF_HOUR_UP;
        Crestron.Logos.SplusObjects.DigitalInput OFF_HOUR_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput OFF_MIN_UP;
        Crestron.Logos.SplusObjects.DigitalInput OFF_MIN_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput TIME_CHECK;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> WEEK_DAY;
        Crestron.Logos.SplusObjects.AnalogInput WARNING_TIME;
        Crestron.Logos.SplusObjects.StringInput SYSTOD__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput FILENAME;
        Crestron.Logos.SplusObjects.DigitalOutput SCHEDULE_ACTIVE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ON_ACTIVE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput OFF_ACTIVE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ON_TRIGGER;
        Crestron.Logos.SplusObjects.DigitalOutput OFF_TRIGGER;
        Crestron.Logos.SplusObjects.DigitalOutput OFF_WARNING;
        Crestron.Logos.SplusObjects.DigitalOutput OFF_IS_TOMORROW;
        Crestron.Logos.SplusObjects.DigitalOutput FILE_SAVED;
        Crestron.Logos.SplusObjects.StringOutput ON_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput OFF_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TIME__DOLLAR__;
        EVENTSTORE [] S_EVENT;
        ushort SYSHOURS = 0;
        ushort SYSMINS = 0;
        ushort SYSSECS = 0;
        ushort IACTIVE = 0;
        ushort IDAY = 0;
        ushort IWARN = 0;
        ushort [] IHOUR;
        ushort [] IHOURTEMP;
        ushort [] IMINUTE;
        ushort [] IDAYS;
        ushort [] IACTON;
        CrestronString CURRENTIME;
        CrestronString [] EVENTTIME;
        CrestronString [] AMPM;
        CrestronString PATHFILENAME;
        private void F_READFILE (  SplusExecutionContext __context__ ) 
            { 
            short NFILEHANDLE = 0;
            
            short NTOTALBYTESREAD = 0;
            
            ushort ICOUNT = 0;
            
            FILE_INFO FILEINFO;
            FILEINFO  = new FILE_INFO();
            FILEINFO .PopulateDefaults();
            
            
            __context__.SourceCodeLine = 130;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)2; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( ICOUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ICOUNT  >= __FN_FORSTART_VAL__1) && (ICOUNT  <= __FN_FOREND_VAL__1) ) : ( (ICOUNT  <= __FN_FORSTART_VAL__1) && (ICOUNT  >= __FN_FOREND_VAL__1) ) ; ICOUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 132;
                S_EVENT [ ICOUNT] . S_HOUR = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 133;
                S_EVENT [ ICOUNT] . S_HOURTEMP = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 134;
                S_EVENT [ ICOUNT] . S_MINUTE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 135;
                S_EVENT [ ICOUNT] . S_SET = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 136;
                S_EVENT [ ICOUNT] . S_DAYS = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 137;
                S_EVENT [ ICOUNT] . S_TIME  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 138;
                S_EVENT [ ICOUNT] . S_AMPM  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 130;
                } 
            
            __context__.SourceCodeLine = 141;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 143;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FindFirst( FILENAME , ref FILEINFO ) != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 145;
                
                __context__.SourceCodeLine = 148;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)2; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( ICOUNT  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (ICOUNT  >= __FN_FORSTART_VAL__2) && (ICOUNT  <= __FN_FOREND_VAL__2) ) : ( (ICOUNT  <= __FN_FORSTART_VAL__2) && (ICOUNT  >= __FN_FOREND_VAL__2) ) ; ICOUNT  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 150;
                    IHOUR [ ICOUNT] = (ushort) ( 12 ) ; 
                    __context__.SourceCodeLine = 151;
                    IHOURTEMP [ ICOUNT] = (ushort) ( 12 ) ; 
                    __context__.SourceCodeLine = 152;
                    IMINUTE [ ICOUNT] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 153;
                    IDAYS [ ICOUNT] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 154;
                    EVENTTIME [ ICOUNT ]  .UpdateValue ( "12:00 PM"  ) ; 
                    __context__.SourceCodeLine = 155;
                    AMPM [ ICOUNT ]  .UpdateValue ( "PM"  ) ; 
                    __context__.SourceCodeLine = 156;
                    IACTON [ ICOUNT] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 148;
                    } 
                
                __context__.SourceCodeLine = 158;
                FindClose ( ) ; 
                __context__.SourceCodeLine = 159;
                EndFileOperations ( ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 163;
                
                __context__.SourceCodeLine = 166;
                
                __context__.SourceCodeLine = 169;
                __context__.SourceCodeLine = 170;
                NFILEHANDLE = (short) ( FileOpen( FILENAME ,(ushort) (0 | 32768) ) ) ; 
                
                __context__.SourceCodeLine = 172;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 174;
                    ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__3 = (ushort)2; 
                    int __FN_FORSTEP_VAL__3 = (int)1; 
                    for ( ICOUNT  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (ICOUNT  >= __FN_FORSTART_VAL__3) && (ICOUNT  <= __FN_FOREND_VAL__3) ) : ( (ICOUNT  <= __FN_FORSTART_VAL__3) && (ICOUNT  >= __FN_FOREND_VAL__3) ) ; ICOUNT  += (ushort)__FN_FORSTEP_VAL__3) 
                        { 
                        __context__.SourceCodeLine = 176;
                        ReadStructure (  (short) ( NFILEHANDLE ) , S_EVENT [ ICOUNT] ,  ref NTOTALBYTESREAD ) ; 
                        __context__.SourceCodeLine = 177;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NTOTALBYTESREAD < 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 179;
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 185;
                            IHOUR [ ICOUNT] = (ushort) ( S_EVENT[ ICOUNT ].S_HOUR ) ; 
                            __context__.SourceCodeLine = 186;
                            IHOURTEMP [ ICOUNT] = (ushort) ( S_EVENT[ ICOUNT ].S_HOURTEMP ) ; 
                            __context__.SourceCodeLine = 187;
                            IMINUTE [ ICOUNT] = (ushort) ( S_EVENT[ ICOUNT ].S_MINUTE ) ; 
                            __context__.SourceCodeLine = 188;
                            IDAYS [ ICOUNT] = (ushort) ( S_EVENT[ ICOUNT ].S_DAYS ) ; 
                            __context__.SourceCodeLine = 189;
                            EVENTTIME [ ICOUNT ]  .UpdateValue ( S_EVENT [ ICOUNT] . S_TIME  ) ; 
                            __context__.SourceCodeLine = 190;
                            AMPM [ ICOUNT ]  .UpdateValue ( S_EVENT [ ICOUNT] . S_AMPM  ) ; 
                            __context__.SourceCodeLine = 191;
                            IACTON [ ICOUNT] = (ushort) ( S_EVENT[ ICOUNT ].S_SET ) ; 
                            __context__.SourceCodeLine = 192;
                            
                            } 
                        
                        __context__.SourceCodeLine = 174;
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 199;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 202;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IACTON[ 1 ] == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (IACTON[ 2 ] == 1) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 203;
                SCHEDULE_ACTIVE_FB  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 205;
                SCHEDULE_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 207;
            ON_ACTIVE_FB  .Value = (ushort) ( IACTON[ 1 ] ) ; 
            __context__.SourceCodeLine = 208;
            OFF_ACTIVE_FB  .Value = (ushort) ( IACTON[ 2 ] ) ; 
            __context__.SourceCodeLine = 209;
            ON_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 1 ]  ) ; 
            __context__.SourceCodeLine = 210;
            OFF_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 2 ]  ) ; 
            
            }
            
        private void F_UPDATEFILE (  SplusExecutionContext __context__, ushort ISEL ) 
            { 
            short NFILEHANDLE = 0;
            
            short NTOTALBYTESWRITTEN = 0;
            
            ushort ICOUNT = 0;
            
            
            __context__.SourceCodeLine = 225;
            FILE_SAVED  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 227;
            S_EVENT [ ISEL] . S_HOUR = (ushort) ( IHOUR[ ISEL ] ) ; 
            __context__.SourceCodeLine = 228;
            S_EVENT [ ISEL] . S_HOURTEMP = (ushort) ( IHOURTEMP[ ISEL ] ) ; 
            __context__.SourceCodeLine = 229;
            S_EVENT [ ISEL] . S_MINUTE = (ushort) ( IMINUTE[ ISEL ] ) ; 
            __context__.SourceCodeLine = 230;
            S_EVENT [ ISEL] . S_DAYS = (ushort) ( IDAYS[ ISEL ] ) ; 
            __context__.SourceCodeLine = 231;
            S_EVENT [ ISEL] . S_TIME  .UpdateValue ( EVENTTIME [ ISEL ]  ) ; 
            __context__.SourceCodeLine = 232;
            S_EVENT [ ISEL] . S_AMPM  .UpdateValue ( AMPM [ ISEL ]  ) ; 
            __context__.SourceCodeLine = 233;
            S_EVENT [ ISEL] . S_SET = (ushort) ( IACTON[ ISEL ] ) ; 
            __context__.SourceCodeLine = 235;
            
            __context__.SourceCodeLine = 239;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)2; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( ICOUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ICOUNT  >= __FN_FORSTART_VAL__1) && (ICOUNT  <= __FN_FOREND_VAL__1) ) : ( (ICOUNT  <= __FN_FORSTART_VAL__1) && (ICOUNT  >= __FN_FOREND_VAL__1) ) ; ICOUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 241;
                StartFileOperations ( ) ; 
                __context__.SourceCodeLine = 242;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CheckForNVRAMDisk() == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 244;
                    
                    __context__.SourceCodeLine = 247;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOUNT == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 249;
                        
                        __context__.SourceCodeLine = 252;
                        
                        __context__.SourceCodeLine = 255;
                        __context__.SourceCodeLine = 256;
                        NFILEHANDLE = (short) ( FileOpen( FILENAME ,(ushort) (((1 | 256) | 512) | 32768) ) ) ; 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 261;
                        
                        __context__.SourceCodeLine = 264;
                        
                        __context__.SourceCodeLine = 267;
                        __context__.SourceCodeLine = 268;
                        NFILEHANDLE = (short) ( FileOpen( FILENAME ,(ushort) ((1 | 8) | 32768) ) ) ; 
                        
                        } 
                    
                    __context__.SourceCodeLine = 271;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 273;
                        WriteStructure (  (short) ( NFILEHANDLE ) , S_EVENT [ ICOUNT] ,  ref NTOTALBYTESWRITTEN ) ; 
                        __context__.SourceCodeLine = 275;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NTOTALBYTESWRITTEN < 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 277;
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 283;
                            
                            __context__.SourceCodeLine = 286;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 288;
                                
                                } 
                            
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 296;
                        
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 303;
                    Print( "Error NVRAM Disk Not Found\r\nPlease initialize NVRAM from console.\r\nExample: PRO2> NVRAMDISK 128K\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 305;
                EndFileOperations ( ) ; 
                __context__.SourceCodeLine = 239;
                } 
            
            __context__.SourceCodeLine = 307;
            FILE_SAVED  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void FN_TIMECHECK (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 312;
            SYSHOURS = (ushort) ( Functions.GetHourNum() ) ; 
            __context__.SourceCodeLine = 313;
            SYSMINS = (ushort) ( Functions.GetMinutesNum() ) ; 
            __context__.SourceCodeLine = 314;
            SYSSECS = (ushort) ( Functions.GetSecondsNum() ) ; 
            __context__.SourceCodeLine = 315;
            AMPM [ 0 ]  .UpdateValue ( "AM"  ) ; 
            __context__.SourceCodeLine = 316;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SYSHOURS > 12 ))  ) ) 
                { 
                __context__.SourceCodeLine = 318;
                SYSHOURS = (ushort) ( (SYSHOURS - 12) ) ; 
                __context__.SourceCodeLine = 319;
                AMPM [ 0 ]  .UpdateValue ( "PM"  ) ; 
                } 
            
            __context__.SourceCodeLine = 321;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSHOURS == 12))  ) ) 
                {
                __context__.SourceCodeLine = 322;
                AMPM [ 0 ]  .UpdateValue ( "PM"  ) ; 
                }
            
            __context__.SourceCodeLine = 324;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSHOURS == 0))  ) ) 
                {
                __context__.SourceCodeLine = 325;
                SYSHOURS = (ushort) ( 12 ) ; 
                }
            
            __context__.SourceCodeLine = 327;
            MakeString ( CURRENTIME , "{0:d}:{1:d2} {2}", (short)SYSHOURS, (short)SYSMINS, AMPM [ 0 ] ) ; 
            __context__.SourceCodeLine = 328;
            CURRENT_TIME__DOLLAR__  .UpdateValue ( CURRENTIME  ) ; 
            __context__.SourceCodeLine = 330;
            IDAY = (ushort) ( Functions.GetDayOfWeekNum() ) ; 
            __context__.SourceCodeLine = 331;
            IDAY = (ushort) ( (IDAY + 1) ) ; 
            __context__.SourceCodeLine = 333;
            
            __context__.SourceCodeLine = 338;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CURRENTIME == EVENTTIME[ 1 ]) ) && Functions.TestForTrue ( Functions.BoolToInt (IDAYS[ 1 ] == IDAY) )) ) ) && Functions.TestForTrue ( ON_ACTIVE_FB  .Value )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 340;
                Functions.Pulse ( 500, ON_TRIGGER ) ; 
                } 
            
            __context__.SourceCodeLine = 344;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( (Functions.BoolToInt (CURRENTIME == EVENTTIME[ 2 ]) - IWARN) ) && Functions.TestForTrue ( Functions.BoolToInt (IDAYS[ 2 ] == IDAY) )) ) ) && Functions.TestForTrue ( OFF_ACTIVE_FB  .Value )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 346;
                Functions.Pulse ( 500, OFF_WARNING ) ; 
                } 
            
            __context__.SourceCodeLine = 350;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CURRENTIME == EVENTTIME[ 2 ]) ) && Functions.TestForTrue ( Functions.BoolToInt (IDAYS[ 2 ] == IDAY) )) ) ) && Functions.TestForTrue ( OFF_ACTIVE_FB  .Value )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 352;
                Functions.Pulse ( 500, OFF_TRIGGER ) ; 
                } 
            
            
            }
            
        object ON_HOUR_UP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 363;
                IHOURTEMP [ 1] = (ushort) ( (IHOURTEMP[ 1 ] + 1) ) ; 
                __context__.SourceCodeLine = 364;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOURTEMP[ 1 ] >= 24 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 365;
                    IHOURTEMP [ 1] = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 367;
                AMPM [ 1 ]  .UpdateValue ( "AM"  ) ; 
                __context__.SourceCodeLine = 368;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOURTEMP[ 1 ] > 12 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 370;
                    IHOUR [ 1] = (ushort) ( (IHOURTEMP[ 1 ] - 12) ) ; 
                    __context__.SourceCodeLine = 371;
                    AMPM [ 1 ]  .UpdateValue ( "PM"  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 374;
                    IHOUR [ 1] = (ushort) ( IHOURTEMP[ 1 ] ) ; 
                    }
                
                __context__.SourceCodeLine = 376;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 1 ] == 12))  ) ) 
                    {
                    __context__.SourceCodeLine = 377;
                    AMPM [ 1 ]  .UpdateValue ( "PM"  ) ; 
                    }
                
                __context__.SourceCodeLine = 379;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 1 ] == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 380;
                    IHOUR [ 1] = (ushort) ( 12 ) ; 
                    }
                
                __context__.SourceCodeLine = 382;
                MakeString ( EVENTTIME [ 1 ] , "{0:d}:{1:d2} {2}", (short)IHOUR[ 1 ], (short)IMINUTE[ 1 ], AMPM [ 1 ] ) ; 
                __context__.SourceCodeLine = 383;
                ON_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 1 ]  ) ; 
                __context__.SourceCodeLine = 384;
                F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ON_HOUR_DOWN_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 389;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 1 ] == 0))  ) ) 
                {
                __context__.SourceCodeLine = 390;
                IHOURTEMP [ 1] = (ushort) ( 24 ) ; 
                }
            
            __context__.SourceCodeLine = 392;
            IHOURTEMP [ 1] = (ushort) ( (IHOURTEMP[ 1 ] - 1) ) ; 
            __context__.SourceCodeLine = 393;
            AMPM [ 1 ]  .UpdateValue ( "AM"  ) ; 
            __context__.SourceCodeLine = 395;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOURTEMP[ 1 ] > 12 ))  ) ) 
                { 
                __context__.SourceCodeLine = 397;
                IHOUR [ 1] = (ushort) ( (IHOURTEMP[ 1 ] - 12) ) ; 
                __context__.SourceCodeLine = 398;
                AMPM [ 1 ]  .UpdateValue ( "PM"  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 401;
                IHOUR [ 1] = (ushort) ( IHOURTEMP[ 1 ] ) ; 
                }
            
            __context__.SourceCodeLine = 403;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 1 ] == 12))  ) ) 
                {
                __context__.SourceCodeLine = 404;
                AMPM [ 1 ]  .UpdateValue ( "PM"  ) ; 
                }
            
            __context__.SourceCodeLine = 406;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 1 ] == 0))  ) ) 
                {
                __context__.SourceCodeLine = 407;
                IHOUR [ 1] = (ushort) ( 12 ) ; 
                }
            
            __context__.SourceCodeLine = 409;
            MakeString ( EVENTTIME [ 1 ] , "{0:d}:{1:d2} {2}", (short)IHOUR[ 1 ], (short)IMINUTE[ 1 ], AMPM [ 1 ] ) ; 
            __context__.SourceCodeLine = 410;
            ON_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 1 ]  ) ; 
            __context__.SourceCodeLine = 411;
            F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ON_MIN_UP_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 416;
        IMINUTE [ 1] = (ushort) ( (IMINUTE[ 1 ] + 15) ) ; 
        __context__.SourceCodeLine = 417;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMINUTE[ 1 ] == 60))  ) ) 
            {
            __context__.SourceCodeLine = 418;
            IMINUTE [ 1] = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 420;
        MakeString ( EVENTTIME [ 1 ] , "{0:d}:{1:d2} {2}", (short)IHOUR[ 1 ], (short)IMINUTE[ 1 ], AMPM [ 1 ] ) ; 
        __context__.SourceCodeLine = 421;
        ON_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 1 ]  ) ; 
        __context__.SourceCodeLine = 422;
        F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ON_MIN_DOWN_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 427;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMINUTE[ 1 ] == 0))  ) ) 
            {
            __context__.SourceCodeLine = 428;
            IMINUTE [ 1] = (ushort) ( 60 ) ; 
            }
        
        __context__.SourceCodeLine = 430;
        IMINUTE [ 1] = (ushort) ( (IMINUTE[ 1 ] - 15) ) ; 
        __context__.SourceCodeLine = 431;
        MakeString ( EVENTTIME [ 1 ] , "{0:d}:{1:d2} {2}", (short)IHOUR[ 1 ], (short)IMINUTE[ 1 ], AMPM [ 1 ] ) ; 
        __context__.SourceCodeLine = 432;
        ON_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 1 ]  ) ; 
        __context__.SourceCodeLine = 433;
        F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OFF_HOUR_UP_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 440;
        IHOURTEMP [ 2] = (ushort) ( (IHOURTEMP[ 2 ] + 1) ) ; 
        __context__.SourceCodeLine = 441;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOURTEMP[ 2 ] >= 24 ))  ) ) 
            {
            __context__.SourceCodeLine = 442;
            IHOURTEMP [ 2] = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 444;
        AMPM [ 2 ]  .UpdateValue ( "AM"  ) ; 
        __context__.SourceCodeLine = 445;
        OFF_IS_TOMORROW  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 447;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOURTEMP[ 2 ] > 12 ))  ) ) 
            { 
            __context__.SourceCodeLine = 449;
            IHOUR [ 2] = (ushort) ( (IHOURTEMP[ 2 ] - 12) ) ; 
            __context__.SourceCodeLine = 450;
            AMPM [ 2 ]  .UpdateValue ( "PM"  ) ; 
            __context__.SourceCodeLine = 451;
            OFF_IS_TOMORROW  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 454;
            IHOUR [ 2] = (ushort) ( IHOURTEMP[ 2 ] ) ; 
            }
        
        __context__.SourceCodeLine = 456;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 2 ] == 12))  ) ) 
            { 
            __context__.SourceCodeLine = 458;
            AMPM [ 2 ]  .UpdateValue ( "PM"  ) ; 
            __context__.SourceCodeLine = 459;
            OFF_IS_TOMORROW  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 462;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 2 ] == 0))  ) ) 
            {
            __context__.SourceCodeLine = 463;
            IHOUR [ 2] = (ushort) ( 12 ) ; 
            }
        
        __context__.SourceCodeLine = 465;
        MakeString ( EVENTTIME [ 2 ] , "{0:d}:{1:d2} {2}", (short)IHOUR[ 2 ], (short)IMINUTE[ 2 ], AMPM [ 2 ] ) ; 
        __context__.SourceCodeLine = 466;
        OFF_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 2 ]  ) ; 
        __context__.SourceCodeLine = 470;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AMPM[ 2 ] == "AM"))  ) ) 
            { 
            __context__.SourceCodeLine = 472;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYS[ 1 ] == 7))  ) ) 
                {
                __context__.SourceCodeLine = 473;
                IDAYS [ 2] = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 475;
                IDAYS [ 2] = (ushort) ( (IDAYS[ 1 ] + 1) ) ; 
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 479;
            IDAYS [ 2] = (ushort) ( IDAYS[ 1 ] ) ; 
            } 
        
        __context__.SourceCodeLine = 482;
        F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OFF_HOUR_DOWN_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 487;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 2 ] == 0))  ) ) 
            {
            __context__.SourceCodeLine = 488;
            IHOURTEMP [ 2] = (ushort) ( 24 ) ; 
            }
        
        __context__.SourceCodeLine = 490;
        IHOURTEMP [ 2] = (ushort) ( (IHOURTEMP[ 2 ] - 1) ) ; 
        __context__.SourceCodeLine = 492;
        AMPM [ 2 ]  .UpdateValue ( "AM"  ) ; 
        __context__.SourceCodeLine = 493;
        OFF_IS_TOMORROW  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 495;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOURTEMP[ 2 ] > 12 ))  ) ) 
            { 
            __context__.SourceCodeLine = 497;
            IHOUR [ 2] = (ushort) ( (IHOURTEMP[ 2 ] - 12) ) ; 
            __context__.SourceCodeLine = 498;
            AMPM [ 2 ]  .UpdateValue ( "PM"  ) ; 
            __context__.SourceCodeLine = 499;
            OFF_IS_TOMORROW  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 502;
            IHOUR [ 2] = (ushort) ( IHOURTEMP[ 2 ] ) ; 
            }
        
        __context__.SourceCodeLine = 504;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 2 ] == 12))  ) ) 
            { 
            __context__.SourceCodeLine = 506;
            AMPM [ 2 ]  .UpdateValue ( "PM"  ) ; 
            __context__.SourceCodeLine = 507;
            OFF_IS_TOMORROW  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 510;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURTEMP[ 2 ] == 0))  ) ) 
            {
            __context__.SourceCodeLine = 511;
            IHOUR [ 2] = (ushort) ( 12 ) ; 
            }
        
        __context__.SourceCodeLine = 513;
        MakeString ( EVENTTIME [ 2 ] , "{0:d}:{1:d2} {2}", (short)IHOUR[ 2 ], (short)IMINUTE[ 2 ], AMPM [ 2 ] ) ; 
        __context__.SourceCodeLine = 514;
        OFF_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 2 ]  ) ; 
        __context__.SourceCodeLine = 517;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AMPM[ 2 ] == "AM"))  ) ) 
            { 
            __context__.SourceCodeLine = 519;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYS[ 1 ] == 7))  ) ) 
                {
                __context__.SourceCodeLine = 520;
                IDAYS [ 2] = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 522;
                IDAYS [ 2] = (ushort) ( (IDAYS[ 1 ] + 1) ) ; 
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 526;
            IDAYS [ 2] = (ushort) ( IDAYS[ 1 ] ) ; 
            } 
        
        __context__.SourceCodeLine = 529;
        F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OFF_MIN_UP_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 534;
        IMINUTE [ 2] = (ushort) ( (IMINUTE[ 2 ] + 15) ) ; 
        __context__.SourceCodeLine = 535;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMINUTE[ 2 ] == 60))  ) ) 
            {
            __context__.SourceCodeLine = 536;
            IMINUTE [ 2] = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 538;
        MakeString ( EVENTTIME [ 2 ] , "{0:d}:{1:d2} {2}", (short)IHOUR[ 2 ], (short)IMINUTE[ 2 ], AMPM [ 2 ] ) ; 
        __context__.SourceCodeLine = 539;
        OFF_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 2 ]  ) ; 
        __context__.SourceCodeLine = 540;
        F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OFF_MIN_DOWN_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 545;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMINUTE[ 2 ] == 0))  ) ) 
            {
            __context__.SourceCodeLine = 546;
            IMINUTE [ 2] = (ushort) ( 60 ) ; 
            }
        
        __context__.SourceCodeLine = 548;
        IMINUTE [ 2] = (ushort) ( (IMINUTE[ 2 ] - 15) ) ; 
        __context__.SourceCodeLine = 549;
        MakeString ( EVENTTIME [ 2 ] , "{0:d}:{1:d2} {2}", (short)IHOUR[ 2 ], (short)IMINUTE[ 2 ], AMPM [ 2 ] ) ; 
        __context__.SourceCodeLine = 550;
        OFF_TIME__DOLLAR__  .UpdateValue ( EVENTTIME [ 2 ]  ) ; 
        __context__.SourceCodeLine = 551;
        F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEK_DAY_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IDX = 0;
        
        
        __context__.SourceCodeLine = 559;
        IDX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 560;
        IDAYS [ 1] = (ushort) ( IDX ) ; 
        __context__.SourceCodeLine = 562;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AMPM[ 2 ] == "AM"))  ) ) 
            { 
            __context__.SourceCodeLine = 564;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDX == 7))  ) ) 
                {
                __context__.SourceCodeLine = 565;
                IDAYS [ 2] = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 567;
                IDAYS [ 2] = (ushort) ( (IDX + 1) ) ; 
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 571;
            IDAYS [ 2] = (ushort) ( IDX ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TIME_CHECK_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 584;
        FN_TIMECHECK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WARNING_TIME_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 589;
        IWARN = (ushort) ( WARNING_TIME  .UshortValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_ACTIVE_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 595;
        IACTON [ 1] = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 596;
        IACTON [ 2] = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 597;
        SCHEDULE_ACTIVE_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 598;
        ON_ACTIVE_FB  .Value = (ushort) ( IACTON[ 1 ] ) ; 
        __context__.SourceCodeLine = 599;
        OFF_ACTIVE_FB  .Value = (ushort) ( IACTON[ 2 ] ) ; 
        __context__.SourceCodeLine = 600;
        F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
        __context__.SourceCodeLine = 601;
        F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESET_ACTIVE_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 606;
        IACTON [ 1] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 607;
        IACTON [ 2] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 608;
        SCHEDULE_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 609;
        ON_ACTIVE_FB  .Value = (ushort) ( IACTON[ 1 ] ) ; 
        __context__.SourceCodeLine = 610;
        OFF_ACTIVE_FB  .Value = (ushort) ( IACTON[ 2 ] ) ; 
        __context__.SourceCodeLine = 611;
        F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
        __context__.SourceCodeLine = 612;
        F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_ON_ACTIVE_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 617;
        IACTON [ 1] = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 618;
        ON_ACTIVE_FB  .Value = (ushort) ( IACTON[ 1 ] ) ; 
        __context__.SourceCodeLine = 619;
        F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESET_ON_ACTIVE_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 624;
        IACTON [ 1] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 625;
        ON_ACTIVE_FB  .Value = (ushort) ( IACTON[ 1 ] ) ; 
        __context__.SourceCodeLine = 626;
        F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_OFF_ACTIVE_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 631;
        IACTON [ 2] = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 632;
        OFF_ACTIVE_FB  .Value = (ushort) ( IACTON[ 2 ] ) ; 
        __context__.SourceCodeLine = 633;
        F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESET_OFF_ACTIVE_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 638;
        IACTON [ 2] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 639;
        OFF_ACTIVE_FB  .Value = (ushort) ( IACTON[ 2 ] ) ; 
        __context__.SourceCodeLine = 640;
        F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ON_ACTIVE_TOGGLE_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 645;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IACTON[ 1 ] == 1))  ) ) 
            {
            __context__.SourceCodeLine = 646;
            IACTON [ 1] = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 648;
            IACTON [ 1] = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 650;
        ON_ACTIVE_FB  .Value = (ushort) ( IACTON[ 1 ] ) ; 
        __context__.SourceCodeLine = 652;
        F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OFF_ACTIVE_TOGGLE_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 657;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IACTON[ 2 ] == 1))  ) ) 
            {
            __context__.SourceCodeLine = 658;
            IACTON [ 2] = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 660;
            IACTON [ 2] = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 662;
        OFF_ACTIVE_FB  .Value = (ushort) ( IACTON[ 2 ] ) ; 
        __context__.SourceCodeLine = 664;
        F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCHEDULE_ACTIVE_TOGGLE_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 669;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IACTON[ 1 ] == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 671;
            IACTON [ 1] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 672;
            IACTON [ 2] = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 676;
            IACTON [ 1] = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 677;
            IACTON [ 2] = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 680;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IACTON[ 1 ] == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (IACTON[ 2 ] == 1) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 681;
            SCHEDULE_ACTIVE_FB  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 683;
            SCHEDULE_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 685;
        ON_ACTIVE_FB  .Value = (ushort) ( IACTON[ 1 ] ) ; 
        __context__.SourceCodeLine = 686;
        OFF_ACTIVE_FB  .Value = (ushort) ( IACTON[ 2 ] ) ; 
        __context__.SourceCodeLine = 688;
        F_UPDATEFILE (  __context__ , (ushort)( 1 )) ; 
        __context__.SourceCodeLine = 689;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_1__" , 50 , __SPLS_TMPVAR__WAITLABEL_1___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_1___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 691;
            F_UPDATEFILE (  __context__ , (ushort)( 2 )) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SYSTOD__DOLLAR___OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 697;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.GetSecondsNum() == 0))  ) ) 
            {
            __context__.SourceCodeLine = 698;
            FN_TIMECHECK (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort ICOUNT = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 712;
        IWARN = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 713;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 714;
        F_READFILE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    IHOUR  = new ushort[ 9 ];
    IHOURTEMP  = new ushort[ 9 ];
    IMINUTE  = new ushort[ 9 ];
    IDAYS  = new ushort[ 9 ];
    IACTON  = new ushort[ 9 ];
    CURRENTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    PATHFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    EVENTTIME  = new CrestronString[ 3 ];
    for( uint i = 0; i < 3; i++ )
        EVENTTIME [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    AMPM  = new CrestronString[ 9 ];
    for( uint i = 0; i < 9; i++ )
        AMPM [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    S_EVENT  = new EVENTSTORE[ 3 ];
    for( uint i = 0; i < 3; i++ )
    {
        S_EVENT [i] = new EVENTSTORE( this, true );
        S_EVENT [i].PopulateCustomAttributeList( false );
        
    }
    
    SCHEDULE_ACTIVE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( SCHEDULE_ACTIVE_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( SCHEDULE_ACTIVE_TOGGLE__DigitalInput__, SCHEDULE_ACTIVE_TOGGLE );
    
    SET_ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( SET_ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( SET_ACTIVE__DigitalInput__, SET_ACTIVE );
    
    RESET_ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( RESET_ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( RESET_ACTIVE__DigitalInput__, RESET_ACTIVE );
    
    ON_ACTIVE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( ON_ACTIVE_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( ON_ACTIVE_TOGGLE__DigitalInput__, ON_ACTIVE_TOGGLE );
    
    SET_ON_ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( SET_ON_ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( SET_ON_ACTIVE__DigitalInput__, SET_ON_ACTIVE );
    
    RESET_ON_ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( RESET_ON_ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( RESET_ON_ACTIVE__DigitalInput__, RESET_ON_ACTIVE );
    
    OFF_ACTIVE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( OFF_ACTIVE_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( OFF_ACTIVE_TOGGLE__DigitalInput__, OFF_ACTIVE_TOGGLE );
    
    SET_OFF_ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( SET_OFF_ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( SET_OFF_ACTIVE__DigitalInput__, SET_OFF_ACTIVE );
    
    RESET_OFF_ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( RESET_OFF_ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( RESET_OFF_ACTIVE__DigitalInput__, RESET_OFF_ACTIVE );
    
    ON_HOUR_UP = new Crestron.Logos.SplusObjects.DigitalInput( ON_HOUR_UP__DigitalInput__, this );
    m_DigitalInputList.Add( ON_HOUR_UP__DigitalInput__, ON_HOUR_UP );
    
    ON_HOUR_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( ON_HOUR_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( ON_HOUR_DOWN__DigitalInput__, ON_HOUR_DOWN );
    
    ON_MIN_UP = new Crestron.Logos.SplusObjects.DigitalInput( ON_MIN_UP__DigitalInput__, this );
    m_DigitalInputList.Add( ON_MIN_UP__DigitalInput__, ON_MIN_UP );
    
    ON_MIN_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( ON_MIN_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( ON_MIN_DOWN__DigitalInput__, ON_MIN_DOWN );
    
    OFF_HOUR_UP = new Crestron.Logos.SplusObjects.DigitalInput( OFF_HOUR_UP__DigitalInput__, this );
    m_DigitalInputList.Add( OFF_HOUR_UP__DigitalInput__, OFF_HOUR_UP );
    
    OFF_HOUR_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( OFF_HOUR_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( OFF_HOUR_DOWN__DigitalInput__, OFF_HOUR_DOWN );
    
    OFF_MIN_UP = new Crestron.Logos.SplusObjects.DigitalInput( OFF_MIN_UP__DigitalInput__, this );
    m_DigitalInputList.Add( OFF_MIN_UP__DigitalInput__, OFF_MIN_UP );
    
    OFF_MIN_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( OFF_MIN_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( OFF_MIN_DOWN__DigitalInput__, OFF_MIN_DOWN );
    
    TIME_CHECK = new Crestron.Logos.SplusObjects.DigitalInput( TIME_CHECK__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_CHECK__DigitalInput__, TIME_CHECK );
    
    WEEK_DAY = new InOutArray<DigitalInput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        WEEK_DAY[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( WEEK_DAY__DigitalInput__ + i, WEEK_DAY__DigitalInput__, this );
        m_DigitalInputList.Add( WEEK_DAY__DigitalInput__ + i, WEEK_DAY[i+1] );
    }
    
    SCHEDULE_ACTIVE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCHEDULE_ACTIVE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCHEDULE_ACTIVE_FB__DigitalOutput__, SCHEDULE_ACTIVE_FB );
    
    ON_ACTIVE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ON_ACTIVE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ON_ACTIVE_FB__DigitalOutput__, ON_ACTIVE_FB );
    
    OFF_ACTIVE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( OFF_ACTIVE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( OFF_ACTIVE_FB__DigitalOutput__, OFF_ACTIVE_FB );
    
    ON_TRIGGER = new Crestron.Logos.SplusObjects.DigitalOutput( ON_TRIGGER__DigitalOutput__, this );
    m_DigitalOutputList.Add( ON_TRIGGER__DigitalOutput__, ON_TRIGGER );
    
    OFF_TRIGGER = new Crestron.Logos.SplusObjects.DigitalOutput( OFF_TRIGGER__DigitalOutput__, this );
    m_DigitalOutputList.Add( OFF_TRIGGER__DigitalOutput__, OFF_TRIGGER );
    
    OFF_WARNING = new Crestron.Logos.SplusObjects.DigitalOutput( OFF_WARNING__DigitalOutput__, this );
    m_DigitalOutputList.Add( OFF_WARNING__DigitalOutput__, OFF_WARNING );
    
    OFF_IS_TOMORROW = new Crestron.Logos.SplusObjects.DigitalOutput( OFF_IS_TOMORROW__DigitalOutput__, this );
    m_DigitalOutputList.Add( OFF_IS_TOMORROW__DigitalOutput__, OFF_IS_TOMORROW );
    
    FILE_SAVED = new Crestron.Logos.SplusObjects.DigitalOutput( FILE_SAVED__DigitalOutput__, this );
    m_DigitalOutputList.Add( FILE_SAVED__DigitalOutput__, FILE_SAVED );
    
    WARNING_TIME = new Crestron.Logos.SplusObjects.AnalogInput( WARNING_TIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( WARNING_TIME__AnalogSerialInput__, WARNING_TIME );
    
    SYSTOD__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SYSTOD__DOLLAR____AnalogSerialInput__, 30, this );
    m_StringInputList.Add( SYSTOD__DOLLAR____AnalogSerialInput__, SYSTOD__DOLLAR__ );
    
    FILENAME = new Crestron.Logos.SplusObjects.StringInput( FILENAME__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( FILENAME__AnalogSerialInput__, FILENAME );
    
    ON_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ON_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ON_TIME__DOLLAR____AnalogSerialOutput__, ON_TIME__DOLLAR__ );
    
    OFF_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OFF_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( OFF_TIME__DOLLAR____AnalogSerialOutput__, OFF_TIME__DOLLAR__ );
    
    CURRENT_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_TIME__DOLLAR____AnalogSerialOutput__, CURRENT_TIME__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_1___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_1___CallbackFn );
    
    ON_HOUR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( ON_HOUR_UP_OnPush_0, false ) );
    ON_HOUR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( ON_HOUR_DOWN_OnPush_1, false ) );
    ON_MIN_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( ON_MIN_UP_OnPush_2, false ) );
    ON_MIN_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( ON_MIN_DOWN_OnPush_3, false ) );
    OFF_HOUR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( OFF_HOUR_UP_OnPush_4, false ) );
    OFF_HOUR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( OFF_HOUR_DOWN_OnPush_5, false ) );
    OFF_MIN_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( OFF_MIN_UP_OnPush_6, false ) );
    OFF_MIN_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( OFF_MIN_DOWN_OnPush_7, false ) );
    for( uint i = 0; i < 7; i++ )
        WEEK_DAY[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEK_DAY_OnPush_8, false ) );
        
    TIME_CHECK.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIME_CHECK_OnPush_9, false ) );
    WARNING_TIME.OnAnalogChange.Add( new InputChangeHandlerWrapper( WARNING_TIME_OnChange_10, false ) );
    SET_ACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_ACTIVE_OnPush_11, false ) );
    RESET_ACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESET_ACTIVE_OnPush_12, false ) );
    SET_ON_ACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_ON_ACTIVE_OnPush_13, false ) );
    RESET_ON_ACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESET_ON_ACTIVE_OnPush_14, false ) );
    SET_OFF_ACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_OFF_ACTIVE_OnPush_15, false ) );
    RESET_OFF_ACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESET_OFF_ACTIVE_OnPush_16, false ) );
    ON_ACTIVE_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ON_ACTIVE_TOGGLE_OnPush_17, false ) );
    OFF_ACTIVE_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( OFF_ACTIVE_TOGGLE_OnPush_18, false ) );
    SCHEDULE_ACTIVE_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCHEDULE_ACTIVE_TOGGLE_OnPush_19, false ) );
    SYSTOD__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SYSTOD__DOLLAR___OnChange_20, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_AV_SCHEDULE_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_1___Callback;


const uint SCHEDULE_ACTIVE_TOGGLE__DigitalInput__ = 0;
const uint SET_ACTIVE__DigitalInput__ = 1;
const uint RESET_ACTIVE__DigitalInput__ = 2;
const uint ON_ACTIVE_TOGGLE__DigitalInput__ = 3;
const uint SET_ON_ACTIVE__DigitalInput__ = 4;
const uint RESET_ON_ACTIVE__DigitalInput__ = 5;
const uint OFF_ACTIVE_TOGGLE__DigitalInput__ = 6;
const uint SET_OFF_ACTIVE__DigitalInput__ = 7;
const uint RESET_OFF_ACTIVE__DigitalInput__ = 8;
const uint ON_HOUR_UP__DigitalInput__ = 9;
const uint ON_HOUR_DOWN__DigitalInput__ = 10;
const uint ON_MIN_UP__DigitalInput__ = 11;
const uint ON_MIN_DOWN__DigitalInput__ = 12;
const uint OFF_HOUR_UP__DigitalInput__ = 13;
const uint OFF_HOUR_DOWN__DigitalInput__ = 14;
const uint OFF_MIN_UP__DigitalInput__ = 15;
const uint OFF_MIN_DOWN__DigitalInput__ = 16;
const uint TIME_CHECK__DigitalInput__ = 17;
const uint WEEK_DAY__DigitalInput__ = 18;
const uint WARNING_TIME__AnalogSerialInput__ = 0;
const uint SYSTOD__DOLLAR____AnalogSerialInput__ = 1;
const uint FILENAME__AnalogSerialInput__ = 2;
const uint SCHEDULE_ACTIVE_FB__DigitalOutput__ = 0;
const uint ON_ACTIVE_FB__DigitalOutput__ = 1;
const uint OFF_ACTIVE_FB__DigitalOutput__ = 2;
const uint ON_TRIGGER__DigitalOutput__ = 3;
const uint OFF_TRIGGER__DigitalOutput__ = 4;
const uint OFF_WARNING__DigitalOutput__ = 5;
const uint OFF_IS_TOMORROW__DigitalOutput__ = 6;
const uint FILE_SAVED__DigitalOutput__ = 7;
const uint ON_TIME__DOLLAR____AnalogSerialOutput__ = 0;
const uint OFF_TIME__DOLLAR____AnalogSerialOutput__ = 1;
const uint CURRENT_TIME__DOLLAR____AnalogSerialOutput__ = 2;

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

[SplusStructAttribute(-1, true, false)]
public class EVENTSTORE : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  S_HOUR = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  S_HOURTEMP = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  S_MINUTE = 0;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  S_SET = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  S_DAYS = 0;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  S_TIME;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  S_AMPM;
    
    
    public EVENTSTORE( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        S_TIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, Owner );
        S_AMPM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, Owner );
        
        
    }
    
}

}
