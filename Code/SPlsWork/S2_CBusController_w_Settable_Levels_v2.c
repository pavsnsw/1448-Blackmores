#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_CBusController_w_Settable_Levels_v2.h"

FUNCTION_MAIN( S2_CBusController_w_Settable_Levels_v2 );
EVENT_HANDLER( S2_CBusController_w_Settable_Levels_v2 );
DEFINE_ENTRYPOINT( S2_CBusController_w_Settable_Levels_v2 );

static void S2_CBusController_w_Settable_Levels_v2__FNSETUP ( ) 
    { 
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x5C""05" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "0002" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "x\x0D""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x5C""05" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "0002" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "x\x0D""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 119 );
    FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 120 );
    FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
    FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 121 );
    FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
    FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 123 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 1 , 1 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 124 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 1 , 2 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 125 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 1 , 3 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 126 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 1 , 4 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 127 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 1 , 5 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 128 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 1 , 6 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 129 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 1 , 7 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 131 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 2 , 1 , 155) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 132 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 2 , 2 , 155) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 133 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 2 , 3 , 155) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 134 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 2 , 4 , 155) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 135 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 2 , 5 , 155) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 136 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 2 , 6 , 155) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 137 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 2 , 7 , 155) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 139 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 3 , 1 , 100) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 140 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 3 , 2 , 100) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 141 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 3 , 3 , 100) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 142 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 3 , 4 , 100) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 143 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 3 , 5 , 100) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 144 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 3 , 6 , 100) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 145 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 3 , 7 , 100) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 147 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 4 , 1 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 148 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 4 , 2 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 149 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 4 , 3 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 150 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 4 , 4 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 151 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 4 , 5 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 152 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 4 , 6 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 153 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 4 , 7 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 155 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 5 , 1 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 156 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 5 , 2 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 157 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 5 , 3 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 158 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 5 , 4 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 159 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 5 , 5 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 160 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 5 , 6 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 161 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 5 , 7 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 163 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 6 , 1 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 164 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 6 , 2 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 165 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 6 , 3 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 166 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 6 , 4 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 167 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 6 , 5 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 168 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 6 , 6 , 255) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 169 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 6 , 7 , 255) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__FNSETUP:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
    /* End Free local function variables */
    
    }
    
static void S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) 
    { 
    /* Begin local function variable declarations */
    
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 175 );
    SetAnalog ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_LIGHT_LEVEL_1_ANALOG_OUTPUT, GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  )) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 176 );
    SetAnalog ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_LIGHT_LEVEL_2_ANALOG_OUTPUT, GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  )) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 177 );
    SetAnalog ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_LIGHT_LEVEL_3_ANALOG_OUTPUT, GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  )) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 179 );
    if ( GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  )) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 179 );
        SetDigital ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_LIGHT_TOGGLE_1_FB_DIG_OUTPUT, 1) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 180 );
        SetDigital ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_LIGHT_TOGGLE_1_FB_DIG_OUTPUT, 0) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 182 );
    if ( GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  )) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 182 );
        SetDigital ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_LIGHT_TOGGLE_2_FB_DIG_OUTPUT, 1) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 183 );
        SetDigital ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_LIGHT_TOGGLE_2_FB_DIG_OUTPUT, 0) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 185 );
    if ( GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  )) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 185 );
        SetDigital ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_LIGHT_TOGGLE_3_FB_DIG_OUTPUT, 1) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 186 );
        SetDigital ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_LIGHT_TOGGLE_3_FB_DIG_OUTPUT, 0) ; 
        }
    
    
    S2_CBusController_w_Settable_Levels_v2_Exit__FNDOFEDBACK:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00000 /*Lights_Preset_1_bt*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __X; 
    unsigned short  __GETLAST; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 221 );
    __GETLAST = GetLocalLastModifiedArrayIndex ( S2_CBusController_w_Settable_Levels_v2 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 222 );
    __FN_FOREND_VAL__1 = 3; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __X = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__X  <= __FN_FOREND_VAL__1 ) : ((short)__X  >= __FN_FOREND_VAL__1) ; __X  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 224 );
        if ( (CompareStrings( GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )  ,  __X  ), LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ ) , 1 ) != 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 226 );
            SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, __X , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET1LEVELS , __X  )) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 227 );
            if ( ((unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET1LEVELS , __X  ) < 10)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 229 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET1LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 233 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET1LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 235 );
            Delay ( 20) ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 222 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 238 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00001 /*Lights_Preset_2_bt*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __X; 
    unsigned short  __GETLAST; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 244 );
    __GETLAST = GetLocalLastModifiedArrayIndex ( S2_CBusController_w_Settable_Levels_v2 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 245 );
    __FN_FOREND_VAL__1 = 3; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __X = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__X  <= __FN_FOREND_VAL__1 ) : ((short)__X  >= __FN_FOREND_VAL__1) ; __X  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 247 );
        if ( (CompareStrings( GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )  ,  __X  ), LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ ) , 1 ) != 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 249 );
            SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, __X , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET2LEVELS , __X  )) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 250 );
            if ( ((unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET2LEVELS , __X  ) < 10)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 252 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET2LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 256 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET2LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 258 );
            Delay ( 20) ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 245 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 261 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_1:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00002 /*Lights_Preset_3_bt*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __X; 
    unsigned short  __GETLAST; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 267 );
    __GETLAST = GetLocalLastModifiedArrayIndex ( S2_CBusController_w_Settable_Levels_v2 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 268 );
    __FN_FOREND_VAL__1 = 3; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __X = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__X  <= __FN_FOREND_VAL__1 ) : ((short)__X  >= __FN_FOREND_VAL__1) ; __X  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 270 );
        if ( (CompareStrings( GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )  ,  __X  ), LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ ) , 1 ) != 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 272 );
            SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, __X , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET3LEVELS , __X  )) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 273 );
            if ( ((unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET3LEVELS , __X  ) < 10)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 275 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET3LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 279 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET3LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 281 );
            Delay ( 20) ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 268 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 284 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_2:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00003 /*Lights_Preset_4_bt*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __X; 
    unsigned short  __GETLAST; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 290 );
    __GETLAST = GetLocalLastModifiedArrayIndex ( S2_CBusController_w_Settable_Levels_v2 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 291 );
    __FN_FOREND_VAL__1 = 3; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __X = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__X  <= __FN_FOREND_VAL__1 ) : ((short)__X  >= __FN_FOREND_VAL__1) ; __X  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 293 );
        if ( (CompareStrings( GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )  ,  __X  ), LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ ) , 1 ) != 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 295 );
            SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, __X , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET4LEVELS , __X  )) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 296 );
            if ( ((unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET4LEVELS , __X  ) < 10)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 298 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET4LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 302 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET4LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 304 );
            Delay ( 20) ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 291 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 307 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_3:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00004 /*Lights_Preset_5_bt*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __X; 
    unsigned short  __GETLAST; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 313 );
    __GETLAST = GetLocalLastModifiedArrayIndex ( S2_CBusController_w_Settable_Levels_v2 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 314 );
    __FN_FOREND_VAL__1 = 3; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __X = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__X  <= __FN_FOREND_VAL__1 ) : ((short)__X  >= __FN_FOREND_VAL__1) ; __X  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 316 );
        if ( (CompareStrings( GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )  ,  __X  ), LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ ) , 1 ) != 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 318 );
            SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, __X , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET5LEVELS , __X  )) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 319 );
            if ( ((unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET5LEVELS , __X  ) < 10)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 321 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET5LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 325 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET5LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 327 );
            Delay ( 20) ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 314 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 330 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_4:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00005 /*Lights_Preset_6_bt*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __X; 
    unsigned short  __GETLAST; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 336 );
    __GETLAST = GetLocalLastModifiedArrayIndex ( S2_CBusController_w_Settable_Levels_v2 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 337 );
    __FN_FOREND_VAL__1 = 3; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __X = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__X  <= __FN_FOREND_VAL__1 ) : ((short)__X  >= __FN_FOREND_VAL__1) ; __X  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 339 );
        if ( (CompareStrings( GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )  ,  __X  ), LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ ) , 1 ) != 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 341 );
            SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, __X , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET6LEVELS , __X  )) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 342 );
            if ( ((unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET6LEVELS , __X  ) < 10)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 344 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET6LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 348 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  __X  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (unsigned short int)GetInOutArrayElement( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), &Globals->S2_CBusController_w_Settable_Levels_v2.__PRESET6LEVELS , __X  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
                SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
                
                ; 
                } 
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 350 );
            Delay ( 20) ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 337 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 361 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_5:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00006 /*Lights_1_up_bt*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 368 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1 , (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  ) + 20)) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 369 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  ) > 255)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 369 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1 , 255) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 371 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  ) < 10)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 373 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  1  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 377 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  1  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 380 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_6:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00007 /*Lights_2_up_bt*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 385 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2 , (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  ) + 20)) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 386 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  ) > 255)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 386 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2 , 255) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 388 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  ) < 10)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 390 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  2  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 394 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  2  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 397 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_7:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00008 /*Lights_3_up_bt*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 402 );
    SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3 , (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  ) + 20)) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 403 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  ) > 255)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 403 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3 , 255) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 405 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  ) < 10)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 407 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  3  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 411 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  3  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 414 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_8:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00009 /*Lights_1_dn_bt*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 419 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  ) <= 20)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 419 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1 , 0) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 420 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1 , (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  ) - 20)) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 422 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  ) < 10)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 424 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  1  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 428 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  1  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 431 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_9:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000A /*Lights_2_dn_bt*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 436 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  ) <= 20)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 436 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2 , 0) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 437 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2 , (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  ) - 20)) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 439 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  ) < 10)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 441 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  2  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 445 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  2  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 448 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_10:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000B /*Lights_3_dn_bt*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 453 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  ) <= 20)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 453 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3 , 0) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 454 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3 , (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  ) - 20)) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 456 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  ) < 10)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 458 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  3  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 462 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  3  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 465 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_11:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000C /*Lights_1_toggle*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 470 );
    if ( GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  )) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 470 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1 , 0) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 471 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1 , 255) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 472 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  ) < 10)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 474 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  1  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 478 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  1  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 1  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 481 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_12:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000D /*Lights_2_toggle*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 486 );
    if ( GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  )) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 486 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2 , 0) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 487 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2 , 255) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 488 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  ) < 10)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 490 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  2  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 494 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  2  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 2  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 497 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_13:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000E /*Lights_3_toggle*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "0" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "0" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 503 );
    if ( GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  )) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 503 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3 , 0) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 504 );
        SET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3 , 255) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 505 );
    if ( (GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  ) < 10)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 507 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,14 , "%s%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  3  ) ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 511 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) , GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 )  ,12 , "%s%s%s%s%s%s"  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION  )  , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE  )  , GetStringArrayElement ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ),  GLOBAL_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES  )    ,  3  ) , Itohex ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GET_GLOBAL_INTARRAY_VALUE( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 3  )) , GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_CBusController_w_Settable_Levels_v2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 514 );
    S2_CBusController_w_Settable_Levels_v2__FNDOFEDBACK ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__Event_14:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}


    
    

/********************************************************************************
  Constructor
********************************************************************************/

/********************************************************************************
  Destructor
********************************************************************************/

/********************************************************************************
  static void ProcessDigitalEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessDigitalEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_1_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00000 /*Lights_Preset_1_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_2_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00001 /*Lights_Preset_2_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_3_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00002 /*Lights_Preset_3_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_4_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00003 /*Lights_Preset_4_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_5_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00004 /*Lights_Preset_5_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_6_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00005 /*Lights_Preset_6_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_1_UP_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00006 /*Lights_1_up_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_2_UP_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00007 /*Lights_2_up_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_3_UP_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00008 /*Lights_3_up_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_1_DN_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 00009 /*Lights_1_dn_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_2_DN_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000A /*Lights_2_dn_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_3_DN_BT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000B /*Lights_3_dn_bt*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_1_TOGGLE_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000C /*Lights_1_toggle*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_2_TOGGLE_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000D /*Lights_2_toggle*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        case __S2_CBusController_w_Settable_Levels_v2_LIGHTS_3_TOGGLE_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_CBusController_w_Settable_Levels_v2, 0000E /*Lights_3_toggle*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessAnalogEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessAnalogEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_CBusController_w_Settable_Levels_v2 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketConnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketConnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_CBusController_w_Settable_Levels_v2 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketStatusEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketStatusEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_CBusController_w_Settable_Levels_v2 )
********************************************************************************/
EVENT_HANDLER( S2_CBusController_w_Settable_Levels_v2 )
    {
    SAVE_GLOBAL_POINTERS ;
    switch ( Signal->Type )
        {
        case e_SIGNAL_TYPE_DIGITAL :
            ProcessDigitalEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_ANALOG :
            ProcessAnalogEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STRING :
            ProcessStringEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_CONNECT :
            ProcessSocketConnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_DISCONNECT :
            ProcessSocketDisconnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_RECEIVE :
            ProcessSocketReceiveEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STATUS :
            ProcessSocketStatusEvent( Signal );
            break ;
        }
        
    RESTORE_GLOBAL_POINTERS ;
    
    }
    
/********************************************************************************
  FUNCTION_MAIN( S2_CBusController_w_Settable_Levels_v2 )
********************************************************************************/
FUNCTION_MAIN( S2_CBusController_w_Settable_Levels_v2 )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_CBusController_w_Settable_Levels_v2 );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_CBusController_w_Settable_Levels_v2, __PRESET1LEVELS, IO_TYPE_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET1LEVELS_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET1LEVELS_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_CBusController_w_Settable_Levels_v2, __PRESET2LEVELS, IO_TYPE_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET2LEVELS_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET2LEVELS_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_CBusController_w_Settable_Levels_v2, __PRESET3LEVELS, IO_TYPE_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET3LEVELS_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET3LEVELS_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_CBusController_w_Settable_Levels_v2, __PRESET4LEVELS, IO_TYPE_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET4LEVELS_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET4LEVELS_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_CBusController_w_Settable_Levels_v2, __PRESET5LEVELS, IO_TYPE_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET5LEVELS_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET5LEVELS_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_CBusController_w_Settable_Levels_v2, __PRESET6LEVELS, IO_TYPE_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET6LEVELS_INTEGER_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_PRESET6LEVELS_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_CBusController_w_Settable_Levels_v2, __FROM_CBUS, e_INPUT_TYPE_STRING, __S2_CBusController_w_Settable_Levels_v2_FROM_CBUS_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_CBusController_w_Settable_Levels_v2, __FROM_CBUS, __S2_CBusController_w_Settable_Levels_v2_FROM_CBUS_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_PARAMETER_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES, e_INPUT_TYPE_STRING_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_CBUSADDRESSES_ARRAY_NUM_ELEMS, __S2_CBusController_w_Settable_Levels_v2_CBUSADDRESSES_ARRAY_NUM_CHARS, __S2_CBusController_w_Settable_Levels_v2_CBUSADDRESSES_STRING_PARAMETER );
    INITIALIZE_GLOBAL_STRING_ARRAY ( S2_CBusController_w_Settable_Levels_v2, __CPRESETSTRINGS, e_INPUT_TYPE_NONE, __S2_CBusController_w_Settable_Levels_v2_CPRESETSTRINGS_ARRAY_NUM_ELEMS, __S2_CBusController_w_Settable_Levels_v2_CPRESETSTRINGS_ARRAY_NUM_CHARS );
    
    InitStringParamStruct ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), GLOBAL_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION ) , e_INPUT_TYPE_STRING_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_APPLICATION_STRING_PARAMETER, __S2_CBusController_w_Settable_Levels_v2_APPLICATION_PARAM_MAX_LEN, NAME_AS_STRING( __APPLICATION ) );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_CBusController_w_Settable_Levels_v2, __STRHEADER, e_INPUT_TYPE_NONE, __S2_CBusController_w_Settable_Levels_v2_STRHEADER_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE, e_INPUT_TYPE_NONE, __S2_CBusController_w_Settable_Levels_v2_STRMIDDLE_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER, e_INPUT_TYPE_NONE, __S2_CBusController_w_Settable_Levels_v2_STRFOOTER_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_CBusController_w_Settable_Levels_v2, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    INITIALIZE_GLOBAL_INTARRAY ( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 6, 7 );
    INITIALIZE_GLOBAL_INTARRAY ( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 0, 7 );
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 588 );
    WaitForInitializationComplete ( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ) ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_CBusController_w_Settable_Levels_v2 ), 595 );
    S2_CBusController_w_Settable_Levels_v2__FNSETUP ( ) ; 
    
    S2_CBusController_w_Settable_Levels_v2_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
