

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 7.00.0555 */
/* at Tue Nov 22 12:25:31 2011
 */
/* Compiler settings for VisualProfilerBackend.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 7.00.0555 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


#ifdef __cplusplus
extern "C"{
#endif 


#include <rpc.h>
#include <rpcndr.h>

#ifdef _MIDL_USE_GUIDDEF_

#ifndef INITGUID
#define INITGUID
#include <guiddef.h>
#undef INITGUID
#else
#include <guiddef.h>
#endif

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        DEFINE_GUID(name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8)

#else // !_MIDL_USE_GUIDDEF_

#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, IID_ISamplingProfiler,0x19840906,0xC001,0x0000,0x00,0x01,0x00,0x00,0x00,0x00,0x00,0x01);


MIDL_DEFINE_GUID(IID, IID_ITracingProfiler,0x19840906,0xC001,0x0000,0x00,0x01,0x00,0x00,0x00,0x00,0x00,0x02);


MIDL_DEFINE_GUID(IID, LIBID_VisualProfilerBackendLib,0x19840906,0xC001,0x0000,0x00,0x0B,0x00,0x00,0x00,0x00,0x00,0x00);


MIDL_DEFINE_GUID(CLSID, CLSID_SamplingProfiler,0x19840906,0xC001,0x0000,0x00,0x0C,0x00,0x00,0x00,0x00,0x00,0x01);


MIDL_DEFINE_GUID(CLSID, CLSID_TracingProfiler,0x19840906,0xC001,0x0000,0x00,0x0C,0x00,0x00,0x00,0x00,0x00,0x02);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif



