using System.Runtime.InteropServices;
namespace DxLibDLL
{
	public static class DX
	{
		public const int TRUE  = 1;
		public const int FALSE = 0;
		public const int MAX_IMAGE_NUM = 32768;
		public const int MAX_2DSURFACE_NUM = 32768;
		public const int MAX_3DSURFACE_NUM = 65536;
		public const int MAX_IMAGE_DIVNUM = 64;
		public const int MAX_SURFACE_NUM = 65536;
		public const int MAX_SOFTIMAGE_NUM = 8192;
		public const int MAX_SOUND_NUM = 32768;
		public const int MAX_SOFTSOUND_NUM = 8192;
		public const int MAX_MUSIC_NUM = 256;
		public const int MAX_MOVIE_NUM = 100;
		public const int MAX_MASK_NUM = 512;
		public const int MAX_FONT_NUM = 40;
		public const int MAX_INPUT_NUM = 256;
		public const int MAX_SOCKET_NUM = 8192;
		public const int MAX_LIGHT_NUM = 4096;
		public const int MAX_SHADER_NUM = 4096;
		public const int MAX_MODEL_BASE_NUM = 32768;
		public const int MAX_MODEL_NUM = 32768;
		public const int MAX_VERTEX_BUFFER_NUM = 16384;
		public const int MAX_INDEX_BUFFER_NUM = 16384;
		public const int MAX_FILE_NUM = 32768;
		public const int MAX_JOYPAD_NUM = 16;
		public const int MAX_EVENTPROCESS_NUM = 5;
		public const int DEFAULT_SCREEN_SIZE_X = 640;
		public const int DEFAULT_SCREEN_SIZE_Y = 480;
		public const int DEFAULT_COLOR_BITDEPTH = 16;
		public const int FONT_CACHE_MAXNUM = 2024;
		public const int FONT_CACHE_MEMORYSIZE = 327680;
		public const int FONT_CACHE_MAX_YLENGTH = 16384;
		public const int MAX_USERIMAGEREAD_FUNCNUM = 10;
		public const int DX_WINDOWSVERSION_31 = 0;
		public const int DX_WINDOWSVERSION_95 = 1;
		public const int DX_WINDOWSVERSION_98 = 2;
		public const int DX_WINDOWSVERSION_ME = 3;
		public const int DX_WINDOWSVERSION_NT31 = 260;
		public const int DX_WINDOWSVERSION_NT40 = 261;
		public const int DX_WINDOWSVERSION_2000 = 262;
		public const int DX_WINDOWSVERSION_XP = 263;
		public const int DX_WINDOWSVERSION_VISTA = 264;
		public const int DX_WINDOWSVERSION_7 = 265;
		public const int DX_WINDOWSVERSION_8 = 266;
		public const int DX_WINDOWSVERSION_NT_TYPE = 256;
		public const int DX_DIRECTXVERSION_NON = 0;
		public const int DX_DIRECTXVERSION_1 = 65536;
		public const int DX_DIRECTXVERSION_2 = 131072;
		public const int DX_DIRECTXVERSION_3 = 196608;
		public const int DX_DIRECTXVERSION_4 = 262144;
		public const int DX_DIRECTXVERSION_5 = 327680;
		public const int DX_DIRECTXVERSION_6 = 393216;
		public const int DX_DIRECTXVERSION_6_1 = 393472;
		public const int DX_DIRECTXVERSION_7 = 458752;
		public const int DX_DIRECTXVERSION_8 = 524288;
		public const int DX_DIRECTXVERSION_8_1 = 524544;
		public const int DX_CHARSET_DEFAULT = 0;
		public const int DX_CHARSET_SHFTJIS = 1;
		public const int DX_CHARSET_HANGEUL = 2;
		public const int DX_CHARSET_BIG5 = 3;
		public const int DX_CHARSET_GB2312 = 4;
		public const int DX_MIDIMODE_MCI = 0;
		public const int DX_MIDIMODE_DM = 1;
		public const int DX_DRAWMODE_NEAREST = 0;
		public const int DX_DRAWMODE_BILINEAR = 1;
		public const int DX_DRAWMODE_ANISOTROPIC = 2;
		public const int DX_DRAWMODE_OTHER = 3;
		public const int DX_FONTTYPE_NORMAL = 0;
		public const int DX_FONTTYPE_EDGE = 1;
		public const int DX_FONTTYPE_ANTIALIASING = 2;
		public const int DX_FONTTYPE_ANTIALIASING_4X4 = 18;
		public const int DX_FONTTYPE_ANTIALIASING_8X8 = 34;
		public const int DX_FONTTYPE_ANTIALIASING_EDGE = 3;
		public const int DX_FONTTYPE_ANTIALIASING_EDGE_4X4 = 19;
		public const int DX_FONTTYPE_ANTIALIASING_EDGE_8X8 = 35;
		public const int DX_BLENDMODE_NOBLEND = 0;
		public const int DX_BLENDMODE_ALPHA = 1;
		public const int DX_BLENDMODE_ADD = 2;
		public const int DX_BLENDMODE_SUB = 3;
		public const int DX_BLENDMODE_MUL = 4;
		public const int DX_BLENDMODE_SUB2 = 5;
		public const int DX_BLENDMODE_XOR = 6;
		public const int DX_BLENDMODE_DESTCOLOR = 8;
		public const int DX_BLENDMODE_INVDESTCOLOR = 9;
		public const int DX_BLENDMODE_INVSRC = 10;
		public const int DX_BLENDMODE_MULA = 11;
		public const int DX_BLENDMODE_ALPHA_X4 = 12;
		public const int DX_BLENDMODE_ADD_X4 = 13;
		public const int DX_BLENDMODE_SRCCOLOR = 14;
		public const int DX_BLENDMODE_HALF_ADD = 15;
		public const int DX_BLENDGRAPHTYPE_NORMAL = 0;
		public const int DX_BLENDGRAPHTYPE_WIPE = 1;
		public const int DX_BLENDGRAPHTYPE_ALPHA = 2;
		public const int DX_GRAPH_FILTER_MONO = 0;
		public const int DX_GRAPH_FILTER_GAUSS = 1;
		public const int DX_GRAPH_FILTER_DOWN_SCALE = 2;
		public const int DX_GRAPH_FILTER_BRIGHT_CLIP = 3;
		public const int DX_GRAPH_FILTER_HSB = 4;
		public const int DX_GRAPH_FILTER_INVERT = 5;
		public const int DX_GRAPH_FILTER_LEVEL = 6;
		public const int DX_GRAPH_FILTER_TWO_COLOR = 7;
		public const int DX_GRAPH_FILTER_GRADIENT_MAP = 8;
		public const int DX_GRAPH_FILTER_PREMUL_ALPHA = 9;
		public const int DX_GRAPH_FILTER_NUM = 10;
		public const int DX_GRAPH_BLEND_NORMAL = 0;
		public const int DX_GRAPH_BLEND_RGBA_SELECT_MIX = 1;
		public const int DX_GRAPH_BLEND_MULTIPLE = 2;
		public const int DX_GRAPH_BLEND_DIFFERENCE = 3;
		public const int DX_GRAPH_BLEND_ADD = 4;
		public const int DX_GRAPH_BLEND_SCREEN = 5;
		public const int DX_GRAPH_BLEND_OVERLAY = 6;
		public const int DX_GRAPH_BLEND_DODGE = 7;
		public const int DX_GRAPH_BLEND_BURN = 8;
		public const int DX_GRAPH_BLEND_DARKEN = 9;
		public const int DX_GRAPH_BLEND_LIGHTEN = 10;
		public const int DX_GRAPH_BLEND_SOFTLIGHT = 11;
		public const int DX_GRAPH_BLEND_HARDLIGHT = 12;
		public const int DX_GRAPH_BLEND_EXCLUSION = 13;
		public const int DX_GRAPH_BLEND_NORMAL_ALPHACH = 14;
		public const int DX_GRAPH_BLEND_ADD_ALPHACH = 15;
		public const int DX_GRAPH_BLEND_MULTIPLE_A_ONLY = 16;
		public const int DX_GRAPH_BLEND_NUM = 17;
		public const int DX_RGBA_SELECT_SRC_R = 0;
		public const int DX_RGBA_SELECT_SRC_G = 1;
		public const int DX_RGBA_SELECT_SRC_B = 2;
		public const int DX_RGBA_SELECT_SRC_A = 3;
		public const int DX_RGBA_SELECT_BLEND_R = 4;
		public const int DX_RGBA_SELECT_BLEND_G = 5;
		public const int DX_RGBA_SELECT_BLEND_B = 6;
		public const int DX_RGBA_SELECT_BLEND_A = 7;
		public const int DX_CULLING_NONE = 0;
		public const int DX_CULLING_LEFT = 1;
		public const int DX_CULLING_RIGHT = 2;
		public const int DX_CAMERACLIP_LEFT = 1;
		public const int DX_CAMERACLIP_RIGHT = 2;
		public const int DX_CAMERACLIP_BOTTOM = 4;
		public const int DX_CAMERACLIP_TOP = 8;
		public const int DX_CAMERACLIP_BACK = 16;
		public const int DX_CAMERACLIP_FRONT = 32;
		public const int DX_MV1_VERTEX_TYPE_1FRAME = 0;
		public const int DX_MV1_VERTEX_TYPE_4FRAME = 1;
		public const int DX_MV1_VERTEX_TYPE_8FRAME = 2;
		public const int DX_MV1_VERTEX_TYPE_FREE_FRAME = 3;
		public const int DX_MV1_VERTEX_TYPE_NMAP_1FRAME = 4;
		public const int DX_MV1_VERTEX_TYPE_NMAP_4FRAME = 5;
		public const int DX_MV1_VERTEX_TYPE_NMAP_8FRAME = 6;
		public const int DX_MV1_VERTEX_TYPE_NMAP_FREE_FRAME = 7;
		public const int DX_MV1_VERTEX_TYPE_NUM = 8;
		public const int DX_MV1_MESHCATEGORY_NORMAL = 0;
		public const int DX_MV1_MESHCATEGORY_OUTLINE = 1;
		public const int DX_MV1_MESHCATEGORY_OUTLINE_ORIG_SHADER = 2;
		public const int DX_MV1_MESHCATEGORY_NUM = 3;
		public const int MV1_SAVETYPE_MESH = 1;
		public const int MV1_SAVETYPE_ANIM = 2;
		public const int MV1_SAVETYPE_NORMAL = ( MV1_SAVETYPE_MESH | MV1_SAVETYPE_ANIM  );
		public const int MV1_ANIMKEY_DATATYPE_ROTATE = 0;
		public const int MV1_ANIMKEY_DATATYPE_ROTATE_X = 1;
		public const int MV1_ANIMKEY_DATATYPE_ROTATE_Y = 2;
		public const int MV1_ANIMKEY_DATATYPE_ROTATE_Z = 3;
		public const int MV1_ANIMKEY_DATATYPE_SCALE = 5;
		public const int MV1_ANIMKEY_DATATYPE_SCALE_X = 6;
		public const int MV1_ANIMKEY_DATATYPE_SCALE_Y = 7;
		public const int MV1_ANIMKEY_DATATYPE_SCALE_Z = 8;
		public const int MV1_ANIMKEY_DATATYPE_TRANSLATE = 10;
		public const int MV1_ANIMKEY_DATATYPE_TRANSLATE_X = 11;
		public const int MV1_ANIMKEY_DATATYPE_TRANSLATE_Y = 12;
		public const int MV1_ANIMKEY_DATATYPE_TRANSLATE_Z = 13;
		public const int MV1_ANIMKEY_DATATYPE_MATRIX4X4C = 15;
		public const int MV1_ANIMKEY_DATATYPE_MATRIX3X3 = 17;
		public const int MV1_ANIMKEY_DATATYPE_SHAPE = 18;
		public const int MV1_ANIMKEY_DATATYPE_OTHRE = 20;
		public const int MV1_ANIMKEY_TIME_TYPE_ONE = 0;
		public const int MV1_ANIMKEY_TIME_TYPE_KEY = 1;
		public const int MV1_ANIMKEY_TYPE_QUATERNION_X = 0;
		public const int MV1_ANIMKEY_TYPE_VECTOR = 1;
		public const int MV1_ANIMKEY_TYPE_MATRIX4X4C = 2;
		public const int MV1_ANIMKEY_TYPE_MATRIX3X3 = 3;
		public const int MV1_ANIMKEY_TYPE_FLAT = 4;
		public const int MV1_ANIMKEY_TYPE_LINEAR = 5;
		public const int MV1_ANIMKEY_TYPE_BLEND = 6;
		public const int MV1_ANIMKEY_TYPE_QUATERNION_VMD = 7;
		public const int DX_SCREEN_FRONT = -4;
		public const int DX_SCREEN_BACK = -2;
		public const int DX_SCREEN_WORK = -3;
		public const int DX_SCREEN_TEMPFRONT = -5;
		public const int DX_NONE_GRAPH = -5;
		public const int DX_SHAVEDMODE_NONE = 0;
		public const int DX_SHAVEDMODE_DITHER = 1;
		public const int DX_SHAVEDMODE_DIFFUS = 2;
		public const int DX_IMAGESAVETYPE_BMP = 0;
		public const int DX_IMAGESAVETYPE_JPEG = 1;
		public const int DX_IMAGESAVETYPE_PNG = 2;
		public const int DX_PLAYTYPE_LOOPBIT = 2;
		public const int DX_PLAYTYPE_BACKBIT = 1;
		public const int DX_PLAYTYPE_NORMAL = 0;
		public const int DX_PLAYTYPE_BACK = ( DX_PLAYTYPE_BACKBIT  );
		public const int DX_PLAYTYPE_LOOP = ( DX_PLAYTYPE_LOOPBIT | DX_PLAYTYPE_BACKBIT  );
		public const int DX_MOVIEPLAYTYPE_BCANCEL = 0;
		public const int DX_MOVIEPLAYTYPE_NORMAL = 1;
		public const int DX_SOUNDTYPE_NORMAL = 0;
		public const int DX_SOUNDTYPE_STREAMSTYLE = 1;
		public const int DX_SOUNDDATATYPE_MEMNOPRESS = 0;
		public const int DX_SOUNDDATATYPE_MEMNOPRESS_PLUS = 1;
		public const int DX_SOUNDDATATYPE_MEMPRESS = 2;
		public const int DX_SOUNDDATATYPE_FILE = 3;
		public const int DX_READSOUNDFUNCTION_PCM = 1;
		public const int DX_READSOUNDFUNCTION_ACM = 2;
		public const int DX_READSOUNDFUNCTION_OGG = 4;
		public const int DX_READSOUNDFUNCTION_MP3 = 8;
		public const int DX_READSOUNDFUNCTION_DSMP3 = 16;
		public const int DX_MASKTRANS_WHITE = 0;
		public const int DX_MASKTRANS_BLACK = 1;
		public const int DX_MASKTRANS_NONE = 2;
		public const int DX_ZWRITE_MASK = 0;
		public const int DX_ZWRITE_CLEAR = 1;
		public const int DX_CMP_NEVER = 1;
		public const int DX_CMP_LESS = 2;
		public const int DX_CMP_EQUAL = 3;
		public const int DX_CMP_LESSEQUAL = 4;
		public const int DX_CMP_GREATER = 5;
		public const int DX_CMP_NOTEQUAL = 6;
		public const int DX_CMP_GREATEREQUAL = 7;
		public const int DX_CMP_ALWAYS = 8;
		public const int DX_ZCMP_DEFAULT = ( DX_CMP_LESSEQUAL  );
		public const int DX_ZCMP_REVERSE = ( DX_CMP_GREATEREQUAL  );
		public const int DX_SHADEMODE_FLAT = 1;
		public const int DX_SHADEMODE_GOURAUD = 2;
		public const int DX_FOGMODE_NONE = 0;
		public const int DX_FOGMODE_EXP = 1;
		public const int DX_FOGMODE_EXP2 = 2;
		public const int DX_FOGMODE_LINEAR = 3;
		public const int DX_MATERIAL_TYPE_NORMAL = 0;
		public const int DX_MATERIAL_TYPE_TOON = 1;
		public const int DX_MATERIAL_TYPE_TOON_2 = 2;
		public const int DX_MATERIAL_BLENDTYPE_TRANSLUCENT = 0;
		public const int DX_MATERIAL_BLENDTYPE_ADDITIVE = 1;
		public const int DX_MATERIAL_BLENDTYPE_MODULATE = 2;
		public const int DX_TEXADDRESS_WRAP = 1;
		public const int DX_TEXADDRESS_MIRROR = 2;
		public const int DX_TEXADDRESS_CLAMP = 3;
		public const int DX_TEXADDRESS_BORDER = 4;
		public const int DX_VERTEX_TYPE_NORMAL_3D = 0;
		public const int DX_VERTEX_TYPE_SHADER_3D = 1;
		public const int DX_VERTEX_TYPE_NUM = 2;
		public const int DX_INDEX_TYPE_16BIT = 0;
		public const int DX_LOADMODEL_PHYSICS_DISABLE = 1;
		public const int DX_LOADMODEL_PHYSICS_LOADCALC = 0;
		public const int DX_LOADMODEL_PHYSICS_REALTIME = 2;
		public const int DX_PRIMTYPE_POINTLIST = 1;
		public const int DX_PRIMTYPE_LINELIST = 2;
		public const int DX_PRIMTYPE_LINESTRIP = 3;
		public const int DX_PRIMTYPE_TRIANGLELIST = 4;
		public const int DX_PRIMTYPE_TRIANGLESTRIP = 5;
		public const int DX_PRIMTYPE_TRIANGLEFAN = 6;
		public const int DX_LIGHTTYPE_D3DLIGHT_POINT = 1;
		public const int DX_LIGHTTYPE_D3DLIGHT_SPOT = 2;
		public const int DX_LIGHTTYPE_D3DLIGHT_DIRECTIONAL = 3;
		public const int DX_LIGHTTYPE_D3DLIGHT_FORCEDWORD = 2147483647;
		public const int DX_LIGHTTYPE_POINT = 1;
		public const int DX_LIGHTTYPE_SPOT = 2;
		public const int DX_LIGHTTYPE_DIRECTIONAL = 3;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_RGB16 = 0;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_RGB32 = 1;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHA_RGB16 = 2;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHA_RGB32 = 3;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHATEST_RGB16 = 4;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHATEST_RGB32 = 5;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT1 = 6;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT2 = 7;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT3 = 8;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT4 = 9;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT5 = 10;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_RGB16 = 11;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_RGB32 = 12;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ALPHA_RGB32 = 13;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ABGR_I16 = 14;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ABGR_F16 = 15;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ABGR_F32 = 16;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ONE_I8 = 17;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ONE_I16 = 18;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ONE_F16 = 19;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ONE_F32 = 20;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_TWO_I8 = 21;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_TWO_I16 = 22;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_TWO_F16 = 23;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_TWO_F32 = 24;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_NUM = 25;
		public const int DX_GRAPHICSIMAGE_FORMAT_2D = 26;
		public const int DX_GRAPHICSIMAGE_FORMAT_R5G6B5 = 27;
		public const int DX_GRAPHICSIMAGE_FORMAT_X8A8R5G6B5 = 28;
		public const int DX_GRAPHICSIMAGE_FORMAT_X8R8G8B8 = 29;
		public const int DX_GRAPHICSIMAGE_FORMAT_A8R8G8B8 = 30;
		public const int DX_GRAPHICSIMAGE_FORMAT_NUM = 31;
		public const int DX_BASEIMAGE_FORMAT_NORMAL = 0;
		public const int DX_BASEIMAGE_FORMAT_DXT1 = 1;
		public const int DX_BASEIMAGE_FORMAT_DXT2 = 2;
		public const int DX_BASEIMAGE_FORMAT_DXT3 = 3;
		public const int DX_BASEIMAGE_FORMAT_DXT4 = 4;
		public const int DX_BASEIMAGE_FORMAT_DXT5 = 5;
		public const int TOOLBUTTON_STATE_ENABLE = 0;
		public const int TOOLBUTTON_STATE_PRESSED = 1;
		public const int TOOLBUTTON_STATE_DISABLE = 2;
		public const int TOOLBUTTON_STATE_PRESSED_DISABLE = 3;
		public const int TOOLBUTTON_STATE_NUM = 4;
		public const int TOOLBUTTON_TYPE_NORMAL = 0;
		public const int TOOLBUTTON_TYPE_CHECK = 1;
		public const int TOOLBUTTON_TYPE_GROUP = 2;
		public const int TOOLBUTTON_TYPE_SEP = 3;
		public const int TOOLBUTTON_TYPE_NUM = 4;
		public const int MENUITEM_IDTOP = -1414812757;
		public const int MENUITEM_ADD_CHILD = 0;
		public const int MENUITEM_ADD_INSERT = 1;
		public const int MENUITEM_MARK_NONE = 0;
		public const int MENUITEM_MARK_CHECK = 1;
		public const int MENUITEM_MARK_RADIO = 2;
		public const int DX_NUMMODE_10 = 0;
		public const int DX_NUMMODE_16 = 1;
		public const int DX_STRMODE_NOT0 = 2;
		public const int DX_STRMODE_USE0 = 3;
		public const int DX_CHECKINPUT_KEY = 1;
		public const int DX_CHECKINPUT_PAD = 2;
		public const int DX_CHECKINPUT_MOUSE = 4;
		public const int DX_CHECKINPUT_ALL = DX_CHECKINPUT_KEY;
		public const int DX_INPUT_KEY_PAD1 = 4097;
		public const int DX_INPUT_PAD1 = 1;
		public const int DX_INPUT_PAD2 = 2;
		public const int DX_INPUT_PAD3 = 3;
		public const int DX_INPUT_PAD4 = 4;
		public const int DX_INPUT_PAD5 = 5;
		public const int DX_INPUT_PAD6 = 6;
		public const int DX_INPUT_PAD7 = 7;
		public const int DX_INPUT_PAD8 = 8;
		public const int DX_INPUT_PAD9 = 9;
		public const int DX_INPUT_PAD10 = 10;
		public const int DX_INPUT_PAD11 = 11;
		public const int DX_INPUT_PAD12 = 12;
		public const int DX_INPUT_PAD13 = 13;
		public const int DX_INPUT_PAD14 = 14;
		public const int DX_INPUT_PAD15 = 15;
		public const int DX_INPUT_PAD16 = 16;
		public const int DX_INPUT_KEY = 4096;
		public const int DX_MOVIESURFACE_NORMAL = 0;
		public const int DX_MOVIESURFACE_OVERLAY = 1;
		public const int DX_MOVIESURFACE_FULLCOLOR = 2;
		public const int PAD_INPUT_DOWN = 1;
		public const int PAD_INPUT_LEFT = 2;
		public const int PAD_INPUT_RIGHT = 4;
		public const int PAD_INPUT_UP = 8;
		public const int PAD_INPUT_A = 16;
		public const int PAD_INPUT_B = 32;
		public const int PAD_INPUT_C = 64;
		public const int PAD_INPUT_X = 128;
		public const int PAD_INPUT_Y = 256;
		public const int PAD_INPUT_Z = 512;
		public const int PAD_INPUT_L = 1024;
		public const int PAD_INPUT_R = 2048;
		public const int PAD_INPUT_START = 4096;
		public const int PAD_INPUT_M = 8192;
		public const int PAD_INPUT_D = 16384;
		public const int PAD_INPUT_F = 32768;
		public const int PAD_INPUT_G = 65536;
		public const int PAD_INPUT_H = 131072;
		public const int PAD_INPUT_I = 262144;
		public const int PAD_INPUT_J = 524288;
		public const int PAD_INPUT_K = 1048576;
		public const int PAD_INPUT_LL = 2097152;
		public const int PAD_INPUT_N = 4194304;
		public const int PAD_INPUT_O = 8388608;
		public const int PAD_INPUT_P = 16777216;
		public const int PAD_INPUT_RR = 33554432;
		public const int PAD_INPUT_S = 67108864;
		public const int PAD_INPUT_T = 134217728;
		public const int PAD_INPUT_U = 268435456;
		public const int PAD_INPUT_V = 536870912;
		public const int PAD_INPUT_W = 1073741824;
		public const int PAD_INPUT_XX = -2147483648;
		public const int PAD_INPUT_1 = 16;
		public const int PAD_INPUT_2 = 32;
		public const int PAD_INPUT_3 = 64;
		public const int PAD_INPUT_4 = 128;
		public const int PAD_INPUT_5 = 256;
		public const int PAD_INPUT_6 = 512;
		public const int PAD_INPUT_7 = 1024;
		public const int PAD_INPUT_8 = 2048;
		public const int PAD_INPUT_9 = 4096;
		public const int PAD_INPUT_10 = 8192;
		public const int PAD_INPUT_11 = 16384;
		public const int PAD_INPUT_12 = 32768;
		public const int PAD_INPUT_13 = 65536;
		public const int PAD_INPUT_14 = 131072;
		public const int PAD_INPUT_15 = 262144;
		public const int PAD_INPUT_16 = 524288;
		public const int PAD_INPUT_17 = 1048576;
		public const int PAD_INPUT_18 = 2097152;
		public const int PAD_INPUT_19 = 4194304;
		public const int PAD_INPUT_20 = 8388608;
		public const int PAD_INPUT_21 = 16777216;
		public const int PAD_INPUT_22 = 33554432;
		public const int PAD_INPUT_23 = 67108864;
		public const int PAD_INPUT_24 = 134217728;
		public const int PAD_INPUT_25 = 268435456;
		public const int PAD_INPUT_26 = 536870912;
		public const int PAD_INPUT_27 = 1073741824;
		public const int PAD_INPUT_28 = -2147483648;
		public const int MOUSE_INPUT_LEFT = 1;
		public const int MOUSE_INPUT_RIGHT = 2;
		public const int MOUSE_INPUT_MIDDLE = 4;
		public const int MOUSE_INPUT_1 = 1;
		public const int MOUSE_INPUT_2 = 2;
		public const int MOUSE_INPUT_3 = 4;
		public const int MOUSE_INPUT_4 = 8;
		public const int MOUSE_INPUT_5 = 16;
		public const int MOUSE_INPUT_6 = 32;
		public const int MOUSE_INPUT_7 = 64;
		public const int MOUSE_INPUT_8 = 128;
		public const int KEY_INPUT_BACK = 14;
		public const int KEY_INPUT_TAB = 15;
		public const int KEY_INPUT_RETURN = 28;
		public const int KEY_INPUT_LSHIFT = 42;
		public const int KEY_INPUT_RSHIFT = 54;
		public const int KEY_INPUT_LCONTROL = 29;
		public const int KEY_INPUT_RCONTROL = 157;
		public const int KEY_INPUT_ESCAPE = 1;
		public const int KEY_INPUT_SPACE = 57;
		public const int KEY_INPUT_PGUP = 201;
		public const int KEY_INPUT_PGDN = 209;
		public const int KEY_INPUT_END = 207;
		public const int KEY_INPUT_HOME = 199;
		public const int KEY_INPUT_LEFT = 203;
		public const int KEY_INPUT_UP = 200;
		public const int KEY_INPUT_RIGHT = 205;
		public const int KEY_INPUT_DOWN = 208;
		public const int KEY_INPUT_INSERT = 210;
		public const int KEY_INPUT_DELETE = 211;
		public const int KEY_INPUT_MINUS = 12;
		public const int KEY_INPUT_YEN = 125;
		public const int KEY_INPUT_PREVTRACK = 144;
		public const int KEY_INPUT_PERIOD = 52;
		public const int KEY_INPUT_SLASH = 53;
		public const int KEY_INPUT_LALT = 56;
		public const int KEY_INPUT_RALT = 184;
		public const int KEY_INPUT_SCROLL = 70;
		public const int KEY_INPUT_SEMICOLON = 39;
		public const int KEY_INPUT_COLON = 146;
		public const int KEY_INPUT_LBRACKET = 26;
		public const int KEY_INPUT_RBRACKET = 27;
		public const int KEY_INPUT_AT = 145;
		public const int KEY_INPUT_BACKSLASH = 43;
		public const int KEY_INPUT_COMMA = 51;
		public const int KEY_INPUT_KANJI = 148;
		public const int KEY_INPUT_CONVERT = 121;
		public const int KEY_INPUT_NOCONVERT = 123;
		public const int KEY_INPUT_KANA = 112;
		public const int KEY_INPUT_APPS = 221;
		public const int KEY_INPUT_CAPSLOCK = 58;
		public const int KEY_INPUT_SYSRQ = 183;
		public const int KEY_INPUT_PAUSE = 197;
		public const int KEY_INPUT_LWIN = 219;
		public const int KEY_INPUT_RWIN = 220;
		public const int KEY_INPUT_NUMLOCK = 69;
		public const int KEY_INPUT_NUMPAD0 = 82;
		public const int KEY_INPUT_NUMPAD1 = 79;
		public const int KEY_INPUT_NUMPAD2 = 80;
		public const int KEY_INPUT_NUMPAD3 = 81;
		public const int KEY_INPUT_NUMPAD4 = 75;
		public const int KEY_INPUT_NUMPAD5 = 76;
		public const int KEY_INPUT_NUMPAD6 = 77;
		public const int KEY_INPUT_NUMPAD7 = 71;
		public const int KEY_INPUT_NUMPAD8 = 72;
		public const int KEY_INPUT_NUMPAD9 = 73;
		public const int KEY_INPUT_MULTIPLY = 55;
		public const int KEY_INPUT_ADD = 78;
		public const int KEY_INPUT_SUBTRACT = 74;
		public const int KEY_INPUT_DECIMAL = 83;
		public const int KEY_INPUT_DIVIDE = 181;
		public const int KEY_INPUT_NUMPADENTER = 156;
		public const int KEY_INPUT_F1 = 59;
		public const int KEY_INPUT_F2 = 60;
		public const int KEY_INPUT_F3 = 61;
		public const int KEY_INPUT_F4 = 62;
		public const int KEY_INPUT_F5 = 63;
		public const int KEY_INPUT_F6 = 64;
		public const int KEY_INPUT_F7 = 65;
		public const int KEY_INPUT_F8 = 66;
		public const int KEY_INPUT_F9 = 67;
		public const int KEY_INPUT_F10 = 68;
		public const int KEY_INPUT_F11 = 87;
		public const int KEY_INPUT_F12 = 88;
		public const int KEY_INPUT_A = 30;
		public const int KEY_INPUT_B = 48;
		public const int KEY_INPUT_C = 46;
		public const int KEY_INPUT_D = 32;
		public const int KEY_INPUT_E = 18;
		public const int KEY_INPUT_F = 33;
		public const int KEY_INPUT_G = 34;
		public const int KEY_INPUT_H = 35;
		public const int KEY_INPUT_I = 23;
		public const int KEY_INPUT_J = 36;
		public const int KEY_INPUT_K = 37;
		public const int KEY_INPUT_L = 38;
		public const int KEY_INPUT_M = 50;
		public const int KEY_INPUT_N = 49;
		public const int KEY_INPUT_O = 24;
		public const int KEY_INPUT_P = 25;
		public const int KEY_INPUT_Q = 16;
		public const int KEY_INPUT_R = 19;
		public const int KEY_INPUT_S = 31;
		public const int KEY_INPUT_T = 20;
		public const int KEY_INPUT_U = 22;
		public const int KEY_INPUT_V = 47;
		public const int KEY_INPUT_W = 17;
		public const int KEY_INPUT_X = 45;
		public const int KEY_INPUT_Y = 21;
		public const int KEY_INPUT_Z = 44;
		public const int KEY_INPUT_0 = 11;
		public const int KEY_INPUT_1 = 2;
		public const int KEY_INPUT_2 = 3;
		public const int KEY_INPUT_3 = 4;
		public const int KEY_INPUT_4 = 5;
		public const int KEY_INPUT_5 = 6;
		public const int KEY_INPUT_6 = 7;
		public const int KEY_INPUT_7 = 8;
		public const int KEY_INPUT_8 = 9;
		public const int KEY_INPUT_9 = 10;
		public const int CTRL_CODE_BS = 8;
		public const int CTRL_CODE_TAB = 9;
		public const int CTRL_CODE_CR = 13;
		public const int CTRL_CODE_DEL = 16;
		public const int CTRL_CODE_COPY = 3;
		public const int CTRL_CODE_PASTE = 22;
		public const int CTRL_CODE_CUT = 24;
		public const int CTRL_CODE_ALL = 1;
		public const int CTRL_CODE_LEFT = 29;
		public const int CTRL_CODE_RIGHT = 28;
		public const int CTRL_CODE_UP = 30;
		public const int CTRL_CODE_DOWN = 31;
		public const int CTRL_CODE_HOME = 26;
		public const int CTRL_CODE_END = 25;
		public const int CTRL_CODE_PAGE_UP = 23;
		public const int CTRL_CODE_PAGE_DOWN = 21;
		public const int CTRL_CODE_ESC = 27;
		public const int CTRL_CODE_CMP = 32;
		public const int DX_CHANGESCREEN_OK = 0;
		public const int DX_CHANGESCREEN_RETURN = 1;
		public const int DX_CHANGESCREEN_DEFAULT = 2;
		public const int DX_CHANGESCREEN_REFRESHNORMAL = 3;
		public const int LOADIMAGE_TYPE_FILE = 0;
		public const int LOADIMAGE_TYPE_MEM = 1;
		public const int LOADIMAGE_TYPE_NONE = 1;
		public const int HTTP_ERR_SERVER = 0;
		public const int HTTP_ERR_NOTFOUND = 1;
		public const int HTTP_ERR_MEMORY = 2;
		public const int HTTP_ERR_LOST = 3;
		public const int HTTP_ERR_NONE = 1;
		public const int HTTP_RES_COMPLETE = 0;
		public const int HTTP_RES_STOP = 1;
		public const int HTTP_RES_ERROR = 2;
		public const int HTTP_RES_NOW = 1;

		[StructLayout(LayoutKind.Explicit)]
		public struct IPDATA_IPv6
		{
			[FieldOffset(0)] public byte Byte00;
			[FieldOffset(1)] public byte Byte01;
			[FieldOffset(2)] public byte Byte02;
			[FieldOffset(3)] public byte Byte03;
			[FieldOffset(4)] public byte Byte04;
			[FieldOffset(5)] public byte Byte05;
			[FieldOffset(6)] public byte Byte06;
			[FieldOffset(7)] public byte Byte07;
			[FieldOffset(8)] public byte Byte08;
			[FieldOffset(9)] public byte Byte09;
			[FieldOffset(10)] public byte Byte10;
			[FieldOffset(11)] public byte Byte11;
			[FieldOffset(12)] public byte Byte12;
			[FieldOffset(13)] public byte Byte13;
			[FieldOffset(14)] public byte Byte14;
			[FieldOffset(15)] public byte Byte15;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct RECT
		{
			[FieldOffset(0)] public int left;
			[FieldOffset(4)] public int top;
			[FieldOffset(8)] public int right;
			[FieldOffset(12)] public int bottom;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MATRIX
		{
			[FieldOffset(0)] public float m00;
			[FieldOffset(4)] public float m01;
			[FieldOffset(8)] public float m02;
			[FieldOffset(12)] public float m03;
			[FieldOffset(16)] public float m10;
			[FieldOffset(20)] public float m11;
			[FieldOffset(24)] public float m12;
			[FieldOffset(28)] public float m13;
			[FieldOffset(32)] public float m20;
			[FieldOffset(36)] public float m21;
			[FieldOffset(40)] public float m22;
			[FieldOffset(44)] public float m23;
			[FieldOffset(48)] public float m30;
			[FieldOffset(52)] public float m31;
			[FieldOffset(56)] public float m32;
			[FieldOffset(60)] public float m33;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLORDATA
		{
			[FieldOffset(0)] public short ColorBitDepth;
			[FieldOffset(2)] public short PixelByte;
			[FieldOffset(4)] public byte RedWidth ;
			[FieldOffset(5)] public byte GreenWidth ;
			[FieldOffset(6)] public byte BlueWidth ;
			[FieldOffset(7)] public byte AlphaWidth ;
			[FieldOffset(8)] public byte RedLoc ;
			[FieldOffset(9)] public byte GreenLoc ;
			[FieldOffset(10)] public byte BlueLoc ;
			[FieldOffset(11)] public byte AlphaLoc ;
			[FieldOffset(12)] public uint RedMask ;
			[FieldOffset(16)] public uint GreenMask ;
			[FieldOffset(20)] public uint BlueMask ;
			[FieldOffset(24)] public uint AlphaMask ;
			[FieldOffset(28)] public uint NoneMask ;
			[FieldOffset(32)] public COLORPALETTEDATA Palette ;
			[FieldOffset(1056)] public byte NoneLoc ;
			[FieldOffset(1057)] public byte NoneWidth ;
			[FieldOffset(1060)] public int Format ;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_COLL_RESULT_POLY
		{
			[FieldOffset(0)] public int HitFlag;
			[FieldOffset(4)] public VECTOR HitPosition;
			[FieldOffset(16)] public int FrameIndex;
			[FieldOffset(20)] public int PolyIndex;
			[FieldOffset(24)] public int MaterialIndex;
			[FieldOffset(28)] public VECTOR Position0;
			[FieldOffset(40)] public VECTOR Position1;
			[FieldOffset(52)] public VECTOR Position2;
			[FieldOffset(64)] public VECTOR Normal;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_REF_POLYGON
		{
			[FieldOffset(0)] public ushort FrameIndex;
			[FieldOffset(2)] public ushort MaterialIndex;
			[FieldOffset(4)] public int VIndexTarget;
			[FieldOffset(8)] public int VIndex0;
			[FieldOffset(12)] public int VIndex1;
			[FieldOffset(16)] public int VIndex2;
			[FieldOffset(20)] public VECTOR MinPosition;
			[FieldOffset(32)] public VECTOR MaxPosition;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_REF_VERTEX
		{
			[FieldOffset(0)] public VECTOR Position;
			[FieldOffset(12)] public VECTOR Normal;
			[FieldOffset(24)] public UV TexCoord0;
			[FieldOffset(32)] public UV TexCoord1;
			[FieldOffset(40)] public COLOR_U8 DiffuseColor;
			[FieldOffset(44)] public COLOR_U8 SpecularColor;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DINPUT_JOYSTATE
		{
			[FieldOffset(0)] public int X;
			[FieldOffset(4)] public int Y;
			[FieldOffset(8)] public int Z;
			[FieldOffset(12)] public int Rx;
			[FieldOffset(16)] public int Ry;
			[FieldOffset(20)] public int Rz;
			[FieldOffset(24)] public int Slider0;
			[FieldOffset(28)] public int Slider1;
			[FieldOffset(32)] public uint POV0;
			[FieldOffset(36)] public uint POV1;
			[FieldOffset(40)] public uint POV2;
			[FieldOffset(44)] public uint POV3;
			[FieldOffset(48)] public byte Buttons0;
			[FieldOffset(49)] public byte Buttons1;
			[FieldOffset(50)] public byte Buttons2;
			[FieldOffset(51)] public byte Buttons3;
			[FieldOffset(52)] public byte Buttons4;
			[FieldOffset(53)] public byte Buttons5;
			[FieldOffset(54)] public byte Buttons6;
			[FieldOffset(55)] public byte Buttons7;
			[FieldOffset(56)] public byte Buttons8;
			[FieldOffset(57)] public byte Buttons9;
			[FieldOffset(58)] public byte Buttons10;
			[FieldOffset(59)] public byte Buttons11;
			[FieldOffset(60)] public byte Buttons12;
			[FieldOffset(61)] public byte Buttons13;
			[FieldOffset(62)] public byte Buttons14;
			[FieldOffset(63)] public byte Buttons15;
			[FieldOffset(64)] public byte Buttons16;
			[FieldOffset(65)] public byte Buttons17;
			[FieldOffset(66)] public byte Buttons18;
			[FieldOffset(67)] public byte Buttons19;
			[FieldOffset(68)] public byte Buttons20;
			[FieldOffset(69)] public byte Buttons21;
			[FieldOffset(70)] public byte Buttons22;
			[FieldOffset(71)] public byte Buttons23;
			[FieldOffset(72)] public byte Buttons24;
			[FieldOffset(73)] public byte Buttons25;
			[FieldOffset(74)] public byte Buttons26;
			[FieldOffset(75)] public byte Buttons27;
			[FieldOffset(76)] public byte Buttons28;
			[FieldOffset(77)] public byte Buttons29;
			[FieldOffset(78)] public byte Buttons30;
			[FieldOffset(79)] public byte Buttons31;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IMEINPUTCLAUSEDATA
		{
			[FieldOffset(0)] public int  Position;
			[FieldOffset(4)] public int  Length;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IMEINPUTDATA
		{
			[FieldOffset(0)] public uint  InputString;
			[FieldOffset(4)] public int  CursorPosition;
			[FieldOffset(8)] public uint  ClauseData;
			[FieldOffset(12)] public int  ClauseNum;
			[FieldOffset(16)] public int  SelectClause;
			[FieldOffset(20)] public int  CandidateNum;
			[FieldOffset(24)] public uint  CandidateList;
			[FieldOffset(28)] public int  SelectCandidate;
			[FieldOffset(32)] public int  ConvertFlag;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DATEDATA
		{
			[FieldOffset(0)] public int  Year;
			[FieldOffset(4)] public int  Mon;
			[FieldOffset(8)] public int  Day;
			[FieldOffset(12)] public int  Hour;
			[FieldOffset(16)] public int  Min;
			[FieldOffset(20)] public int  Sec;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DISPLAYMODEDATA
		{
			[FieldOffset(0)] public int  Width;
			[FieldOffset(4)] public int  Height;
			[FieldOffset(8)] public int  ColorBitDepth;
			[FieldOffset(12)] public int  RefreshRate;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VECTOR
		{
			[FieldOffset(0)] public float  x;
			[FieldOffset(4)] public float  y;
			[FieldOffset(8)] public float  z;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct UV
		{
			[FieldOffset(0)] public float  u;
			[FieldOffset(4)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLOR_F
		{
			[FieldOffset(0)] public float  r;
			[FieldOffset(4)] public float  g;
			[FieldOffset(8)] public float  b;
			[FieldOffset(12)] public float  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLOR_U8
		{
			[FieldOffset(0)] public byte  b;
			[FieldOffset(1)] public byte  g;
			[FieldOffset(2)] public byte  r;
			[FieldOffset(3)] public byte  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct FLOAT4
		{
			[FieldOffset(0)] public float  x;
			[FieldOffset(4)] public float  y;
			[FieldOffset(8)] public float  z;
			[FieldOffset(12)] public float  w;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct INT4
		{
			[FieldOffset(0)] public int  x;
			[FieldOffset(4)] public int  y;
			[FieldOffset(8)] public int  z;
			[FieldOffset(12)] public int  w;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX_NOTEX_2D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public int  color;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX_2D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public int  color;
			[FieldOffset(20)] public float  u;
			[FieldOffset(24)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX2D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public COLOR_U8  dif;
			[FieldOffset(20)] public float  u;
			[FieldOffset(24)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX2DSHADER
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public COLOR_U8  dif;
			[FieldOffset(20)] public COLOR_U8  spc;
			[FieldOffset(24)] public float  u;
			[FieldOffset(28)] public float  v;
			[FieldOffset(32)] public float  su;
			[FieldOffset(36)] public float  sv;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX
		{
			[FieldOffset(0)] public float  x;
			[FieldOffset(4)] public float  y;
			[FieldOffset(8)] public float  u;
			[FieldOffset(12)] public float  v;
			[FieldOffset(16)] public byte  b;
			[FieldOffset(17)] public byte  g;
			[FieldOffset(18)] public byte  r;
			[FieldOffset(19)] public byte  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX_NOTEX_3D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public byte  b;
			[FieldOffset(13)] public byte  g;
			[FieldOffset(14)] public byte  r;
			[FieldOffset(15)] public byte  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX_3D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public byte  b;
			[FieldOffset(13)] public byte  g;
			[FieldOffset(14)] public byte  r;
			[FieldOffset(15)] public byte  a;
			[FieldOffset(16)] public float  u;
			[FieldOffset(20)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX3D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public VECTOR  norm;
			[FieldOffset(24)] public COLOR_U8  dif;
			[FieldOffset(28)] public COLOR_U8  spc;
			[FieldOffset(32)] public float  u;
			[FieldOffset(36)] public float  v;
			[FieldOffset(40)] public float  su;
			[FieldOffset(44)] public float  sv;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX3DSHADER
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public FLOAT4  spos;
			[FieldOffset(28)] public VECTOR  norm;
			[FieldOffset(40)] public VECTOR  tan;
			[FieldOffset(52)] public VECTOR  binorm;
			[FieldOffset(64)] public COLOR_U8  dif;
			[FieldOffset(68)] public COLOR_U8  spc;
			[FieldOffset(72)] public float  u;
			[FieldOffset(76)] public float  v;
			[FieldOffset(80)] public float  su;
			[FieldOffset(84)] public float  sv;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct LIGHTPARAM
		{
			[FieldOffset(0)] public int  LightType;
			[FieldOffset(4)] public COLOR_F  Diffuse;
			[FieldOffset(20)] public COLOR_F  Specular;
			[FieldOffset(36)] public COLOR_F  Ambient;
			[FieldOffset(52)] public VECTOR  Position;
			[FieldOffset(64)] public VECTOR  Direction;
			[FieldOffset(76)] public float  Range;
			[FieldOffset(80)] public float  Falloff;
			[FieldOffset(84)] public float  Attenuation0;
			[FieldOffset(88)] public float  Attenuation1;
			[FieldOffset(92)] public float  Attenuation2;
			[FieldOffset(96)] public float  Theta;
			[FieldOffset(100)] public float  Phi;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MATERIALPARAM
		{
			[FieldOffset(0)] public COLOR_F  Diffuse;
			[FieldOffset(16)] public COLOR_F  Ambient;
			[FieldOffset(32)] public COLOR_F  Specular;
			[FieldOffset(48)] public COLOR_F  Emissive;
			[FieldOffset(64)] public float  Power;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct HITRESULT_LINE
		{
			[FieldOffset(0)] public int  HitFlag;
			[FieldOffset(4)] public VECTOR  Position;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_COLL_RESULT_POLY_DIM
		{
			[FieldOffset(0)] public int  HitNum;
			[FieldOffset(4)] public uint  Dim;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_REF_POLYGONLIST
		{
			[FieldOffset(0)] public int  PolygonNum;
			[FieldOffset(4)] public int  VertexNum;
			[FieldOffset(8)] public VECTOR  MinPosition;
			[FieldOffset(20)] public VECTOR  MaxPosition;
			[FieldOffset(32)] public uint  Polygons;
			[FieldOffset(36)] public uint  Vertexs;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLORPALETTEDATA
		{
			[FieldOffset(0)] public byte  Blue;
			[FieldOffset(1)] public byte  Green;
			[FieldOffset(2)] public byte  Red;
			[FieldOffset(3)] public byte  Alpha;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct BASEIMAGE
		{
			[FieldOffset(0)] public COLORDATA  ColorData;
			[FieldOffset(1064)] public int  Width;
			[FieldOffset(1068)] public int  Height;
			[FieldOffset(1072)] public int  Pitch;
			[FieldOffset(1076)] public uint  GraphData;
			[FieldOffset(1080)] public int  MipMapCount;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct LINEDATA
		{
			[FieldOffset(0)] public int  x1;
			[FieldOffset(4)] public int  y1;
			[FieldOffset(8)] public int  x2;
			[FieldOffset(12)] public int  y2;
			[FieldOffset(16)] public int  color;
			[FieldOffset(20)] public int  pal;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct POINTDATA
		{
			[FieldOffset(0)] public int  x;
			[FieldOffset(4)] public int  y;
			[FieldOffset(8)] public int  color;
			[FieldOffset(12)] public int  pal;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IMAGEFORMATDESC
		{
			[FieldOffset(0)] public byte  TextureFlag;
			[FieldOffset(1)] public byte  AlphaChFlag;
			[FieldOffset(2)] public byte  DrawValidFlag;
			[FieldOffset(3)] public byte  SystemMemFlag;
			[FieldOffset(4)] public byte  UseManagedTextureFlag;
			[FieldOffset(5)] public byte  BaseFormat;
			[FieldOffset(6)] public byte  MipMapCount;
			[FieldOffset(7)] public byte  AlphaTestFlag;
			[FieldOffset(8)] public byte  FloatTypeFlag;
			[FieldOffset(9)] public byte  ColorBitDepth;
			[FieldOffset(10)] public byte  ChannelNum;
			[FieldOffset(11)] public byte  ChannelBitDepth;
			[FieldOffset(12)] public byte  BlendGraphFlag;
			[FieldOffset(13)] public byte  UsePaletteFlag;
			[FieldOffset(14)] public byte  MSSamples;
			[FieldOffset(15)] public byte  MSQuality;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IPDATA
		{
			[FieldOffset(0)] public byte  d1;
			[FieldOffset(1)] public byte  d2;
			[FieldOffset(2)] public byte  d3;
			[FieldOffset(3)] public byte  d4;
		};


		public static VECTOR VGet( float x, float y, float z )
		{
			VECTOR Result ;
			Result.x = x ;
			Result.y = y ;
			Result.z = z ;
			return Result ;
		}

		public static VECTOR VAdd( VECTOR In1, VECTOR In2 )
		{
			VECTOR Result ;
			Result.x = In1.x + In2.x ;
			Result.y = In1.y + In2.y ;
			Result.z = In1.z + In2.z ;
			return Result ;
		}

		public static VECTOR VSub( VECTOR In1, VECTOR In2 )
		{
			VECTOR Result ;
			Result.x = In1.x - In2.x ;
			Result.y = In1.y - In2.y ;
			Result.z = In1.z - In2.z ;
			return Result ;
		}

		public static float VDot( VECTOR In1, VECTOR In2 )
		{
			return In1.x * In2.x + In1.y * In2.y + In1.z * In2.z ;
		}

		public static VECTOR VCross( VECTOR In1, VECTOR In2 )
		{
			VECTOR Result ;
			Result.x = In1.y * In2.z - In1.z * In2.y ;
			Result.y = In1.z * In2.x - In1.x * In2.z ;
			Result.z = In1.x * In2.y - In1.y * In2.x ;
			return Result ;
		}

		public static VECTOR VScale( VECTOR In, float Scale )
		{
			VECTOR Result ;
			Result.x = In.x * Scale ;
			Result.y = In.y * Scale ;
			Result.z = In.z * Scale ;
			return Result ;
		}

		public static float VSquareSize( VECTOR In )
		{
			return In.x * In.x + In.y * In.y + In.z * In.z ;
		}

		public static VECTOR VTransform( VECTOR InV, MATRIX InM )
		{
			VECTOR Result ;
			Result.x = InV.x * InM.m00 + InV.y * InM.m10 + InV.z * InM.m20 + InM.m30 ;
			Result.y = InV.x * InM.m01 + InV.y * InM.m11 + InV.z * InM.m21 + InM.m31 ;
			Result.z = InV.x * InM.m02 + InV.y * InM.m12 + InV.z * InM.m22 + InM.m32 ;
			return Result ;
		}

		public static VECTOR VTransformSR( VECTOR InV, MATRIX InM )
		{
			VECTOR Result ;
			Result.x = InV.x * InM.m00 + InV.y * InM.m10 + InV.z * InM.m20 ;
			Result.y = InV.x * InM.m01 + InV.y * InM.m11 + InV.z * InM.m21 ;
			Result.z = InV.x * InM.m02 + InV.y * InM.m12 + InV.z * InM.m22 ;
			return Result ;
		}



#if DX_USE_UNSAFE
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate int SetActiveStateChangeCallBackFunctionCallback(int ActiveState, void* UserData);
		[DllImport("DxLib.dll",     EntryPoint="dx_SetActiveStateChangeCallBackFunction")]
		extern unsafe static int dx_SetActiveStateChangeCallBackFunction_x86(SetActiveStateChangeCallBackFunctionCallback Callback, void* UserData);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetActiveStateChangeCallBackFunction")]
		extern unsafe static int dx_SetActiveStateChangeCallBackFunction_x64(SetActiveStateChangeCallBackFunctionCallback Callback, void* UserData);
		public unsafe static int SetActiveStateChangeCallBackFunction(SetActiveStateChangeCallBackFunctionCallback Callback, void* UserData)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetActiveStateChangeCallBackFunction_x86(Callback, UserData);
			}
			else
			{
				return dx_SetActiveStateChangeCallBackFunction_x64(Callback, UserData);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetUseASyncChangeWindowModeFunctionCallback( void *Data );
		[DllImport("DxLib.dll",     EntryPoint="dx_SetUseASyncChangeWindowModeFunction")]
		extern unsafe static int dx_SetUseASyncChangeWindowModeFunction_x86( int Flag , SetUseASyncChangeWindowModeFunctionCallback CallBackFunction, void *Data );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseASyncChangeWindowModeFunction")]
		extern unsafe static int dx_SetUseASyncChangeWindowModeFunction_x64( int Flag , SetUseASyncChangeWindowModeFunctionCallback CallBackFunction, void *Data );
		public unsafe static int SetUseASyncChangeWindowModeFunction( int Flag , SetUseASyncChangeWindowModeFunctionCallback CallBackFunction, void *Data )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseASyncChangeWindowModeFunction_x86( Flag , CallBackFunction, Data );
			}
			else
			{
				return dx_SetUseASyncChangeWindowModeFunction_x64( Flag , CallBackFunction, Data );
			}
		}
#endif
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetMenuItemSelectCallBackFunctionCallback( string ItemName, int ItemID );
		[DllImport("DxLib.dll",     EntryPoint="dx_SetMenuItemSelectCallBackFunction")]
		extern static int dx_SetMenuItemSelectCallBackFunction_x86( SetMenuItemSelectCallBackFunctionCallback CallBackFunction );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMenuItemSelectCallBackFunction")]
		extern static int dx_SetMenuItemSelectCallBackFunction_x64( SetMenuItemSelectCallBackFunctionCallback CallBackFunction );
		public static int SetMenuItemSelectCallBackFunction( SetMenuItemSelectCallBackFunctionCallback CallBackFunction )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMenuItemSelectCallBackFunction_x86( CallBackFunction );
			}
			else
			{
				return dx_SetMenuItemSelectCallBackFunction_x64( CallBackFunction );
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetWindowMenuCallback( ushort ID );
		[DllImport("DxLib.dll",     EntryPoint="dx_SetWindowMenu")]
		extern static int dx_SetWindowMenu_x86( int MenuID, SetWindowMenuCallback MenuProc );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowMenu")]
		extern static int dx_SetWindowMenu_x64( int MenuID, SetWindowMenuCallback MenuProc );
		public static int SetWindowMenu( int MenuID, SetWindowMenuCallback MenuProc )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowMenu_x86( MenuID, MenuProc );
			}
			else
			{
				return dx_SetWindowMenu_x64( MenuID, MenuProc );
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetRestoreShredPointCallback();
		[DllImport("DxLib.dll",     EntryPoint="dx_SetRestoreShredPoint")]
		extern static int dx_SetRestoreShredPoint_x86( SetRestoreShredPointCallback ShredPoint );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetRestoreShredPoint")]
		extern static int dx_SetRestoreShredPoint_x64( SetRestoreShredPointCallback ShredPoint );
		public static int SetRestoreShredPoint( SetRestoreShredPointCallback ShredPoint )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetRestoreShredPoint_x86( ShredPoint );
			}
			else
			{
				return dx_SetRestoreShredPoint_x64( ShredPoint );
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetRestoreGraphCallbackCallback();
		[DllImport("DxLib.dll",     EntryPoint="dx_SetRestoreGraphCallback")]
		extern static int dx_SetRestoreGraphCallback_x86( SetRestoreGraphCallbackCallback Callback );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetRestoreGraphCallback")]
		extern static int dx_SetRestoreGraphCallback_x64( SetRestoreGraphCallbackCallback Callback );
		public static int SetRestoreGraphCallback( SetRestoreGraphCallbackCallback Callback )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetRestoreGraphCallback_x86( Callback );
			}
			else
			{
				return dx_SetRestoreGraphCallback_x64( Callback );
			}
		}

		[DllImport("DxLib.dll",     EntryPoint="dx_ClearDrawScreen")]
		extern static int dx_ClearDrawScreen_x86( out RECT  ClearRect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ClearDrawScreen")]
		extern static int dx_ClearDrawScreen_x64( out RECT  ClearRect);
		public static int  ClearDrawScreen( out RECT  ClearRect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ClearDrawScreen_x86( out ClearRect );
			}
			else
			{
				return dx_ClearDrawScreen_x64( out ClearRect );
			}
		}
		public static int  ClearDrawScreen()
		{
			RECT temp;
		
			temp.left = -1;
			temp.top = -1;
			temp.right = -1;
			temp.bottom = -1;
			if( System.IntPtr.Size == 4 )
			{
				return dx_ClearDrawScreen_x86( out temp );
			}
			else
			{
				return dx_ClearDrawScreen_x64( out temp );
			}
		}
		
		[DllImport("DxLib.dll",     EntryPoint="dx_ClearDrawScreenZBuffer")]
		extern static int dx_ClearDrawScreenZBuffer_x86( out RECT  ClearRect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ClearDrawScreenZBuffer")]
		extern static int dx_ClearDrawScreenZBuffer_x64( out RECT  ClearRect);
		public static int  ClearDrawScreenZBuffer( out RECT  ClearRect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ClearDrawScreenZBuffer_x86( out ClearRect );
			}
			else
			{
				return dx_ClearDrawScreenZBuffer_x64( out ClearRect );
			}
		}
		public static int ClearDrawScreenZBuffer()
		{
			RECT temp;
		
			temp.left = -1;
			temp.top = -1;
			temp.right = -1;
			temp.bottom = -1;
			if( System.IntPtr.Size == 4 )
			{
				return dx_ClearDrawScreenZBuffer_x86( out temp );
			}
			else
			{
				return dx_ClearDrawScreenZBuffer_x64( out temp );
			}
		}
		
		[DllImport("DxLib.dll",     EntryPoint="dx_SetKeyInputStringColor")]
		extern static int dx_SetKeyInputStringColor_x86( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF, ulong  SelectStrBackColor, ulong  SelectStrColor, ulong  SelectStrEdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputStringColor")]
		extern static int dx_SetKeyInputStringColor_x64( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF, ulong  SelectStrBackColor, ulong  SelectStrColor, ulong  SelectStrEdgeColor);
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringColor_x86( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , 0 , 0 , 0 , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
			else
			{
				return dx_SetKeyInputStringColor_x64( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , 0 , 0 , 0 , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringColor_x86( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , 0 , 0 , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
			else
			{
				return dx_SetKeyInputStringColor_x64( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , 0 , 0 , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringColor_x86( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , 0 , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
			else
			{
				return dx_SetKeyInputStringColor_x64( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , 0 , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringColor_x86( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
			else
			{
				return dx_SetKeyInputStringColor_x64( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringColor_x86( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
			else
			{
				return dx_SetKeyInputStringColor_x64( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringColor_x86( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
			else
			{
				return dx_SetKeyInputStringColor_x64( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , 0xffffffffffffffff , 0xffffffffffffffff , 0xffffffffffffffff );
			}
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF, ulong  SelectStrBackColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringColor_x86( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , SelectStrBackColor , 0xffffffffffffffff , 0xffffffffffffffff );
			}
			else
			{
				return dx_SetKeyInputStringColor_x64( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , SelectStrBackColor , 0xffffffffffffffff , 0xffffffffffffffff );
			}
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF, ulong  SelectStrBackColor, ulong  SelectStrColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringColor_x86( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , SelectStrBackColor , SelectStrColor , 0xffffffffffffffff );
			}
			else
			{
				return dx_SetKeyInputStringColor_x64( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , SelectStrBackColor , SelectStrColor , 0xffffffffffffffff );
			}
		}
		public static int  SetKeyInputStringColor( ulong  NmlStr, ulong  NmlCur, ulong  IMEStr, ulong  IMECur, ulong  IMELine, ulong  IMESelectStr, ulong  IMEModeStr, ulong  NmlStrE, ulong  IMESelectStrE, ulong  IMEModeStrE, ulong  IMESelectWinE, ulong  IMESelectWinF, ulong  SelectStrBackColor, ulong  SelectStrColor, ulong  SelectStrEdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringColor_x86( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , SelectStrBackColor , SelectStrColor , SelectStrEdgeColor );
			}
			else
			{
				return dx_SetKeyInputStringColor_x64( NmlStr , NmlCur , IMEStr , IMECur , IMELine , IMESelectStr , IMEModeStr , NmlStrE , IMESelectStrE , IMEModeStrE , IMESelectWinE , IMESelectWinF , SelectStrBackColor , SelectStrColor , SelectStrEdgeColor );
			}
		}


		[DllImport("DxLib.dll",     EntryPoint="dx_GraphFilterS")]
		extern static int dx_GraphFilterS_x86( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GraphFilterS")]
		extern static int dx_GraphFilterS_x64( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterS_x86( GrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
			else
			{
				return dx_GraphFilterS_x64( GrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterS_x86( GrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
			}
			else
			{
				return dx_GraphFilterS_x64( GrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
			}
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterS_x86( GrHandle, FilterType, Param0, Param1, Param2, Param3, 0, 0);
			}
			else
			{
				return dx_GraphFilterS_x64( GrHandle, FilterType, Param0, Param1, Param2, Param3, 0, 0);
			}
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterS_x86( GrHandle, FilterType, Param0, Param1, Param2, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterS_x64( GrHandle, FilterType, Param0, Param1, Param2, 0, 0, 0);
			}
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterS_x86( GrHandle, FilterType, Param0, Param1, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterS_x64( GrHandle, FilterType, Param0, Param1, 0, 0, 0, 0);
			}
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterS_x86( GrHandle, FilterType, Param0, 0, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterS_x64( GrHandle, FilterType, Param0, 0, 0, 0, 0, 0);
			}
		}
		public static int  GraphFilter( int GrHandle, int FilterType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterS_x86( GrHandle, FilterType, 0, 0, 0, 0, 0, 0 );
			}
			else
			{
				return dx_GraphFilterS_x64( GrHandle, FilterType, 0, 0, 0, 0, 0, 0 );
			}
		}

		[DllImport("DxLib.dll",     EntryPoint="dx_GraphFilterBltS")]
		extern static int dx_GraphFilterBltS_x86( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GraphFilterBltS")]
		extern static int dx_GraphFilterBltS_x64( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterBltS_x86( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
			else
			{
				return dx_GraphFilterBltS_x64( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterBltS_x86( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
			}
			else
			{
				return dx_GraphFilterBltS_x64( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
			}
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterBltS_x86( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, 0, 0);
			}
			else
			{
				return dx_GraphFilterBltS_x64( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, 0, 0);
			}
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterBltS_x86( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterBltS_x64( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, 0, 0, 0);
			}
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterBltS_x86( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterBltS_x64( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, 0, 0, 0, 0);
			}
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterBltS_x86( SrcGrHandle, DestGrHandle, FilterType, Param0, 0, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterBltS_x64( SrcGrHandle, DestGrHandle, FilterType, Param0, 0, 0, 0, 0, 0);
			}
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterBltS_x86( SrcGrHandle, DestGrHandle, FilterType, 0, 0, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterBltS_x64( SrcGrHandle, DestGrHandle, FilterType, 0, 0, 0, 0, 0, 0);
			}
		}

		[DllImport("DxLib.dll",     EntryPoint="dx_GraphFilterRectBltS")]
		extern static int dx_GraphFilterRectBltS_x86( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GraphFilterRectBltS")]
		extern static int dx_GraphFilterRectBltS_x64( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterRectBltS_x86( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
			else
			{
				return dx_GraphFilterRectBltS_x64( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterRectBltS_x86( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
			}
			else
			{
				return dx_GraphFilterRectBltS_x64( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
			}
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterRectBltS_x86( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, 0, 0);
			}
			else
			{
				return dx_GraphFilterRectBltS_x64( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, 0, 0);
			}
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterRectBltS_x86( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterRectBltS_x64( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, 0, 0, 0);
			}
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterRectBltS_x86( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterRectBltS_x64( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, 0, 0, 0, 0);
			}
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterRectBltS_x86( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, 0, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterRectBltS_x64( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, 0, 0, 0, 0, 0);
			}
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphFilterRectBltS_x86( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, 0, 0, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphFilterRectBltS_x64( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, 0, 0, 0, 0, 0, 0);
			}
		}

		[DllImport("DxLib.dll",     EntryPoint="dx_GraphBlendS")]
		extern static int dx_GraphBlendS_x86( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GraphBlendS")]
		extern static int dx_GraphBlendS_x64( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendS_x86( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
			else
			{
				return dx_GraphBlendS_x64( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendS_x86( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
			}
			else
			{
				return dx_GraphBlendS_x64( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
			}
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendS_x86( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
			}
			else
			{
				return dx_GraphBlendS_x64( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
			}
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendS_x86( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
			}
			else
			{
				return dx_GraphBlendS_x64( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
			}
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendS_x86( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphBlendS_x64( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
			}
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendS_x86( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphBlendS_x64( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
			}
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendS_x86( GrHandle, BlendGrHandle, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
			}
			else
			{
				return dx_GraphBlendS_x64( GrHandle, BlendGrHandle, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
			}
		}

		[DllImport("DxLib.dll",     EntryPoint="dx_GraphBlendBltS")]
		extern static int dx_GraphBlendBltS_x86( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GraphBlendBltS")]
		extern static int dx_GraphBlendBltS_x64( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
			else
			{
				return dx_GraphBlendBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
			}
			else
			{
				return dx_GraphBlendBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
			}
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
			}
			else
			{
				return dx_GraphBlendBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
			}
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
			}
			else
			{
				return dx_GraphBlendBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
			}
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphBlendBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
			}
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphBlendBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
			}
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
			}
			else
			{
				return dx_GraphBlendBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
			}
		}

		[DllImport("DxLib.dll",     EntryPoint="dx_GraphBlendRectBltS")]
		extern static int dx_GraphBlendRectBltS_x86( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GraphBlendRectBltS")]
		extern static int dx_GraphBlendRectBltS_x64( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendRectBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
			else
			{
				return dx_GraphBlendRectBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendRectBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
			}
			else
			{
				return dx_GraphBlendRectBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
			}
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendRectBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
			}
			else
			{
				return dx_GraphBlendRectBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
			}
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendRectBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
			}
			else
			{
				return dx_GraphBlendRectBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
			}
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendRectBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphBlendRectBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
			}
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendRectBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
			}
			else
			{
				return dx_GraphBlendRectBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
			}
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphBlendRectBltS_x86( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
			}
			else
			{
				return dx_GraphBlendRectBltS_x64( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
			}
		}


		[DllImport("DxLib.dll",     EntryPoint="dx_SetBlendGraphParamS")]
		extern static int dx_SetBlendGraphParamS_x86( int BlendGraph, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetBlendGraphParamS")]
		extern static int dx_SetBlendGraphParamS_x64( int BlendGraph, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBlendGraphParamS_x86( BlendGraph, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
			else
			{
				return dx_SetBlendGraphParamS_x64( BlendGraph, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
			}
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBlendGraphParamS_x86( BlendGraph, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
			}
			else
			{
				return dx_SetBlendGraphParamS_x64( BlendGraph, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
			}
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBlendGraphParamS_x86( BlendGraph, BlendType, Param0, Param1, Param2, Param3, 0, 0);
			}
			else
			{
				return dx_SetBlendGraphParamS_x64( BlendGraph, BlendType, Param0, Param1, Param2, Param3, 0, 0);
			}
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1, int Param2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBlendGraphParamS_x86( BlendGraph, BlendType, Param0, Param1, Param2, 0, 0, 0);
			}
			else
			{
				return dx_SetBlendGraphParamS_x64( BlendGraph, BlendType, Param0, Param1, Param2, 0, 0, 0);
			}
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBlendGraphParamS_x86( BlendGraph, BlendType, Param0, Param1, 0, 0, 0, 0);
			}
			else
			{
				return dx_SetBlendGraphParamS_x64( BlendGraph, BlendType, Param0, Param1, 0, 0, 0, 0);
			}
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBlendGraphParamS_x86( BlendGraph, BlendType, Param0, 0, 0, 0, 0, 0);
			}
			else
			{
				return dx_SetBlendGraphParamS_x64( BlendGraph, BlendType, Param0, 0, 0, 0, 0, 0);
			}
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBlendGraphParamS_x86( BlendGraph, BlendType, 0, 0, 0, 0, 0, 0 );
			}
			else
			{
				return dx_SetBlendGraphParamS_x64( BlendGraph, BlendType, 0, 0, 0, 0, 0, 0 );
			}
		}



		[DllImport("DxLib.dll", EntryPoint="dx_DxLib_Init")]
		extern static int  dx_DxLib_Init_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxLib_Init")]
		extern static int  dx_DxLib_Init_x64( );
		public static int  DxLib_Init( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxLib_Init_x86( );
			}
			else
			{
				return dx_DxLib_Init_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxLib_End")]
		extern static int  dx_DxLib_End_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxLib_End")]
		extern static int  dx_DxLib_End_x64( );
		public static int  DxLib_End( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxLib_End_x86( );
			}
			else
			{
				return dx_DxLib_End_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxLib_GlobalStructInitialize")]
		extern static int  dx_DxLib_GlobalStructInitialize_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxLib_GlobalStructInitialize")]
		extern static int  dx_DxLib_GlobalStructInitialize_x64( );
		public static int  DxLib_GlobalStructInitialize( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxLib_GlobalStructInitialize_x86( );
			}
			else
			{
				return dx_DxLib_GlobalStructInitialize_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxLib_IsInit")]
		extern static int  dx_DxLib_IsInit_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxLib_IsInit")]
		extern static int  dx_DxLib_IsInit_x64( );
		public static int  DxLib_IsInit( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxLib_IsInit_x86( );
			}
			else
			{
				return dx_DxLib_IsInit_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessMessage")]
		extern static int  dx_ProcessMessage_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ProcessMessage")]
		extern static int  dx_ProcessMessage_x64( );
		public static int  ProcessMessage( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ProcessMessage_x86( );
			}
			else
			{
				return dx_ProcessMessage_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_WaitTimer")]
		extern static int  dx_WaitTimer_x86( int  WaitTime);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_WaitTimer")]
		extern static int  dx_WaitTimer_x64( int  WaitTime);
		public static int  WaitTimer( int  WaitTime)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_WaitTimer_x86( WaitTime );
			}
			else
			{
				return dx_WaitTimer_x64( WaitTime );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_WaitKey")]
		extern static int  dx_WaitKey_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_WaitKey")]
		extern static int  dx_WaitKey_x64( );
		public static int  WaitKey( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_WaitKey_x86( );
			}
			else
			{
				return dx_WaitKey_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNowCount")]
		extern static int  dx_GetNowCount_x86( int  UseRDTSCFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNowCount")]
		extern static int  dx_GetNowCount_x64( int  UseRDTSCFlag);
		public static int  GetNowCount( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNowCount_x86( FALSE );
			}
			else
			{
				return dx_GetNowCount_x64( FALSE );
			}
		}
		public static int  GetNowCount( int  UseRDTSCFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNowCount_x86( UseRDTSCFlag );
			}
			else
			{
				return dx_GetNowCount_x64( UseRDTSCFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNowHiPerformanceCount")]
		extern static long  dx_GetNowHiPerformanceCount_x86( int  UseRDTSCFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNowHiPerformanceCount")]
		extern static long  dx_GetNowHiPerformanceCount_x64( int  UseRDTSCFlag);
		public static long  GetNowHiPerformanceCount( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNowHiPerformanceCount_x86( FALSE );
			}
			else
			{
				return dx_GetNowHiPerformanceCount_x64( FALSE );
			}
		}
		public static long  GetNowHiPerformanceCount( int  UseRDTSCFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNowHiPerformanceCount_x86( UseRDTSCFlag );
			}
			else
			{
				return dx_GetNowHiPerformanceCount_x64( UseRDTSCFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDateTime")]
		extern static int  dx_GetDateTime_x86( out DATEDATA  DateBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDateTime")]
		extern static int  dx_GetDateTime_x64( out DATEDATA  DateBuf);
		public static int  GetDateTime( out DATEDATA  DateBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDateTime_x86( out DateBuf );
			}
			else
			{
				return dx_GetDateTime_x64( out DateBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetRand")]
		extern static int  dx_GetRand_x86( int  RandMax);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetRand")]
		extern static int  dx_GetRand_x64( int  RandMax);
		public static int  GetRand( int  RandMax)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetRand_x86( RandMax );
			}
			else
			{
				return dx_GetRand_x64( RandMax );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SRand")]
		extern static int  dx_SRand_x86( int  Seed);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SRand")]
		extern static int  dx_SRand_x64( int  Seed);
		public static int  SRand( int  Seed)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SRand_x86( Seed );
			}
			else
			{
				return dx_SRand_x64( Seed );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ErrorLogAdd")]
		extern static int  dx_ErrorLogAdd_x86( string  ErrorStr);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ErrorLogAdd")]
		extern static int  dx_ErrorLogAdd_x64( string  ErrorStr);
		public static int  ErrorLogAdd( string  ErrorStr)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ErrorLogAdd_x86( ErrorStr );
			}
			else
			{
				return dx_ErrorLogAdd_x64( ErrorStr );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ErrorLogTabAdd")]
		extern static int  dx_ErrorLogTabAdd_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ErrorLogTabAdd")]
		extern static int  dx_ErrorLogTabAdd_x64( );
		public static int  ErrorLogTabAdd( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ErrorLogTabAdd_x86( );
			}
			else
			{
				return dx_ErrorLogTabAdd_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ErrorLogTabSub")]
		extern static int  dx_ErrorLogTabSub_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ErrorLogTabSub")]
		extern static int  dx_ErrorLogTabSub_x64( );
		public static int  ErrorLogTabSub( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ErrorLogTabSub_x86( );
			}
			else
			{
				return dx_ErrorLogTabSub_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseTimeStampFlag")]
		extern static int  dx_SetUseTimeStampFlag_x86( int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseTimeStampFlag")]
		extern static int  dx_SetUseTimeStampFlag_x64( int  UseFlag);
		public static int  SetUseTimeStampFlag( int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseTimeStampFlag_x86( UseFlag );
			}
			else
			{
				return dx_SetUseTimeStampFlag_x64( UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLogDrawOutFlag")]
		extern static int  dx_SetLogDrawOutFlag_x86( int  DrawFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLogDrawOutFlag")]
		extern static int  dx_SetLogDrawOutFlag_x64( int  DrawFlag);
		public static int  SetLogDrawOutFlag( int  DrawFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLogDrawOutFlag_x86( DrawFlag );
			}
			else
			{
				return dx_SetLogDrawOutFlag_x64( DrawFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLogDrawFlag")]
		extern static int  dx_GetLogDrawFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLogDrawFlag")]
		extern static int  dx_GetLogDrawFlag_x64( );
		public static int  GetLogDrawFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLogDrawFlag_x86( );
			}
			else
			{
				return dx_GetLogDrawFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLogFontSize")]
		extern static int  dx_SetLogFontSize_x86( int  Size);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLogFontSize")]
		extern static int  dx_SetLogFontSize_x64( int  Size);
		public static int  SetLogFontSize( int  Size)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLogFontSize_x86( Size );
			}
			else
			{
				return dx_SetLogFontSize_x64( Size );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_clsDx")]
		extern static int  dx_clsDx_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_clsDx")]
		extern static int  dx_clsDx_x64( );
		public static int  clsDx( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_clsDx_x86( );
			}
			else
			{
				return dx_clsDx_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseASyncLoadFlag")]
		extern static int  dx_SetUseASyncLoadFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseASyncLoadFlag")]
		extern static int  dx_SetUseASyncLoadFlag_x64( int  Flag);
		public static int  SetUseASyncLoadFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseASyncLoadFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseASyncLoadFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckHandleASyncLoad")]
		extern static int  dx_CheckHandleASyncLoad_x86( int  Handle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckHandleASyncLoad")]
		extern static int  dx_CheckHandleASyncLoad_x64( int  Handle);
		public static int  CheckHandleASyncLoad( int  Handle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckHandleASyncLoad_x86( Handle );
			}
			else
			{
				return dx_CheckHandleASyncLoad_x64( Handle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetHandleASyncLoadResult")]
		extern static int  dx_GetHandleASyncLoadResult_x86( int  Handle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetHandleASyncLoadResult")]
		extern static int  dx_GetHandleASyncLoadResult_x64( int  Handle);
		public static int  GetHandleASyncLoadResult( int  Handle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetHandleASyncLoadResult_x86( Handle );
			}
			else
			{
				return dx_GetHandleASyncLoadResult_x64( Handle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetASyncLoadNum")]
		extern static int  dx_GetASyncLoadNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetASyncLoadNum")]
		extern static int  dx_GetASyncLoadNum_x64( );
		public static int  GetASyncLoadNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetASyncLoadNum_x86( );
			}
			else
			{
				return dx_GetASyncLoadNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDeleteHandleFlag")]
		extern static int  dx_SetDeleteHandleFlag_x86( int  Handle, out int  DeleteFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDeleteHandleFlag")]
		extern static int  dx_SetDeleteHandleFlag_x64( int  Handle, out int  DeleteFlag);
		public static int  SetDeleteHandleFlag( int  Handle, out int  DeleteFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDeleteHandleFlag_x86( Handle , out DeleteFlag );
			}
			else
			{
				return dx_SetDeleteHandleFlag_x64( Handle , out DeleteFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowCRect")]
		extern static int  dx_GetWindowCRect_x86( out RECT  RectBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetWindowCRect")]
		extern static int  dx_GetWindowCRect_x64( out RECT  RectBuf);
		public static int  GetWindowCRect( out RECT  RectBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetWindowCRect_x86( out RectBuf );
			}
			else
			{
				return dx_GetWindowCRect_x64( out RectBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowActiveFlag")]
		extern static int  dx_GetWindowActiveFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetWindowActiveFlag")]
		extern static int  dx_GetWindowActiveFlag_x64( );
		public static int  GetWindowActiveFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetWindowActiveFlag_x86( );
			}
			else
			{
				return dx_GetWindowActiveFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetActiveFlag")]
		extern static int  dx_GetActiveFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetActiveFlag")]
		extern static int  dx_GetActiveFlag_x64( );
		public static int  GetActiveFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetActiveFlag_x86( );
			}
			else
			{
				return dx_GetActiveFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowModeFlag")]
		extern static int  dx_GetWindowModeFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetWindowModeFlag")]
		extern static int  dx_GetWindowModeFlag_x64( );
		public static int  GetWindowModeFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetWindowModeFlag_x86( );
			}
			else
			{
				return dx_GetWindowModeFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDefaultState")]
		extern static int  dx_GetDefaultState_x86( out int  SizeX, out int  SizeY, out int  ColorBitDepth);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDefaultState")]
		extern static int  dx_GetDefaultState_x64( out int  SizeX, out int  SizeY, out int  ColorBitDepth);
		public static int  GetDefaultState( out int  SizeX, out int  SizeY, out int  ColorBitDepth)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDefaultState_x86( out SizeX , out SizeY , out ColorBitDepth );
			}
			else
			{
				return dx_GetDefaultState_x64( out SizeX , out SizeY , out ColorBitDepth );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNoActiveState")]
		extern static int  dx_GetNoActiveState_x86( int  ResetFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNoActiveState")]
		extern static int  dx_GetNoActiveState_x64( int  ResetFlag);
		public static int  GetNoActiveState( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNoActiveState_x86( TRUE );
			}
			else
			{
				return dx_GetNoActiveState_x64( TRUE );
			}
		}
		public static int  GetNoActiveState( int  ResetFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNoActiveState_x86( ResetFlag );
			}
			else
			{
				return dx_GetNoActiveState_x64( ResetFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseDispFlag")]
		extern static int  dx_GetMouseDispFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMouseDispFlag")]
		extern static int  dx_GetMouseDispFlag_x64( );
		public static int  GetMouseDispFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseDispFlag_x86( );
			}
			else
			{
				return dx_GetMouseDispFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetAlwaysRunFlag")]
		extern static int  dx_GetAlwaysRunFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetAlwaysRunFlag")]
		extern static int  dx_GetAlwaysRunFlag_x64( );
		public static int  GetAlwaysRunFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetAlwaysRunFlag_x86( );
			}
			else
			{
				return dx_GetAlwaysRunFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx__GetSystemInfo")]
		extern static int  dx__GetSystemInfo_x86( out int  DxLibVer, out int  DirectXVer, out int  WindowsVer);
		[DllImport("DxLib_x64.dll", EntryPoint="dx__GetSystemInfo")]
		extern static int  dx__GetSystemInfo_x64( out int  DxLibVer, out int  DirectXVer, out int  WindowsVer);
		public static int  _GetSystemInfo( out int  DxLibVer, out int  DirectXVer, out int  WindowsVer)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx__GetSystemInfo_x86( out DxLibVer , out DirectXVer , out WindowsVer );
			}
			else
			{
				return dx__GetSystemInfo_x64( out DxLibVer , out DirectXVer , out WindowsVer );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPcInfo")]
		extern static int  dx_GetPcInfo_x86( System.Text.StringBuilder  OSString, System.Text.StringBuilder  DirectXString, System.Text.StringBuilder  CPUString, out int  CPUSpeed, out double  FreeMemorySize, out double  TotalMemorySize, System.Text.StringBuilder  VideoDriverFileName, System.Text.StringBuilder  VideoDriverString, out double  FreeVideoMemorySize, out double  TotalVideoMemorySize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetPcInfo")]
		extern static int  dx_GetPcInfo_x64( System.Text.StringBuilder  OSString, System.Text.StringBuilder  DirectXString, System.Text.StringBuilder  CPUString, out int  CPUSpeed, out double  FreeMemorySize, out double  TotalMemorySize, System.Text.StringBuilder  VideoDriverFileName, System.Text.StringBuilder  VideoDriverString, out double  FreeVideoMemorySize, out double  TotalVideoMemorySize);
		public static int  GetPcInfo( System.Text.StringBuilder  OSString, System.Text.StringBuilder  DirectXString, System.Text.StringBuilder  CPUString, out int  CPUSpeed, out double  FreeMemorySize, out double  TotalMemorySize, System.Text.StringBuilder  VideoDriverFileName, System.Text.StringBuilder  VideoDriverString, out double  FreeVideoMemorySize, out double  TotalVideoMemorySize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetPcInfo_x86( OSString , DirectXString , CPUString , out CPUSpeed , out FreeMemorySize , out TotalMemorySize , VideoDriverFileName , VideoDriverString , out FreeVideoMemorySize , out TotalVideoMemorySize );
			}
			else
			{
				return dx_GetPcInfo_x64( OSString , DirectXString , CPUString , out CPUSpeed , out FreeMemorySize , out TotalMemorySize , VideoDriverFileName , VideoDriverString , out FreeVideoMemorySize , out TotalVideoMemorySize );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseMMXFlag")]
		extern static int  dx_GetUseMMXFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseMMXFlag")]
		extern static int  dx_GetUseMMXFlag_x64( );
		public static int  GetUseMMXFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseMMXFlag_x86( );
			}
			else
			{
				return dx_GetUseMMXFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseSSEFlag")]
		extern static int  dx_GetUseSSEFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseSSEFlag")]
		extern static int  dx_GetUseSSEFlag_x64( );
		public static int  GetUseSSEFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseSSEFlag_x86( );
			}
			else
			{
				return dx_GetUseSSEFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseSSE2Flag")]
		extern static int  dx_GetUseSSE2Flag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseSSE2Flag")]
		extern static int  dx_GetUseSSE2Flag_x64( );
		public static int  GetUseSSE2Flag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseSSE2Flag_x86( );
			}
			else
			{
				return dx_GetUseSSE2Flag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowCloseFlag")]
		extern static int  dx_GetWindowCloseFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetWindowCloseFlag")]
		extern static int  dx_GetWindowCloseFlag_x64( );
		public static int  GetWindowCloseFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetWindowCloseFlag_x86( );
			}
			else
			{
				return dx_GetWindowCloseFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseWindowRgnFlag")]
		extern static int  dx_GetUseWindowRgnFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseWindowRgnFlag")]
		extern static int  dx_GetUseWindowRgnFlag_x64( );
		public static int  GetUseWindowRgnFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseWindowRgnFlag_x86( );
			}
			else
			{
				return dx_GetUseWindowRgnFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowSize")]
		extern static int  dx_GetWindowSize_x86( out int  Width, out int  Height);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetWindowSize")]
		extern static int  dx_GetWindowSize_x64( out int  Width, out int  Height);
		public static int  GetWindowSize( out int  Width, out int  Height)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetWindowSize_x86( out Width , out Height );
			}
			else
			{
				return dx_GetWindowSize_x64( out Width , out Height );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowPosition")]
		extern static int  dx_GetWindowPosition_x86( out int  x, out int  y);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetWindowPosition")]
		extern static int  dx_GetWindowPosition_x64( out int  x, out int  y);
		public static int  GetWindowPosition( out int  x, out int  y)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetWindowPosition_x86( out x , out y );
			}
			else
			{
				return dx_GetWindowPosition_x64( out x , out y );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWindowUserCloseFlag")]
		extern static int  dx_GetWindowUserCloseFlag_x86( int  StateResetFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetWindowUserCloseFlag")]
		extern static int  dx_GetWindowUserCloseFlag_x64( int  StateResetFlag);
		public static int  GetWindowUserCloseFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetWindowUserCloseFlag_x86( FALSE );
			}
			else
			{
				return dx_GetWindowUserCloseFlag_x64( FALSE );
			}
		}
		public static int  GetWindowUserCloseFlag( int  StateResetFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetWindowUserCloseFlag_x86( StateResetFlag );
			}
			else
			{
				return dx_GetWindowUserCloseFlag_x64( StateResetFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNotDrawFlag")]
		extern static int  dx_GetNotDrawFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNotDrawFlag")]
		extern static int  dx_GetNotDrawFlag_x64( );
		public static int  GetNotDrawFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNotDrawFlag_x86( );
			}
			else
			{
				return dx_GetNotDrawFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPaintMessageFlag")]
		extern static int  dx_GetPaintMessageFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetPaintMessageFlag")]
		extern static int  dx_GetPaintMessageFlag_x64( );
		public static int  GetPaintMessageFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetPaintMessageFlag_x86( );
			}
			else
			{
				return dx_GetPaintMessageFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetValidHiPerformanceCounter")]
		extern static int  dx_GetValidHiPerformanceCounter_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetValidHiPerformanceCounter")]
		extern static int  dx_GetValidHiPerformanceCounter_x64( );
		public static int  GetValidHiPerformanceCounter( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetValidHiPerformanceCounter_x86( );
			}
			else
			{
				return dx_GetValidHiPerformanceCounter_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeWindowMode")]
		extern static int  dx_ChangeWindowMode_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ChangeWindowMode")]
		extern static int  dx_ChangeWindowMode_x64( int  Flag);
		public static int  ChangeWindowMode( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeWindowMode_x86( Flag );
			}
			else
			{
				return dx_ChangeWindowMode_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseCharSet")]
		extern static int  dx_SetUseCharSet_x86( int  CharSet);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseCharSet")]
		extern static int  dx_SetUseCharSet_x64( int  CharSet);
		public static int  SetUseCharSet( int  CharSet)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseCharSet_x86( CharSet );
			}
			else
			{
				return dx_SetUseCharSet_x64( CharSet );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadPauseGraph")]
		extern static int  dx_LoadPauseGraph_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadPauseGraph")]
		extern static int  dx_LoadPauseGraph_x64( string  FileName);
		public static int  LoadPauseGraph( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadPauseGraph_x86( FileName );
			}
			else
			{
				return dx_LoadPauseGraph_x64( FileName );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadPauseGraphFromMem")]
		extern unsafe static int  dx_LoadPauseGraphFromMem_x86( void *  MemImage, int  MemImageSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadPauseGraphFromMem")]
		extern unsafe static int  dx_LoadPauseGraphFromMem_x64( void *  MemImage, int  MemImageSize);
		public unsafe static int  LoadPauseGraphFromMem( void *  MemImage, int  MemImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadPauseGraphFromMem_x86( MemImage , MemImageSize );
			}
			else
			{
				return dx_LoadPauseGraphFromMem_x64( MemImage , MemImageSize );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowText")]
		extern static int  dx_SetWindowText_x86( string  WindowText);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowText")]
		extern static int  dx_SetWindowText_x64( string  WindowText);
		public static int  SetWindowText( string  WindowText)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowText_x86( WindowText );
			}
			else
			{
				return dx_SetWindowText_x64( WindowText );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMainWindowText")]
		extern static int  dx_SetMainWindowText_x86( string  WindowText);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMainWindowText")]
		extern static int  dx_SetMainWindowText_x64( string  WindowText);
		public static int  SetMainWindowText( string  WindowText)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMainWindowText_x86( WindowText );
			}
			else
			{
				return dx_SetMainWindowText_x64( WindowText );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMainWindowClassName")]
		extern static int  dx_SetMainWindowClassName_x86( string  ClassName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMainWindowClassName")]
		extern static int  dx_SetMainWindowClassName_x64( string  ClassName);
		public static int  SetMainWindowClassName( string  ClassName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMainWindowClassName_x86( ClassName );
			}
			else
			{
				return dx_SetMainWindowClassName_x64( ClassName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetOutApplicationLogValidFlag")]
		extern static int  dx_SetOutApplicationLogValidFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetOutApplicationLogValidFlag")]
		extern static int  dx_SetOutApplicationLogValidFlag_x64( int  Flag);
		public static int  SetOutApplicationLogValidFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetOutApplicationLogValidFlag_x86( Flag );
			}
			else
			{
				return dx_SetOutApplicationLogValidFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetApplicationLogSaveDirectory")]
		extern static int  dx_SetApplicationLogSaveDirectory_x86( string  DirectoryPath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetApplicationLogSaveDirectory")]
		extern static int  dx_SetApplicationLogSaveDirectory_x64( string  DirectoryPath);
		public static int  SetApplicationLogSaveDirectory( string  DirectoryPath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetApplicationLogSaveDirectory_x86( DirectoryPath );
			}
			else
			{
				return dx_SetApplicationLogSaveDirectory_x64( DirectoryPath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDateNameLogFile")]
		extern static int  dx_SetUseDateNameLogFile_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseDateNameLogFile")]
		extern static int  dx_SetUseDateNameLogFile_x64( int  Flag);
		public static int  SetUseDateNameLogFile( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseDateNameLogFile_x86( Flag );
			}
			else
			{
				return dx_SetUseDateNameLogFile_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetAlwaysRunFlag")]
		extern static int  dx_SetAlwaysRunFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetAlwaysRunFlag")]
		extern static int  dx_SetAlwaysRunFlag_x64( int  Flag);
		public static int  SetAlwaysRunFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetAlwaysRunFlag_x86( Flag );
			}
			else
			{
				return dx_SetAlwaysRunFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowIconID")]
		extern static int  dx_SetWindowIconID_x86( int  ID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowIconID")]
		extern static int  dx_SetWindowIconID_x64( int  ID);
		public static int  SetWindowIconID( int  ID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowIconID_x86( ID );
			}
			else
			{
				return dx_SetWindowIconID_x64( ID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowIconHandle")]
		extern static int  dx_SetWindowIconHandle_x86( System.IntPtr  Icon);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowIconHandle")]
		extern static int  dx_SetWindowIconHandle_x64( System.IntPtr  Icon);
		public static int  SetWindowIconHandle( System.IntPtr  Icon)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowIconHandle_x86( Icon );
			}
			else
			{
				return dx_SetWindowIconHandle_x64( Icon );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowStyleMode")]
		extern static int  dx_SetWindowStyleMode_x86( int  Mode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowStyleMode")]
		extern static int  dx_SetWindowStyleMode_x64( int  Mode);
		public static int  SetWindowStyleMode( int  Mode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowStyleMode_x86( Mode );
			}
			else
			{
				return dx_SetWindowStyleMode_x64( Mode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowSizeChangeEnableFlag")]
		extern static int  dx_SetWindowSizeChangeEnableFlag_x86( int  Flag, int  FitScreen);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowSizeChangeEnableFlag")]
		extern static int  dx_SetWindowSizeChangeEnableFlag_x64( int  Flag, int  FitScreen);
		public static int  SetWindowSizeChangeEnableFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowSizeChangeEnableFlag_x86( Flag , TRUE );
			}
			else
			{
				return dx_SetWindowSizeChangeEnableFlag_x64( Flag , TRUE );
			}
		}
		public static int  SetWindowSizeChangeEnableFlag( int  Flag, int  FitScreen)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowSizeChangeEnableFlag_x86( Flag , FitScreen );
			}
			else
			{
				return dx_SetWindowSizeChangeEnableFlag_x64( Flag , FitScreen );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowSizeExtendRate")]
		extern static int  dx_SetWindowSizeExtendRate_x86( double  ExRateX, double  ExRateY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowSizeExtendRate")]
		extern static int  dx_SetWindowSizeExtendRate_x64( double  ExRateX, double  ExRateY);
		public static int  SetWindowSizeExtendRate( double  ExRateX)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowSizeExtendRate_x86( ExRateX , -1.0 );
			}
			else
			{
				return dx_SetWindowSizeExtendRate_x64( ExRateX , -1.0 );
			}
		}
		public static int  SetWindowSizeExtendRate( double  ExRateX, double  ExRateY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowSizeExtendRate_x86( ExRateX , ExRateY );
			}
			else
			{
				return dx_SetWindowSizeExtendRate_x64( ExRateX , ExRateY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowSize")]
		extern static int  dx_SetWindowSize_x86( int  Width, int  Height);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowSize")]
		extern static int  dx_SetWindowSize_x64( int  Width, int  Height);
		public static int  SetWindowSize( int  Width, int  Height)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowSize_x86( Width , Height );
			}
			else
			{
				return dx_SetWindowSize_x64( Width , Height );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowPosition")]
		extern static int  dx_SetWindowPosition_x86( int  x, int  y);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowPosition")]
		extern static int  dx_SetWindowPosition_x64( int  x, int  y);
		public static int  SetWindowPosition( int  x, int  y)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowPosition_x86( x , y );
			}
			else
			{
				return dx_SetWindowPosition_x64( x , y );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetSysCommandOffFlag")]
		extern static int  dx_SetSysCommandOffFlag_x86( int  Flag, string  HookDllPath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetSysCommandOffFlag")]
		extern static int  dx_SetSysCommandOffFlag_x64( int  Flag, string  HookDllPath);
		public static int  SetSysCommandOffFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetSysCommandOffFlag_x86( Flag , null );
			}
			else
			{
				return dx_SetSysCommandOffFlag_x64( Flag , null );
			}
		}
		public static int  SetSysCommandOffFlag( int  Flag, string  HookDllPath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetSysCommandOffFlag_x86( Flag , HookDllPath );
			}
			else
			{
				return dx_SetSysCommandOffFlag_x64( Flag , HookDllPath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseHookWinProcReturnValue")]
		extern static int  dx_SetUseHookWinProcReturnValue_x86( int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseHookWinProcReturnValue")]
		extern static int  dx_SetUseHookWinProcReturnValue_x64( int  UseFlag);
		public static int  SetUseHookWinProcReturnValue( int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseHookWinProcReturnValue_x86( UseFlag );
			}
			else
			{
				return dx_SetUseHookWinProcReturnValue_x64( UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDoubleStartValidFlag")]
		extern static int  dx_SetDoubleStartValidFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDoubleStartValidFlag")]
		extern static int  dx_SetDoubleStartValidFlag_x64( int  Flag);
		public static int  SetDoubleStartValidFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDoubleStartValidFlag_x86( Flag );
			}
			else
			{
				return dx_SetDoubleStartValidFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMessageTakeOverWindow")]
		extern static int  dx_AddMessageTakeOverWindow_x86( System.IntPtr  Window);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddMessageTakeOverWindow")]
		extern static int  dx_AddMessageTakeOverWindow_x64( System.IntPtr  Window);
		public static int  AddMessageTakeOverWindow( System.IntPtr  Window)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMessageTakeOverWindow_x86( Window );
			}
			else
			{
				return dx_AddMessageTakeOverWindow_x64( Window );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SubMessageTakeOverWindow")]
		extern static int  dx_SubMessageTakeOverWindow_x86( System.IntPtr  Window);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SubMessageTakeOverWindow")]
		extern static int  dx_SubMessageTakeOverWindow_x64( System.IntPtr  Window);
		public static int  SubMessageTakeOverWindow( System.IntPtr  Window)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SubMessageTakeOverWindow_x86( Window );
			}
			else
			{
				return dx_SubMessageTakeOverWindow_x64( Window );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowInitPosition")]
		extern static int  dx_SetWindowInitPosition_x86( int  x, int  y);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowInitPosition")]
		extern static int  dx_SetWindowInitPosition_x64( int  x, int  y);
		public static int  SetWindowInitPosition( int  x, int  y)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowInitPosition_x86( x , y );
			}
			else
			{
				return dx_SetWindowInitPosition_x64( x , y );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotWinFlag")]
		extern static int  dx_SetNotWinFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetNotWinFlag")]
		extern static int  dx_SetNotWinFlag_x64( int  Flag);
		public static int  SetNotWinFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetNotWinFlag_x86( Flag );
			}
			else
			{
				return dx_SetNotWinFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotDrawFlag")]
		extern static int  dx_SetNotDrawFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetNotDrawFlag")]
		extern static int  dx_SetNotDrawFlag_x64( int  Flag);
		public static int  SetNotDrawFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetNotDrawFlag_x86( Flag );
			}
			else
			{
				return dx_SetNotDrawFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotSoundFlag")]
		extern static int  dx_SetNotSoundFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetNotSoundFlag")]
		extern static int  dx_SetNotSoundFlag_x64( int  Flag);
		public static int  SetNotSoundFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetNotSoundFlag_x86( Flag );
			}
			else
			{
				return dx_SetNotSoundFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotInputFlag")]
		extern static int  dx_SetNotInputFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetNotInputFlag")]
		extern static int  dx_SetNotInputFlag_x64( int  Flag);
		public static int  SetNotInputFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetNotInputFlag_x86( Flag );
			}
			else
			{
				return dx_SetNotInputFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDialogBoxHandle")]
		extern static int  dx_SetDialogBoxHandle_x86( System.IntPtr  WindowHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDialogBoxHandle")]
		extern static int  dx_SetDialogBoxHandle_x64( System.IntPtr  WindowHandle);
		public static int  SetDialogBoxHandle( System.IntPtr  WindowHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDialogBoxHandle_x86( WindowHandle );
			}
			else
			{
				return dx_SetDialogBoxHandle_x64( WindowHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowVisibleFlag")]
		extern static int  dx_SetWindowVisibleFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowVisibleFlag")]
		extern static int  dx_SetWindowVisibleFlag_x64( int  Flag);
		public static int  SetWindowVisibleFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowVisibleFlag_x86( Flag );
			}
			else
			{
				return dx_SetWindowVisibleFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowMinimizeFlag")]
		extern static int  dx_SetWindowMinimizeFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowMinimizeFlag")]
		extern static int  dx_SetWindowMinimizeFlag_x64( int  Flag);
		public static int  SetWindowMinimizeFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowMinimizeFlag_x86( Flag );
			}
			else
			{
				return dx_SetWindowMinimizeFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowUserCloseEnableFlag")]
		extern static int  dx_SetWindowUserCloseEnableFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowUserCloseEnableFlag")]
		extern static int  dx_SetWindowUserCloseEnableFlag_x64( int  Flag);
		public static int  SetWindowUserCloseEnableFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowUserCloseEnableFlag_x86( Flag );
			}
			else
			{
				return dx_SetWindowUserCloseEnableFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDxLibEndPostQuitMessageFlag")]
		extern static int  dx_SetDxLibEndPostQuitMessageFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDxLibEndPostQuitMessageFlag")]
		extern static int  dx_SetDxLibEndPostQuitMessageFlag_x64( int  Flag);
		public static int  SetDxLibEndPostQuitMessageFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDxLibEndPostQuitMessageFlag_x86( Flag );
			}
			else
			{
				return dx_SetDxLibEndPostQuitMessageFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUserWindow")]
		extern static int  dx_SetUserWindow_x86( System.IntPtr  WindowHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUserWindow")]
		extern static int  dx_SetUserWindow_x64( System.IntPtr  WindowHandle);
		public static int  SetUserWindow( System.IntPtr  WindowHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUserWindow_x86( WindowHandle );
			}
			else
			{
				return dx_SetUserWindow_x64( WindowHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUserChildWindow")]
		extern static int  dx_SetUserChildWindow_x86( System.IntPtr  WindowHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUserChildWindow")]
		extern static int  dx_SetUserChildWindow_x64( System.IntPtr  WindowHandle);
		public static int  SetUserChildWindow( System.IntPtr  WindowHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUserChildWindow_x86( WindowHandle );
			}
			else
			{
				return dx_SetUserChildWindow_x64( WindowHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUserWindowMessageProcessDXLibFlag")]
		extern static int  dx_SetUserWindowMessageProcessDXLibFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUserWindowMessageProcessDXLibFlag")]
		extern static int  dx_SetUserWindowMessageProcessDXLibFlag_x64( int  Flag);
		public static int  SetUserWindowMessageProcessDXLibFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUserWindowMessageProcessDXLibFlag_x86( Flag );
			}
			else
			{
				return dx_SetUserWindowMessageProcessDXLibFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBackgroundColor")]
		extern static int  dx_SetBackgroundColor_x86( int  Red, int  Green, int  Blue);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetBackgroundColor")]
		extern static int  dx_SetBackgroundColor_x64( int  Red, int  Green, int  Blue);
		public static int  SetBackgroundColor( int  Red, int  Green, int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBackgroundColor_x86( Red , Green , Blue );
			}
			else
			{
				return dx_SetBackgroundColor_x64( Red , Green , Blue );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseFPUPreserveFlag")]
		extern static int  dx_SetUseFPUPreserveFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseFPUPreserveFlag")]
		extern static int  dx_SetUseFPUPreserveFlag_x64( int  Flag);
		public static int  SetUseFPUPreserveFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseFPUPreserveFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseFPUPreserveFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetValidMousePointerWindowOutClientAreaMoveFlag")]
		extern static int  dx_SetValidMousePointerWindowOutClientAreaMoveFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetValidMousePointerWindowOutClientAreaMoveFlag")]
		extern static int  dx_SetValidMousePointerWindowOutClientAreaMoveFlag_x64( int  Flag);
		public static int  SetValidMousePointerWindowOutClientAreaMoveFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetValidMousePointerWindowOutClientAreaMoveFlag_x86( Flag );
			}
			else
			{
				return dx_SetValidMousePointerWindowOutClientAreaMoveFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseBackBufferTransColorFlag")]
		extern static int  dx_SetUseBackBufferTransColorFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseBackBufferTransColorFlag")]
		extern static int  dx_SetUseBackBufferTransColorFlag_x64( int  Flag);
		public static int  SetUseBackBufferTransColorFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseBackBufferTransColorFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseBackBufferTransColorFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetClipboardText")]
		extern static int  dx_GetClipboardText_x86( System.Text.StringBuilder  DestBuffer);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetClipboardText")]
		extern static int  dx_GetClipboardText_x64( System.Text.StringBuilder  DestBuffer);
		public static int  GetClipboardText( System.Text.StringBuilder  DestBuffer)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetClipboardText_x86( DestBuffer );
			}
			else
			{
				return dx_GetClipboardText_x64( DestBuffer );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetClipboardText")]
		extern static int  dx_SetClipboardText_x86( string  Text);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetClipboardText")]
		extern static int  dx_SetClipboardText_x64( string  Text);
		public static int  SetClipboardText( string  Text)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetClipboardText_x86( Text );
			}
			else
			{
				return dx_SetClipboardText_x64( Text );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDragFileValidFlag")]
		extern static int  dx_SetDragFileValidFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDragFileValidFlag")]
		extern static int  dx_SetDragFileValidFlag_x64( int  Flag);
		public static int  SetDragFileValidFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDragFileValidFlag_x86( Flag );
			}
			else
			{
				return dx_SetDragFileValidFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DragFileInfoClear")]
		extern static int  dx_DragFileInfoClear_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DragFileInfoClear")]
		extern static int  dx_DragFileInfoClear_x64( );
		public static int  DragFileInfoClear( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DragFileInfoClear_x86( );
			}
			else
			{
				return dx_DragFileInfoClear_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDragFilePath")]
		extern static int  dx_GetDragFilePath_x86( System.Text.StringBuilder  FilePathBuffer);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDragFilePath")]
		extern static int  dx_GetDragFilePath_x64( System.Text.StringBuilder  FilePathBuffer);
		public static int  GetDragFilePath( System.Text.StringBuilder  FilePathBuffer)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDragFilePath_x86( FilePathBuffer );
			}
			else
			{
				return dx_GetDragFilePath_x64( FilePathBuffer );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDragFileNum")]
		extern static int  dx_GetDragFileNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDragFileNum")]
		extern static int  dx_GetDragFileNum_x64( );
		public static int  GetDragFileNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDragFileNum_x86( );
			}
			else
			{
				return dx_GetDragFileNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowRgnGraph")]
		extern static int  dx_SetWindowRgnGraph_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowRgnGraph")]
		extern static int  dx_SetWindowRgnGraph_x64( string  FileName);
		public static int  SetWindowRgnGraph( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowRgnGraph_x86( FileName );
			}
			else
			{
				return dx_SetWindowRgnGraph_x64( FileName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_UpdateTransColorWindowRgn")]
		extern static int  dx_UpdateTransColorWindowRgn_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_UpdateTransColorWindowRgn")]
		extern static int  dx_UpdateTransColorWindowRgn_x64( );
		public static int  UpdateTransColorWindowRgn( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_UpdateTransColorWindowRgn_x86( );
			}
			else
			{
				return dx_UpdateTransColorWindowRgn_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupToolBar")]
		extern static int  dx_SetupToolBar_x86( string  BitmapName, int  DivNum, int  ResourceID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetupToolBar")]
		extern static int  dx_SetupToolBar_x64( string  BitmapName, int  DivNum, int  ResourceID);
		public static int  SetupToolBar( string  BitmapName, int  DivNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetupToolBar_x86( BitmapName , DivNum , -1 );
			}
			else
			{
				return dx_SetupToolBar_x64( BitmapName , DivNum , -1 );
			}
		}
		public static int  SetupToolBar( string  BitmapName, int  DivNum, int  ResourceID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetupToolBar_x86( BitmapName , DivNum , ResourceID );
			}
			else
			{
				return dx_SetupToolBar_x64( BitmapName , DivNum , ResourceID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddToolBarButton")]
		extern static int  dx_AddToolBarButton_x86( int  Type, int  State, int  ImageIndex, int  ID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddToolBarButton")]
		extern static int  dx_AddToolBarButton_x64( int  Type, int  State, int  ImageIndex, int  ID);
		public static int  AddToolBarButton( int  Type, int  State, int  ImageIndex, int  ID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddToolBarButton_x86( Type , State , ImageIndex , ID );
			}
			else
			{
				return dx_AddToolBarButton_x64( Type , State , ImageIndex , ID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddToolBarSep")]
		extern static int  dx_AddToolBarSep_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddToolBarSep")]
		extern static int  dx_AddToolBarSep_x64( );
		public static int  AddToolBarSep( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddToolBarSep_x86( );
			}
			else
			{
				return dx_AddToolBarSep_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetToolBarButtonState")]
		extern static int  dx_GetToolBarButtonState_x86( int  ID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetToolBarButtonState")]
		extern static int  dx_GetToolBarButtonState_x64( int  ID);
		public static int  GetToolBarButtonState( int  ID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetToolBarButtonState_x86( ID );
			}
			else
			{
				return dx_GetToolBarButtonState_x64( ID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetToolBarButtonState")]
		extern static int  dx_SetToolBarButtonState_x86( int  ID, int  State);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetToolBarButtonState")]
		extern static int  dx_SetToolBarButtonState_x64( int  ID, int  State);
		public static int  SetToolBarButtonState( int  ID, int  State)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetToolBarButtonState_x86( ID , State );
			}
			else
			{
				return dx_SetToolBarButtonState_x64( ID , State );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteAllToolBarButton")]
		extern static int  dx_DeleteAllToolBarButton_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteAllToolBarButton")]
		extern static int  dx_DeleteAllToolBarButton_x64( );
		public static int  DeleteAllToolBarButton( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteAllToolBarButton_x86( );
			}
			else
			{
				return dx_DeleteAllToolBarButton_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseMenuFlag")]
		extern static int  dx_SetUseMenuFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseMenuFlag")]
		extern static int  dx_SetUseMenuFlag_x64( int  Flag);
		public static int  SetUseMenuFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseMenuFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseMenuFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseKeyAccelFlag")]
		extern static int  dx_SetUseKeyAccelFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseKeyAccelFlag")]
		extern static int  dx_SetUseKeyAccelFlag_x64( int  Flag);
		public static int  SetUseKeyAccelFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseKeyAccelFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseKeyAccelFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddKeyAccel")]
		extern static int  dx_AddKeyAccel_x86( string  ItemName, int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddKeyAccel")]
		extern static int  dx_AddKeyAccel_x64( string  ItemName, int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag);
		public static int  AddKeyAccel( string  ItemName, int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddKeyAccel_x86( ItemName , ItemID , KeyCode , CtrlFlag , AltFlag , ShiftFlag );
			}
			else
			{
				return dx_AddKeyAccel_x64( ItemName , ItemID , KeyCode , CtrlFlag , AltFlag , ShiftFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddKeyAccel_Name")]
		extern static int  dx_AddKeyAccel_Name_x86( string  ItemName, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddKeyAccel_Name")]
		extern static int  dx_AddKeyAccel_Name_x64( string  ItemName, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag);
		public static int  AddKeyAccel_Name( string  ItemName, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddKeyAccel_Name_x86( ItemName , KeyCode , CtrlFlag , AltFlag , ShiftFlag );
			}
			else
			{
				return dx_AddKeyAccel_Name_x64( ItemName , KeyCode , CtrlFlag , AltFlag , ShiftFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddKeyAccel_ID")]
		extern static int  dx_AddKeyAccel_ID_x86( int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddKeyAccel_ID")]
		extern static int  dx_AddKeyAccel_ID_x64( int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag);
		public static int  AddKeyAccel_ID( int  ItemID, int  KeyCode, int  CtrlFlag, int  AltFlag, int  ShiftFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddKeyAccel_ID_x86( ItemID , KeyCode , CtrlFlag , AltFlag , ShiftFlag );
			}
			else
			{
				return dx_AddKeyAccel_ID_x64( ItemID , KeyCode , CtrlFlag , AltFlag , ShiftFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClearKeyAccel")]
		extern static int  dx_ClearKeyAccel_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ClearKeyAccel")]
		extern static int  dx_ClearKeyAccel_x64( );
		public static int  ClearKeyAccel( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ClearKeyAccel_x86( );
			}
			else
			{
				return dx_ClearKeyAccel_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuItem")]
		extern static int  dx_AddMenuItem_x86( int  AddType, string  ItemName, int  ItemID, int  SeparatorFlag, string  NewItemName, int  NewItemID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddMenuItem")]
		extern static int  dx_AddMenuItem_x64( int  AddType, string  ItemName, int  ItemID, int  SeparatorFlag, string  NewItemName, int  NewItemID);
		public static int  AddMenuItem( int  AddType, string  ItemName, int  ItemID, int  SeparatorFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMenuItem_x86( AddType , ItemName , ItemID , SeparatorFlag , null , -1 );
			}
			else
			{
				return dx_AddMenuItem_x64( AddType , ItemName , ItemID , SeparatorFlag , null , -1 );
			}
		}
		public static int  AddMenuItem( int  AddType, string  ItemName, int  ItemID, int  SeparatorFlag, string  NewItemName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMenuItem_x86( AddType , ItemName , ItemID , SeparatorFlag , NewItemName , -1 );
			}
			else
			{
				return dx_AddMenuItem_x64( AddType , ItemName , ItemID , SeparatorFlag , NewItemName , -1 );
			}
		}
		public static int  AddMenuItem( int  AddType, string  ItemName, int  ItemID, int  SeparatorFlag, string  NewItemName, int  NewItemID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMenuItem_x86( AddType , ItemName , ItemID , SeparatorFlag , NewItemName , NewItemID );
			}
			else
			{
				return dx_AddMenuItem_x64( AddType , ItemName , ItemID , SeparatorFlag , NewItemName , NewItemID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMenuItem")]
		extern static int  dx_DeleteMenuItem_x86( string  ItemName, int  ItemID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteMenuItem")]
		extern static int  dx_DeleteMenuItem_x64( string  ItemName, int  ItemID);
		public static int  DeleteMenuItem( string  ItemName, int  ItemID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteMenuItem_x86( ItemName , ItemID );
			}
			else
			{
				return dx_DeleteMenuItem_x64( ItemName , ItemID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMenuItemSelect")]
		extern static int  dx_CheckMenuItemSelect_x86( string  ItemName, int  ItemID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckMenuItemSelect")]
		extern static int  dx_CheckMenuItemSelect_x64( string  ItemName, int  ItemID);
		public static int  CheckMenuItemSelect( string  ItemName, int  ItemID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckMenuItemSelect_x86( ItemName , ItemID );
			}
			else
			{
				return dx_CheckMenuItemSelect_x64( ItemName , ItemID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemEnable")]
		extern static int  dx_SetMenuItemEnable_x86( string  ItemName, int  ItemID, int  EnableFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMenuItemEnable")]
		extern static int  dx_SetMenuItemEnable_x64( string  ItemName, int  ItemID, int  EnableFlag);
		public static int  SetMenuItemEnable( string  ItemName, int  ItemID, int  EnableFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMenuItemEnable_x86( ItemName , ItemID , EnableFlag );
			}
			else
			{
				return dx_SetMenuItemEnable_x64( ItemName , ItemID , EnableFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemMark")]
		extern static int  dx_SetMenuItemMark_x86( string  ItemName, int  ItemID, int  Mark);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMenuItemMark")]
		extern static int  dx_SetMenuItemMark_x64( string  ItemName, int  ItemID, int  Mark);
		public static int  SetMenuItemMark( string  ItemName, int  ItemID, int  Mark)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMenuItemMark_x86( ItemName , ItemID , Mark );
			}
			else
			{
				return dx_SetMenuItemMark_x64( ItemName , ItemID , Mark );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMenuItemSelectAll")]
		extern static int  dx_CheckMenuItemSelectAll_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckMenuItemSelectAll")]
		extern static int  dx_CheckMenuItemSelectAll_x64( );
		public static int  CheckMenuItemSelectAll( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckMenuItemSelectAll_x86( );
			}
			else
			{
				return dx_CheckMenuItemSelectAll_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuItem_Name")]
		extern static int  dx_AddMenuItem_Name_x86( string  ParentItemName, string  NewItemName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddMenuItem_Name")]
		extern static int  dx_AddMenuItem_Name_x64( string  ParentItemName, string  NewItemName);
		public static int  AddMenuItem_Name( string  ParentItemName, string  NewItemName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMenuItem_Name_x86( ParentItemName , NewItemName );
			}
			else
			{
				return dx_AddMenuItem_Name_x64( ParentItemName , NewItemName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuLine_Name")]
		extern static int  dx_AddMenuLine_Name_x86( string  ParentItemName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddMenuLine_Name")]
		extern static int  dx_AddMenuLine_Name_x64( string  ParentItemName);
		public static int  AddMenuLine_Name( string  ParentItemName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMenuLine_Name_x86( ParentItemName );
			}
			else
			{
				return dx_AddMenuLine_Name_x64( ParentItemName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InsertMenuItem_Name")]
		extern static int  dx_InsertMenuItem_Name_x86( string  ItemName, string  NewItemName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InsertMenuItem_Name")]
		extern static int  dx_InsertMenuItem_Name_x64( string  ItemName, string  NewItemName);
		public static int  InsertMenuItem_Name( string  ItemName, string  NewItemName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InsertMenuItem_Name_x86( ItemName , NewItemName );
			}
			else
			{
				return dx_InsertMenuItem_Name_x64( ItemName , NewItemName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InsertMenuLine_Name")]
		extern static int  dx_InsertMenuLine_Name_x86( string  ItemName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InsertMenuLine_Name")]
		extern static int  dx_InsertMenuLine_Name_x64( string  ItemName);
		public static int  InsertMenuLine_Name( string  ItemName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InsertMenuLine_Name_x86( ItemName );
			}
			else
			{
				return dx_InsertMenuLine_Name_x64( ItemName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMenuItem_Name")]
		extern static int  dx_DeleteMenuItem_Name_x86( string  ItemName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteMenuItem_Name")]
		extern static int  dx_DeleteMenuItem_Name_x64( string  ItemName);
		public static int  DeleteMenuItem_Name( string  ItemName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteMenuItem_Name_x86( ItemName );
			}
			else
			{
				return dx_DeleteMenuItem_Name_x64( ItemName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMenuItemSelect_Name")]
		extern static int  dx_CheckMenuItemSelect_Name_x86( string  ItemName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckMenuItemSelect_Name")]
		extern static int  dx_CheckMenuItemSelect_Name_x64( string  ItemName);
		public static int  CheckMenuItemSelect_Name( string  ItemName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckMenuItemSelect_Name_x86( ItemName );
			}
			else
			{
				return dx_CheckMenuItemSelect_Name_x64( ItemName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemEnable_Name")]
		extern static int  dx_SetMenuItemEnable_Name_x86( string  ItemName, int  EnableFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMenuItemEnable_Name")]
		extern static int  dx_SetMenuItemEnable_Name_x64( string  ItemName, int  EnableFlag);
		public static int  SetMenuItemEnable_Name( string  ItemName, int  EnableFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMenuItemEnable_Name_x86( ItemName , EnableFlag );
			}
			else
			{
				return dx_SetMenuItemEnable_Name_x64( ItemName , EnableFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemMark_Name")]
		extern static int  dx_SetMenuItemMark_Name_x86( string  ItemName, int  Mark);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMenuItemMark_Name")]
		extern static int  dx_SetMenuItemMark_Name_x64( string  ItemName, int  Mark);
		public static int  SetMenuItemMark_Name( string  ItemName, int  Mark)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMenuItemMark_Name_x86( ItemName , Mark );
			}
			else
			{
				return dx_SetMenuItemMark_Name_x64( ItemName , Mark );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuItem_ID")]
		extern static int  dx_AddMenuItem_ID_x86( int  ParentItemID, string  NewItemName, int  NewItemID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddMenuItem_ID")]
		extern static int  dx_AddMenuItem_ID_x64( int  ParentItemID, string  NewItemName, int  NewItemID);
		public static int  AddMenuItem_ID( int  ParentItemID, string  NewItemName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMenuItem_ID_x86( ParentItemID , NewItemName , -1 );
			}
			else
			{
				return dx_AddMenuItem_ID_x64( ParentItemID , NewItemName , -1 );
			}
		}
		public static int  AddMenuItem_ID( int  ParentItemID, string  NewItemName, int  NewItemID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMenuItem_ID_x86( ParentItemID , NewItemName , NewItemID );
			}
			else
			{
				return dx_AddMenuItem_ID_x64( ParentItemID , NewItemName , NewItemID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMenuLine_ID")]
		extern static int  dx_AddMenuLine_ID_x86( int  ParentItemID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddMenuLine_ID")]
		extern static int  dx_AddMenuLine_ID_x64( int  ParentItemID);
		public static int  AddMenuLine_ID( int  ParentItemID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMenuLine_ID_x86( ParentItemID );
			}
			else
			{
				return dx_AddMenuLine_ID_x64( ParentItemID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InsertMenuItem_ID")]
		extern static int  dx_InsertMenuItem_ID_x86( int  ItemID, int  NewItemID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InsertMenuItem_ID")]
		extern static int  dx_InsertMenuItem_ID_x64( int  ItemID, int  NewItemID);
		public static int  InsertMenuItem_ID( int  ItemID, int  NewItemID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InsertMenuItem_ID_x86( ItemID , NewItemID );
			}
			else
			{
				return dx_InsertMenuItem_ID_x64( ItemID , NewItemID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InsertMenuLine_ID")]
		extern static int  dx_InsertMenuLine_ID_x86( int  ItemID, int  NewItemID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InsertMenuLine_ID")]
		extern static int  dx_InsertMenuLine_ID_x64( int  ItemID, int  NewItemID);
		public static int  InsertMenuLine_ID( int  ItemID, int  NewItemID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InsertMenuLine_ID_x86( ItemID , NewItemID );
			}
			else
			{
				return dx_InsertMenuLine_ID_x64( ItemID , NewItemID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMenuItem_ID")]
		extern static int  dx_DeleteMenuItem_ID_x86( int  ItemID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteMenuItem_ID")]
		extern static int  dx_DeleteMenuItem_ID_x64( int  ItemID);
		public static int  DeleteMenuItem_ID( int  ItemID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteMenuItem_ID_x86( ItemID );
			}
			else
			{
				return dx_DeleteMenuItem_ID_x64( ItemID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMenuItemSelect_ID")]
		extern static int  dx_CheckMenuItemSelect_ID_x86( int  ItemID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckMenuItemSelect_ID")]
		extern static int  dx_CheckMenuItemSelect_ID_x64( int  ItemID);
		public static int  CheckMenuItemSelect_ID( int  ItemID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckMenuItemSelect_ID_x86( ItemID );
			}
			else
			{
				return dx_CheckMenuItemSelect_ID_x64( ItemID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemEnable_ID")]
		extern static int  dx_SetMenuItemEnable_ID_x86( int  ItemID, int  EnableFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMenuItemEnable_ID")]
		extern static int  dx_SetMenuItemEnable_ID_x64( int  ItemID, int  EnableFlag);
		public static int  SetMenuItemEnable_ID( int  ItemID, int  EnableFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMenuItemEnable_ID_x86( ItemID , EnableFlag );
			}
			else
			{
				return dx_SetMenuItemEnable_ID_x64( ItemID , EnableFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMenuItemMark_ID")]
		extern static int  dx_SetMenuItemMark_ID_x86( int  ItemID, int  Mark);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMenuItemMark_ID")]
		extern static int  dx_SetMenuItemMark_ID_x64( int  ItemID, int  Mark);
		public static int  SetMenuItemMark_ID( int  ItemID, int  Mark)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMenuItemMark_ID_x86( ItemID , Mark );
			}
			else
			{
				return dx_SetMenuItemMark_ID_x64( ItemID , Mark );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMenuItemAll")]
		extern static int  dx_DeleteMenuItemAll_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteMenuItemAll")]
		extern static int  dx_DeleteMenuItemAll_x64( );
		public static int  DeleteMenuItemAll( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteMenuItemAll_x86( );
			}
			else
			{
				return dx_DeleteMenuItemAll_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClearMenuItemSelect")]
		extern static int  dx_ClearMenuItemSelect_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ClearMenuItemSelect")]
		extern static int  dx_ClearMenuItemSelect_x64( );
		public static int  ClearMenuItemSelect( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ClearMenuItemSelect_x86( );
			}
			else
			{
				return dx_ClearMenuItemSelect_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMenuItemID")]
		extern static int  dx_GetMenuItemID_x86( string  ItemName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMenuItemID")]
		extern static int  dx_GetMenuItemID_x64( string  ItemName);
		public static int  GetMenuItemID( string  ItemName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMenuItemID_x86( ItemName );
			}
			else
			{
				return dx_GetMenuItemID_x64( ItemName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMenuItemName")]
		extern static int  dx_GetMenuItemName_x86( int  ItemID, System.Text.StringBuilder  NameBuffer);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMenuItemName")]
		extern static int  dx_GetMenuItemName_x64( int  ItemID, System.Text.StringBuilder  NameBuffer);
		public static int  GetMenuItemName( int  ItemID, System.Text.StringBuilder  NameBuffer)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMenuItemName_x86( ItemID , NameBuffer );
			}
			else
			{
				return dx_GetMenuItemName_x64( ItemID , NameBuffer );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadMenuResource")]
		extern static int  dx_LoadMenuResource_x86( int  MenuResourceID);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadMenuResource")]
		extern static int  dx_LoadMenuResource_x64( int  MenuResourceID);
		public static int  LoadMenuResource( int  MenuResourceID)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadMenuResource_x86( MenuResourceID );
			}
			else
			{
				return dx_LoadMenuResource_x64( MenuResourceID );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDisplayMenuFlag")]
		extern static int  dx_SetDisplayMenuFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDisplayMenuFlag")]
		extern static int  dx_SetDisplayMenuFlag_x64( int  Flag);
		public static int  SetDisplayMenuFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDisplayMenuFlag_x86( Flag );
			}
			else
			{
				return dx_SetDisplayMenuFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDisplayMenuFlag")]
		extern static int  dx_GetDisplayMenuFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDisplayMenuFlag")]
		extern static int  dx_GetDisplayMenuFlag_x64( );
		public static int  GetDisplayMenuFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDisplayMenuFlag_x86( );
			}
			else
			{
				return dx_GetDisplayMenuFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseMenuFlag")]
		extern static int  dx_GetUseMenuFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseMenuFlag")]
		extern static int  dx_GetUseMenuFlag_x64( );
		public static int  GetUseMenuFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseMenuFlag_x86( );
			}
			else
			{
				return dx_GetUseMenuFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetAutoMenuDisplayFlag")]
		extern static int  dx_SetAutoMenuDisplayFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetAutoMenuDisplayFlag")]
		extern static int  dx_SetAutoMenuDisplayFlag_x64( int  Flag);
		public static int  SetAutoMenuDisplayFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetAutoMenuDisplayFlag_x86( Flag );
			}
			else
			{
				return dx_SetAutoMenuDisplayFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMouseDispFlag")]
		extern static int  dx_SetMouseDispFlag_x86( int  DispFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMouseDispFlag")]
		extern static int  dx_SetMouseDispFlag_x64( int  DispFlag);
		public static int  SetMouseDispFlag( int  DispFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMouseDispFlag_x86( DispFlag );
			}
			else
			{
				return dx_SetMouseDispFlag_x64( DispFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMousePoint")]
		extern static int  dx_GetMousePoint_x86( out int  XBuf, out int  YBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMousePoint")]
		extern static int  dx_GetMousePoint_x64( out int  XBuf, out int  YBuf);
		public static int  GetMousePoint( out int  XBuf, out int  YBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMousePoint_x86( out XBuf , out YBuf );
			}
			else
			{
				return dx_GetMousePoint_x64( out XBuf , out YBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMousePoint")]
		extern static int  dx_SetMousePoint_x86( int  PointX, int  PointY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMousePoint")]
		extern static int  dx_SetMousePoint_x64( int  PointX, int  PointY);
		public static int  SetMousePoint( int  PointX, int  PointY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMousePoint_x86( PointX , PointY );
			}
			else
			{
				return dx_SetMousePoint_x64( PointX , PointY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseInput")]
		extern static int  dx_GetMouseInput_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMouseInput")]
		extern static int  dx_GetMouseInput_x64( );
		public static int  GetMouseInput( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseInput_x86( );
			}
			else
			{
				return dx_GetMouseInput_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseWheelRotVol")]
		extern static int  dx_GetMouseWheelRotVol_x86( int  CounterReset);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMouseWheelRotVol")]
		extern static int  dx_GetMouseWheelRotVol_x64( int  CounterReset);
		public static int  GetMouseWheelRotVol( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseWheelRotVol_x86( TRUE );
			}
			else
			{
				return dx_GetMouseWheelRotVol_x64( TRUE );
			}
		}
		public static int  GetMouseWheelRotVol( int  CounterReset)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseWheelRotVol_x86( CounterReset );
			}
			else
			{
				return dx_GetMouseWheelRotVol_x64( CounterReset );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseHWheelRotVol")]
		extern static int  dx_GetMouseHWheelRotVol_x86( int  CounterReset);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMouseHWheelRotVol")]
		extern static int  dx_GetMouseHWheelRotVol_x64( int  CounterReset);
		public static int  GetMouseHWheelRotVol( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseHWheelRotVol_x86( TRUE );
			}
			else
			{
				return dx_GetMouseHWheelRotVol_x64( TRUE );
			}
		}
		public static int  GetMouseHWheelRotVol( int  CounterReset)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseHWheelRotVol_x86( CounterReset );
			}
			else
			{
				return dx_GetMouseHWheelRotVol_x64( CounterReset );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseWheelRotVolF")]
		extern static float  dx_GetMouseWheelRotVolF_x86( int  CounterReset);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMouseWheelRotVolF")]
		extern static float  dx_GetMouseWheelRotVolF_x64( int  CounterReset);
		public static float  GetMouseWheelRotVolF( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseWheelRotVolF_x86( TRUE );
			}
			else
			{
				return dx_GetMouseWheelRotVolF_x64( TRUE );
			}
		}
		public static float  GetMouseWheelRotVolF( int  CounterReset)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseWheelRotVolF_x86( CounterReset );
			}
			else
			{
				return dx_GetMouseWheelRotVolF_x64( CounterReset );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseHWheelRotVolF")]
		extern static float  dx_GetMouseHWheelRotVolF_x86( int  CounterReset);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMouseHWheelRotVolF")]
		extern static float  dx_GetMouseHWheelRotVolF_x64( int  CounterReset);
		public static float  GetMouseHWheelRotVolF( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseHWheelRotVolF_x86( TRUE );
			}
			else
			{
				return dx_GetMouseHWheelRotVolF_x64( TRUE );
			}
		}
		public static float  GetMouseHWheelRotVolF( int  CounterReset)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseHWheelRotVolF_x86( CounterReset );
			}
			else
			{
				return dx_GetMouseHWheelRotVolF_x64( CounterReset );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMouseInputLog")]
		extern static int  dx_GetMouseInputLog_x86( out int  Button, out int  ClickX, out int  ClickY, int  LogDelete);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMouseInputLog")]
		extern static int  dx_GetMouseInputLog_x64( out int  Button, out int  ClickX, out int  ClickY, int  LogDelete);
		public static int  GetMouseInputLog( out int  Button, out int  ClickX, out int  ClickY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseInputLog_x86( out Button , out ClickX , out ClickY , TRUE );
			}
			else
			{
				return dx_GetMouseInputLog_x64( out Button , out ClickX , out ClickY , TRUE );
			}
		}
		public static int  GetMouseInputLog( out int  Button, out int  ClickX, out int  ClickY, int  LogDelete)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMouseInputLog_x86( out Button , out ClickX , out ClickY , LogDelete );
			}
			else
			{
				return dx_GetMouseInputLog_x64( out Button , out ClickX , out ClickY , LogDelete );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DxAlloc")]
		extern unsafe static void *  dx_DxAlloc_x86( uint  AllocSize, string  File, int  Line);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxAlloc")]
		extern unsafe static void *  dx_DxAlloc_x64( uint  AllocSize, string  File, int  Line);
		public unsafe static void *  DxAlloc( uint  AllocSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxAlloc_x86( AllocSize , null , -1 );
			}
			else
			{
				return dx_DxAlloc_x64( AllocSize , null , -1 );
			}
		}
		public unsafe static void *  DxAlloc( uint  AllocSize, string  File)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxAlloc_x86( AllocSize , File , -1 );
			}
			else
			{
				return dx_DxAlloc_x64( AllocSize , File , -1 );
			}
		}
		public unsafe static void *  DxAlloc( uint  AllocSize, string  File, int  Line)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxAlloc_x86( AllocSize , File , Line );
			}
			else
			{
				return dx_DxAlloc_x64( AllocSize , File , Line );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DxCalloc")]
		extern unsafe static void *  dx_DxCalloc_x86( uint  AllocSize, string  File, int  Line);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxCalloc")]
		extern unsafe static void *  dx_DxCalloc_x64( uint  AllocSize, string  File, int  Line);
		public unsafe static void *  DxCalloc( uint  AllocSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxCalloc_x86( AllocSize , null , -1 );
			}
			else
			{
				return dx_DxCalloc_x64( AllocSize , null , -1 );
			}
		}
		public unsafe static void *  DxCalloc( uint  AllocSize, string  File)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxCalloc_x86( AllocSize , File , -1 );
			}
			else
			{
				return dx_DxCalloc_x64( AllocSize , File , -1 );
			}
		}
		public unsafe static void *  DxCalloc( uint  AllocSize, string  File, int  Line)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxCalloc_x86( AllocSize , File , Line );
			}
			else
			{
				return dx_DxCalloc_x64( AllocSize , File , Line );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DxRealloc")]
		extern unsafe static void *  dx_DxRealloc_x86( void *  Memory, uint  AllocSize, string  File, int  Line);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxRealloc")]
		extern unsafe static void *  dx_DxRealloc_x64( void *  Memory, uint  AllocSize, string  File, int  Line);
		public unsafe static void *  DxRealloc( void *  Memory, uint  AllocSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxRealloc_x86( Memory , AllocSize , null , -1 );
			}
			else
			{
				return dx_DxRealloc_x64( Memory , AllocSize , null , -1 );
			}
		}
		public unsafe static void *  DxRealloc( void *  Memory, uint  AllocSize, string  File)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxRealloc_x86( Memory , AllocSize , File , -1 );
			}
			else
			{
				return dx_DxRealloc_x64( Memory , AllocSize , File , -1 );
			}
		}
		public unsafe static void *  DxRealloc( void *  Memory, uint  AllocSize, string  File, int  Line)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxRealloc_x86( Memory , AllocSize , File , Line );
			}
			else
			{
				return dx_DxRealloc_x64( Memory , AllocSize , File , Line );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DxFree")]
		extern unsafe static void  dx_DxFree_x86( void *  Memory);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxFree")]
		extern unsafe static void  dx_DxFree_x64( void *  Memory);
		public unsafe static void  DxFree( void *  Memory)
		{
			if( System.IntPtr.Size == 4 )
			{
				dx_DxFree_x86( Memory );
			}
			else
			{
				dx_DxFree_x64( Memory );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_DxSetAllocSizeTrap")]
		extern static uint  dx_DxSetAllocSizeTrap_x86( uint  Size);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxSetAllocSizeTrap")]
		extern static uint  dx_DxSetAllocSizeTrap_x64( uint  Size);
		public static uint  DxSetAllocSizeTrap( uint  Size)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxSetAllocSizeTrap_x86( Size );
			}
			else
			{
				return dx_DxSetAllocSizeTrap_x64( Size );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxSetAllocPrintFlag")]
		extern static int  dx_DxSetAllocPrintFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxSetAllocPrintFlag")]
		extern static int  dx_DxSetAllocPrintFlag_x64( int  Flag);
		public static int  DxSetAllocPrintFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxSetAllocPrintFlag_x86( Flag );
			}
			else
			{
				return dx_DxSetAllocPrintFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxGetAllocSize")]
		extern static uint  dx_DxGetAllocSize_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxGetAllocSize")]
		extern static uint  dx_DxGetAllocSize_x64( );
		public static uint  DxGetAllocSize( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxGetAllocSize_x86( );
			}
			else
			{
				return dx_DxGetAllocSize_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxGetAllocNum")]
		extern static int  dx_DxGetAllocNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxGetAllocNum")]
		extern static int  dx_DxGetAllocNum_x64( );
		public static int  DxGetAllocNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxGetAllocNum_x86( );
			}
			else
			{
				return dx_DxGetAllocNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxDumpAlloc")]
		extern static void  dx_DxDumpAlloc_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxDumpAlloc")]
		extern static void  dx_DxDumpAlloc_x64( );
		public static void  DxDumpAlloc( )
		{
			if( System.IntPtr.Size == 4 )
			{
				dx_DxDumpAlloc_x86( );
			}
			else
			{
				dx_DxDumpAlloc_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxErrorCheckAlloc")]
		extern static int  dx_DxErrorCheckAlloc_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxErrorCheckAlloc")]
		extern static int  dx_DxErrorCheckAlloc_x64( );
		public static int  DxErrorCheckAlloc( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxErrorCheckAlloc_x86( );
			}
			else
			{
				return dx_DxErrorCheckAlloc_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxSetAllocSizeOutFlag")]
		extern static int  dx_DxSetAllocSizeOutFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxSetAllocSizeOutFlag")]
		extern static int  dx_DxSetAllocSizeOutFlag_x64( int  Flag);
		public static int  DxSetAllocSizeOutFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxSetAllocSizeOutFlag_x86( Flag );
			}
			else
			{
				return dx_DxSetAllocSizeOutFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DxSetAllocMemoryErrorCheckFlag")]
		extern static int  dx_DxSetAllocMemoryErrorCheckFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DxSetAllocMemoryErrorCheckFlag")]
		extern static int  dx_DxSetAllocMemoryErrorCheckFlag_x64( int  Flag);
		public static int  DxSetAllocMemoryErrorCheckFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DxSetAllocMemoryErrorCheckFlag_x86( Flag );
			}
			else
			{
				return dx_DxSetAllocMemoryErrorCheckFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessNetMessage")]
		extern static int  dx_ProcessNetMessage_x86( int  RunReleaseProcess);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ProcessNetMessage")]
		extern static int  dx_ProcessNetMessage_x64( int  RunReleaseProcess);
		public static int  ProcessNetMessage( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ProcessNetMessage_x86( FALSE );
			}
			else
			{
				return dx_ProcessNetMessage_x64( FALSE );
			}
		}
		public static int  ProcessNetMessage( int  RunReleaseProcess)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ProcessNetMessage_x86( RunReleaseProcess );
			}
			else
			{
				return dx_ProcessNetMessage_x64( RunReleaseProcess );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetHostIPbyName")]
		extern unsafe static int  dx_GetHostIPbyName_x86( string  HostName, IPDATA *  IPDataBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetHostIPbyName")]
		extern unsafe static int  dx_GetHostIPbyName_x64( string  HostName, IPDATA *  IPDataBuf);
		public unsafe static int  GetHostIPbyName( string  HostName, IPDATA *  IPDataBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetHostIPbyName_x86( HostName , IPDataBuf );
			}
			else
			{
				return dx_GetHostIPbyName_x64( HostName , IPDataBuf );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetHostIPbyName_IPv6")]
		extern unsafe static int  dx_GetHostIPbyName_IPv6_x86( string  HostName, IPDATA_IPv6 *  IPDataBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetHostIPbyName_IPv6")]
		extern unsafe static int  dx_GetHostIPbyName_IPv6_x64( string  HostName, IPDATA_IPv6 *  IPDataBuf);
		public unsafe static int  GetHostIPbyName_IPv6( string  HostName, IPDATA_IPv6 *  IPDataBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetHostIPbyName_IPv6_x86( HostName , IPDataBuf );
			}
			else
			{
				return dx_GetHostIPbyName_IPv6_x64( HostName , IPDataBuf );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_ConnectNetWork")]
		extern static int  dx_ConnectNetWork_x86( IPDATA  IPData, int  Port);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConnectNetWork")]
		extern static int  dx_ConnectNetWork_x64( IPDATA  IPData, int  Port);
		public static int  ConnectNetWork( IPDATA  IPData)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConnectNetWork_x86( IPData , -1 );
			}
			else
			{
				return dx_ConnectNetWork_x64( IPData , -1 );
			}
		}
		public static int  ConnectNetWork( IPDATA  IPData, int  Port)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConnectNetWork_x86( IPData , Port );
			}
			else
			{
				return dx_ConnectNetWork_x64( IPData , Port );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConnectNetWork_IPv6")]
		extern static int  dx_ConnectNetWork_IPv6_x86( IPDATA_IPv6  IPData, int  Port);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConnectNetWork_IPv6")]
		extern static int  dx_ConnectNetWork_IPv6_x64( IPDATA_IPv6  IPData, int  Port);
		public static int  ConnectNetWork_IPv6( IPDATA_IPv6  IPData)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConnectNetWork_IPv6_x86( IPData , -1 );
			}
			else
			{
				return dx_ConnectNetWork_IPv6_x64( IPData , -1 );
			}
		}
		public static int  ConnectNetWork_IPv6( IPDATA_IPv6  IPData, int  Port)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConnectNetWork_IPv6_x86( IPData , Port );
			}
			else
			{
				return dx_ConnectNetWork_IPv6_x64( IPData , Port );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConnectNetWork_ASync")]
		extern static int  dx_ConnectNetWork_ASync_x86( IPDATA  IPData, int  Port);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConnectNetWork_ASync")]
		extern static int  dx_ConnectNetWork_ASync_x64( IPDATA  IPData, int  Port);
		public static int  ConnectNetWork_ASync( IPDATA  IPData)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConnectNetWork_ASync_x86( IPData , -1 );
			}
			else
			{
				return dx_ConnectNetWork_ASync_x64( IPData , -1 );
			}
		}
		public static int  ConnectNetWork_ASync( IPDATA  IPData, int  Port)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConnectNetWork_ASync_x86( IPData , Port );
			}
			else
			{
				return dx_ConnectNetWork_ASync_x64( IPData , Port );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConnectNetWork_IPv6_ASync")]
		extern static int  dx_ConnectNetWork_IPv6_ASync_x86( IPDATA_IPv6  IPData, int  Port);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConnectNetWork_IPv6_ASync")]
		extern static int  dx_ConnectNetWork_IPv6_ASync_x64( IPDATA_IPv6  IPData, int  Port);
		public static int  ConnectNetWork_IPv6_ASync( IPDATA_IPv6  IPData)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConnectNetWork_IPv6_ASync_x86( IPData , -1 );
			}
			else
			{
				return dx_ConnectNetWork_IPv6_ASync_x64( IPData , -1 );
			}
		}
		public static int  ConnectNetWork_IPv6_ASync( IPDATA_IPv6  IPData, int  Port)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConnectNetWork_IPv6_ASync_x86( IPData , Port );
			}
			else
			{
				return dx_ConnectNetWork_IPv6_ASync_x64( IPData , Port );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PreparationListenNetWork")]
		extern static int  dx_PreparationListenNetWork_x86( int  Port);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PreparationListenNetWork")]
		extern static int  dx_PreparationListenNetWork_x64( int  Port);
		public static int  PreparationListenNetWork( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PreparationListenNetWork_x86( -1 );
			}
			else
			{
				return dx_PreparationListenNetWork_x64( -1 );
			}
		}
		public static int  PreparationListenNetWork( int  Port)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PreparationListenNetWork_x86( Port );
			}
			else
			{
				return dx_PreparationListenNetWork_x64( Port );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PreparationListenNetWork_IPv6")]
		extern static int  dx_PreparationListenNetWork_IPv6_x86( int  Port);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PreparationListenNetWork_IPv6")]
		extern static int  dx_PreparationListenNetWork_IPv6_x64( int  Port);
		public static int  PreparationListenNetWork_IPv6( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PreparationListenNetWork_IPv6_x86( -1 );
			}
			else
			{
				return dx_PreparationListenNetWork_IPv6_x64( -1 );
			}
		}
		public static int  PreparationListenNetWork_IPv6( int  Port)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PreparationListenNetWork_IPv6_x86( Port );
			}
			else
			{
				return dx_PreparationListenNetWork_IPv6_x64( Port );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopListenNetWork")]
		extern static int  dx_StopListenNetWork_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StopListenNetWork")]
		extern static int  dx_StopListenNetWork_x64( );
		public static int  StopListenNetWork( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StopListenNetWork_x86( );
			}
			else
			{
				return dx_StopListenNetWork_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CloseNetWork")]
		extern static int  dx_CloseNetWork_x86( int  NetHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CloseNetWork")]
		extern static int  dx_CloseNetWork_x64( int  NetHandle);
		public static int  CloseNetWork( int  NetHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CloseNetWork_x86( NetHandle );
			}
			else
			{
				return dx_CloseNetWork_x64( NetHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkAcceptState")]
		extern static int  dx_GetNetWorkAcceptState_x86( int  NetHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNetWorkAcceptState")]
		extern static int  dx_GetNetWorkAcceptState_x64( int  NetHandle);
		public static int  GetNetWorkAcceptState( int  NetHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNetWorkAcceptState_x86( NetHandle );
			}
			else
			{
				return dx_GetNetWorkAcceptState_x64( NetHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkDataLength")]
		extern static int  dx_GetNetWorkDataLength_x86( int  NetHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNetWorkDataLength")]
		extern static int  dx_GetNetWorkDataLength_x64( int  NetHandle);
		public static int  GetNetWorkDataLength( int  NetHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNetWorkDataLength_x86( NetHandle );
			}
			else
			{
				return dx_GetNetWorkDataLength_x64( NetHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkSendDataLength")]
		extern static int  dx_GetNetWorkSendDataLength_x86( int  NetHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNetWorkSendDataLength")]
		extern static int  dx_GetNetWorkSendDataLength_x64( int  NetHandle);
		public static int  GetNetWorkSendDataLength( int  NetHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNetWorkSendDataLength_x86( NetHandle );
			}
			else
			{
				return dx_GetNetWorkSendDataLength_x64( NetHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNewAcceptNetWork")]
		extern static int  dx_GetNewAcceptNetWork_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNewAcceptNetWork")]
		extern static int  dx_GetNewAcceptNetWork_x64( );
		public static int  GetNewAcceptNetWork( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNewAcceptNetWork_x86( );
			}
			else
			{
				return dx_GetNewAcceptNetWork_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLostNetWork")]
		extern static int  dx_GetLostNetWork_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLostNetWork")]
		extern static int  dx_GetLostNetWork_x64( );
		public static int  GetLostNetWork( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLostNetWork_x86( );
			}
			else
			{
				return dx_GetLostNetWork_x64( );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkIP")]
		extern unsafe static int  dx_GetNetWorkIP_x86( int  NetHandle, IPDATA *  IpBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNetWorkIP")]
		extern unsafe static int  dx_GetNetWorkIP_x64( int  NetHandle, IPDATA *  IpBuf);
		public unsafe static int  GetNetWorkIP( int  NetHandle, IPDATA *  IpBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNetWorkIP_x86( NetHandle , IpBuf );
			}
			else
			{
				return dx_GetNetWorkIP_x64( NetHandle , IpBuf );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkIP_IPv6")]
		extern unsafe static int  dx_GetNetWorkIP_IPv6_x86( int  NetHandle, IPDATA_IPv6 *  IpBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNetWorkIP_IPv6")]
		extern unsafe static int  dx_GetNetWorkIP_IPv6_x64( int  NetHandle, IPDATA_IPv6 *  IpBuf);
		public unsafe static int  GetNetWorkIP_IPv6( int  NetHandle, IPDATA_IPv6 *  IpBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNetWorkIP_IPv6_x86( NetHandle , IpBuf );
			}
			else
			{
				return dx_GetNetWorkIP_IPv6_x64( NetHandle , IpBuf );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetMyIPAddress")]
		extern unsafe static int  dx_GetMyIPAddress_x86( IPDATA *  IpBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMyIPAddress")]
		extern unsafe static int  dx_GetMyIPAddress_x64( IPDATA *  IpBuf);
		public unsafe static int  GetMyIPAddress( IPDATA *  IpBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMyIPAddress_x86( IpBuf );
			}
			else
			{
				return dx_GetMyIPAddress_x64( IpBuf );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_SetConnectTimeOutWait")]
		extern static int  dx_SetConnectTimeOutWait_x86( int  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetConnectTimeOutWait")]
		extern static int  dx_SetConnectTimeOutWait_x64( int  Time);
		public static int  SetConnectTimeOutWait( int  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetConnectTimeOutWait_x86( Time );
			}
			else
			{
				return dx_SetConnectTimeOutWait_x64( Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDXNetWorkProtocol")]
		extern static int  dx_SetUseDXNetWorkProtocol_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseDXNetWorkProtocol")]
		extern static int  dx_SetUseDXNetWorkProtocol_x64( int  Flag);
		public static int  SetUseDXNetWorkProtocol( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseDXNetWorkProtocol_x86( Flag );
			}
			else
			{
				return dx_SetUseDXNetWorkProtocol_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseDXNetWorkProtocol")]
		extern static int  dx_GetUseDXNetWorkProtocol_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseDXNetWorkProtocol")]
		extern static int  dx_GetUseDXNetWorkProtocol_x64( );
		public static int  GetUseDXNetWorkProtocol( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseDXNetWorkProtocol_x86( );
			}
			else
			{
				return dx_GetUseDXNetWorkProtocol_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDXProtocol")]
		extern static int  dx_SetUseDXProtocol_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseDXProtocol")]
		extern static int  dx_SetUseDXProtocol_x64( int  Flag);
		public static int  SetUseDXProtocol( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseDXProtocol_x86( Flag );
			}
			else
			{
				return dx_SetUseDXProtocol_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseDXProtocol")]
		extern static int  dx_GetUseDXProtocol_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseDXProtocol")]
		extern static int  dx_GetUseDXProtocol_x64( );
		public static int  GetUseDXProtocol( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseDXProtocol_x86( );
			}
			else
			{
				return dx_GetUseDXProtocol_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNetWorkCloseAfterLostFlag")]
		extern static int  dx_SetNetWorkCloseAfterLostFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetNetWorkCloseAfterLostFlag")]
		extern static int  dx_SetNetWorkCloseAfterLostFlag_x64( int  Flag);
		public static int  SetNetWorkCloseAfterLostFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetNetWorkCloseAfterLostFlag_x86( Flag );
			}
			else
			{
				return dx_SetNetWorkCloseAfterLostFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetNetWorkCloseAfterLostFlag")]
		extern static int  dx_GetNetWorkCloseAfterLostFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetNetWorkCloseAfterLostFlag")]
		extern static int  dx_GetNetWorkCloseAfterLostFlag_x64( );
		public static int  GetNetWorkCloseAfterLostFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetNetWorkCloseAfterLostFlag_x86( );
			}
			else
			{
				return dx_GetNetWorkCloseAfterLostFlag_x64( );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecv")]
		extern unsafe static int  dx_NetWorkRecv_x86( int  NetHandle, void *  Buffer, int  Length);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_NetWorkRecv")]
		extern unsafe static int  dx_NetWorkRecv_x64( int  NetHandle, void *  Buffer, int  Length);
		public unsafe static int  NetWorkRecv( int  NetHandle, void *  Buffer, int  Length)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_NetWorkRecv_x86( NetHandle , Buffer , Length );
			}
			else
			{
				return dx_NetWorkRecv_x64( NetHandle , Buffer , Length );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecvToPeek")]
		extern unsafe static int  dx_NetWorkRecvToPeek_x86( int  NetHandle, void *  Buffer, int  Length);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_NetWorkRecvToPeek")]
		extern unsafe static int  dx_NetWorkRecvToPeek_x64( int  NetHandle, void *  Buffer, int  Length);
		public unsafe static int  NetWorkRecvToPeek( int  NetHandle, void *  Buffer, int  Length)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_NetWorkRecvToPeek_x86( NetHandle , Buffer , Length );
			}
			else
			{
				return dx_NetWorkRecvToPeek_x64( NetHandle , Buffer , Length );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecvBufferClear")]
		extern static int  dx_NetWorkRecvBufferClear_x86( int  NetHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_NetWorkRecvBufferClear")]
		extern static int  dx_NetWorkRecvBufferClear_x64( int  NetHandle);
		public static int  NetWorkRecvBufferClear( int  NetHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_NetWorkRecvBufferClear_x86( NetHandle );
			}
			else
			{
				return dx_NetWorkRecvBufferClear_x64( NetHandle );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkSend")]
		extern unsafe static int  dx_NetWorkSend_x86( int  NetHandle, void *  Buffer, int  Length);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_NetWorkSend")]
		extern unsafe static int  dx_NetWorkSend_x64( int  NetHandle, void *  Buffer, int  Length);
		public unsafe static int  NetWorkSend( int  NetHandle, void *  Buffer, int  Length)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_NetWorkSend_x86( NetHandle , Buffer , Length );
			}
			else
			{
				return dx_NetWorkSend_x64( NetHandle , Buffer , Length );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_MakeUDPSocket")]
		extern static int  dx_MakeUDPSocket_x86( int  RecvPort);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeUDPSocket")]
		extern static int  dx_MakeUDPSocket_x64( int  RecvPort);
		public static int  MakeUDPSocket( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeUDPSocket_x86( -1 );
			}
			else
			{
				return dx_MakeUDPSocket_x64( -1 );
			}
		}
		public static int  MakeUDPSocket( int  RecvPort)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeUDPSocket_x86( RecvPort );
			}
			else
			{
				return dx_MakeUDPSocket_x64( RecvPort );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeUDPSocket_IPv6")]
		extern static int  dx_MakeUDPSocket_IPv6_x86( int  RecvPort);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeUDPSocket_IPv6")]
		extern static int  dx_MakeUDPSocket_IPv6_x64( int  RecvPort);
		public static int  MakeUDPSocket_IPv6( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeUDPSocket_IPv6_x86( -1 );
			}
			else
			{
				return dx_MakeUDPSocket_IPv6_x64( -1 );
			}
		}
		public static int  MakeUDPSocket_IPv6( int  RecvPort)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeUDPSocket_IPv6_x86( RecvPort );
			}
			else
			{
				return dx_MakeUDPSocket_IPv6_x64( RecvPort );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteUDPSocket")]
		extern static int  dx_DeleteUDPSocket_x86( int  NetUDPHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteUDPSocket")]
		extern static int  dx_DeleteUDPSocket_x64( int  NetUDPHandle);
		public static int  DeleteUDPSocket( int  NetUDPHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteUDPSocket_x86( NetUDPHandle );
			}
			else
			{
				return dx_DeleteUDPSocket_x64( NetUDPHandle );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkSendUDP")]
		extern unsafe static int  dx_NetWorkSendUDP_x86( int  NetUDPHandle, IPDATA  SendIP, int  SendPort, void *  Buffer, int  Length);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_NetWorkSendUDP")]
		extern unsafe static int  dx_NetWorkSendUDP_x64( int  NetUDPHandle, IPDATA  SendIP, int  SendPort, void *  Buffer, int  Length);
		public unsafe static int  NetWorkSendUDP( int  NetUDPHandle, IPDATA  SendIP, int  SendPort, void *  Buffer, int  Length)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_NetWorkSendUDP_x86( NetUDPHandle , SendIP , SendPort , Buffer , Length );
			}
			else
			{
				return dx_NetWorkSendUDP_x64( NetUDPHandle , SendIP , SendPort , Buffer , Length );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkSendUDP_IPv6")]
		extern unsafe static int  dx_NetWorkSendUDP_IPv6_x86( int  NetUDPHandle, IPDATA_IPv6  SendIP, int  SendPort, void *  Buffer, int  Length);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_NetWorkSendUDP_IPv6")]
		extern unsafe static int  dx_NetWorkSendUDP_IPv6_x64( int  NetUDPHandle, IPDATA_IPv6  SendIP, int  SendPort, void *  Buffer, int  Length);
		public unsafe static int  NetWorkSendUDP_IPv6( int  NetUDPHandle, IPDATA_IPv6  SendIP, int  SendPort, void *  Buffer, int  Length)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_NetWorkSendUDP_IPv6_x86( NetUDPHandle , SendIP , SendPort , Buffer , Length );
			}
			else
			{
				return dx_NetWorkSendUDP_IPv6_x64( NetUDPHandle , SendIP , SendPort , Buffer , Length );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecvUDP")]
		extern unsafe static int  dx_NetWorkRecvUDP_x86( int  NetUDPHandle, IPDATA *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_NetWorkRecvUDP")]
		extern unsafe static int  dx_NetWorkRecvUDP_x64( int  NetUDPHandle, IPDATA *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek);
		public unsafe static int  NetWorkRecvUDP( int  NetUDPHandle, IPDATA *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_NetWorkRecvUDP_x86( NetUDPHandle , RecvIP , RecvPort , Buffer , Length , Peek );
			}
			else
			{
				return dx_NetWorkRecvUDP_x64( NetUDPHandle , RecvIP , RecvPort , Buffer , Length , Peek );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_NetWorkRecvUDP_IPv6")]
		extern unsafe static int  dx_NetWorkRecvUDP_IPv6_x86( int  NetUDPHandle, IPDATA_IPv6 *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_NetWorkRecvUDP_IPv6")]
		extern unsafe static int  dx_NetWorkRecvUDP_IPv6_x64( int  NetUDPHandle, IPDATA_IPv6 *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek);
		public unsafe static int  NetWorkRecvUDP_IPv6( int  NetUDPHandle, IPDATA_IPv6 *  RecvIP, int *  RecvPort, void *  Buffer, int  Length, int  Peek)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_NetWorkRecvUDP_IPv6_x86( NetUDPHandle , RecvIP , RecvPort , Buffer , Length , Peek );
			}
			else
			{
				return dx_NetWorkRecvUDP_IPv6_x64( NetUDPHandle , RecvIP , RecvPort , Buffer , Length , Peek );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_CheckNetWorkRecvUDP")]
		extern static int  dx_CheckNetWorkRecvUDP_x86( int  NetUDPHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckNetWorkRecvUDP")]
		extern static int  dx_CheckNetWorkRecvUDP_x64( int  NetUDPHandle);
		public static int  CheckNetWorkRecvUDP( int  NetUDPHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckNetWorkRecvUDP_x86( NetUDPHandle );
			}
			else
			{
				return dx_CheckNetWorkRecvUDP_x64( NetUDPHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StockInputChar")]
		extern static int  dx_StockInputChar_x86( char  CharCode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StockInputChar")]
		extern static int  dx_StockInputChar_x64( char  CharCode);
		public static int  StockInputChar( char  CharCode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StockInputChar_x86( CharCode );
			}
			else
			{
				return dx_StockInputChar_x64( CharCode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClearInputCharBuf")]
		extern static int  dx_ClearInputCharBuf_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ClearInputCharBuf")]
		extern static int  dx_ClearInputCharBuf_x64( );
		public static int  ClearInputCharBuf( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ClearInputCharBuf_x86( );
			}
			else
			{
				return dx_ClearInputCharBuf_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetOneChar")]
		extern static int  dx_GetOneChar_x86( System.Text.StringBuilder  CharBuffer, int  DeleteFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetOneChar")]
		extern static int  dx_GetOneChar_x64( System.Text.StringBuilder  CharBuffer, int  DeleteFlag);
		public static int  GetOneChar( System.Text.StringBuilder  CharBuffer, int  DeleteFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetOneChar_x86( CharBuffer , DeleteFlag );
			}
			else
			{
				return dx_GetOneChar_x64( CharBuffer , DeleteFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetOneCharWait")]
		extern static int  dx_GetOneCharWait_x86( System.Text.StringBuilder  CharBuffer, int  DeleteFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetOneCharWait")]
		extern static int  dx_GetOneCharWait_x64( System.Text.StringBuilder  CharBuffer, int  DeleteFlag);
		public static int  GetOneCharWait( System.Text.StringBuilder  CharBuffer, int  DeleteFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetOneCharWait_x86( CharBuffer , DeleteFlag );
			}
			else
			{
				return dx_GetOneCharWait_x64( CharBuffer , DeleteFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCtrlCodeCmp")]
		extern static int  dx_GetCtrlCodeCmp_x86( char  Char);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCtrlCodeCmp")]
		extern static int  dx_GetCtrlCodeCmp_x64( char  Char);
		public static int  GetCtrlCodeCmp( char  Char)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCtrlCodeCmp_x86( Char );
			}
			else
			{
				return dx_GetCtrlCodeCmp_x64( Char );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawIMEInputString")]
		extern static int  dx_DrawIMEInputString_x86( int  x, int  y, int  SelectStringNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawIMEInputString")]
		extern static int  dx_DrawIMEInputString_x64( int  x, int  y, int  SelectStringNum);
		public static int  DrawIMEInputString( int  x, int  y, int  SelectStringNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawIMEInputString_x86( x , y , SelectStringNum );
			}
			else
			{
				return dx_DrawIMEInputString_x64( x , y , SelectStringNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseIMEFlag")]
		extern static int  dx_SetUseIMEFlag_x86( int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseIMEFlag")]
		extern static int  dx_SetUseIMEFlag_x64( int  UseFlag);
		public static int  SetUseIMEFlag( int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseIMEFlag_x86( UseFlag );
			}
			else
			{
				return dx_SetUseIMEFlag_x64( UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetInputStringMaxLengthIMESync")]
		extern static int  dx_SetInputStringMaxLengthIMESync_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetInputStringMaxLengthIMESync")]
		extern static int  dx_SetInputStringMaxLengthIMESync_x64( int  Flag);
		public static int  SetInputStringMaxLengthIMESync( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetInputStringMaxLengthIMESync_x86( Flag );
			}
			else
			{
				return dx_SetInputStringMaxLengthIMESync_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetIMEInputStringMaxLength")]
		extern static int  dx_SetIMEInputStringMaxLength_x86( int  Length);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetIMEInputStringMaxLength")]
		extern static int  dx_SetIMEInputStringMaxLength_x64( int  Length);
		public static int  SetIMEInputStringMaxLength( int  Length)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetIMEInputStringMaxLength_x86( Length );
			}
			else
			{
				return dx_SetIMEInputStringMaxLength_x64( Length );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStringPoint")]
		extern static int  dx_GetStringPoint_x86( string  String, int  Point);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetStringPoint")]
		extern static int  dx_GetStringPoint_x64( string  String, int  Point);
		public static int  GetStringPoint( string  String, int  Point)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetStringPoint_x86( String , Point );
			}
			else
			{
				return dx_GetStringPoint_x64( String , Point );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStringPoint2")]
		extern static int  dx_GetStringPoint2_x86( string  String, int  Point);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetStringPoint2")]
		extern static int  dx_GetStringPoint2_x64( string  String, int  Point);
		public static int  GetStringPoint2( string  String, int  Point)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetStringPoint2_x86( String , Point );
			}
			else
			{
				return dx_GetStringPoint2_x64( String , Point );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawObtainsString")]
		extern static int  dx_DrawObtainsString_x86( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor, int  SelectStrEdgeColor, int  SelectStart, int  SelectEnd);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawObtainsString")]
		extern static int  dx_DrawObtainsString_x64( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor, int  SelectStrEdgeColor, int  SelectStart, int  SelectEnd);
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawObtainsString_x86( x , y , AddY , String , StrColor , 0 , -1 , -1 , 0 , -1 , -1 , -1 );
			}
			else
			{
				return dx_DrawObtainsString_x64( x , y , AddY , String , StrColor , 0 , -1 , -1 , 0 , -1 , -1 , -1 );
			}
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawObtainsString_x86( x , y , AddY , String , StrColor , StrEdgeColor , -1 , -1 , 0 , -1 , -1 , -1 );
			}
			else
			{
				return dx_DrawObtainsString_x64( x , y , AddY , String , StrColor , StrEdgeColor , -1 , -1 , 0 , -1 , -1 , -1 );
			}
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawObtainsString_x86( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , -1 , 0 , -1 , -1 , -1 );
			}
			else
			{
				return dx_DrawObtainsString_x64( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , -1 , 0 , -1 , -1 , -1 );
			}
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawObtainsString_x86( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , 0 , -1 , -1 , -1 );
			}
			else
			{
				return dx_DrawObtainsString_x64( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , 0 , -1 , -1 , -1 );
			}
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawObtainsString_x86( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , -1 , -1 , -1 );
			}
			else
			{
				return dx_DrawObtainsString_x64( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , -1 , -1 , -1 );
			}
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor, int  SelectStrEdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawObtainsString_x86( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , -1 , -1 );
			}
			else
			{
				return dx_DrawObtainsString_x64( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , -1 , -1 );
			}
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor, int  SelectStrEdgeColor, int  SelectStart)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawObtainsString_x86( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , -1 );
			}
			else
			{
				return dx_DrawObtainsString_x64( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , -1 );
			}
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, int  StrColor, int  StrEdgeColor, int  FontHandle, int  SelectBackColor, int  SelectStrColor, int  SelectStrEdgeColor, int  SelectStart, int  SelectEnd)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawObtainsString_x86( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , SelectEnd );
			}
			else
			{
				return dx_DrawObtainsString_x64( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , SelectEnd );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawObtainsBox")]
		extern static int  dx_DrawObtainsBox_x86( int  x1, int  y1, int  x2, int  y2, int  AddY, int  Color, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawObtainsBox")]
		extern static int  dx_DrawObtainsBox_x64( int  x1, int  y1, int  x2, int  y2, int  AddY, int  Color, int  FillFlag);
		public static int  DrawObtainsBox( int  x1, int  y1, int  x2, int  y2, int  AddY, int  Color, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawObtainsBox_x86( x1 , y1 , x2 , y2 , AddY , Color , FillFlag );
			}
			else
			{
				return dx_DrawObtainsBox_x64( x1 , y1 , x2 , y2 , AddY , Color , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InputStringToCustom")]
		extern static int  dx_InputStringToCustom_x86( int  x, int  y, int  BufLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag, int  DoubleCharOnlyFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InputStringToCustom")]
		extern static int  dx_InputStringToCustom_x64( int  x, int  y, int  BufLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag, int  DoubleCharOnlyFlag);
		public static int  InputStringToCustom( int  x, int  y, int  BufLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InputStringToCustom_x86( x , y , BufLength , StrBuffer , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag , FALSE );
			}
			else
			{
				return dx_InputStringToCustom_x64( x , y , BufLength , StrBuffer , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag , FALSE );
			}
		}
		public static int  InputStringToCustom( int  x, int  y, int  BufLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag, int  DoubleCharOnlyFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InputStringToCustom_x86( x , y , BufLength , StrBuffer , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag , DoubleCharOnlyFlag );
			}
			else
			{
				return dx_InputStringToCustom_x64( x , y , BufLength , StrBuffer , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag , DoubleCharOnlyFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_KeyInputString")]
		extern static int  dx_KeyInputString_x86( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_KeyInputString")]
		extern static int  dx_KeyInputString_x64( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag);
		public static int  KeyInputString( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_KeyInputString_x86( x , y , CharMaxLength , StrBuffer , CancelValidFlag );
			}
			else
			{
				return dx_KeyInputString_x64( x , y , CharMaxLength , StrBuffer , CancelValidFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_KeyInputSingleCharString")]
		extern static int  dx_KeyInputSingleCharString_x86( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_KeyInputSingleCharString")]
		extern static int  dx_KeyInputSingleCharString_x64( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag);
		public static int  KeyInputSingleCharString( int  x, int  y, int  CharMaxLength, System.Text.StringBuilder  StrBuffer, int  CancelValidFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_KeyInputSingleCharString_x86( x , y , CharMaxLength , StrBuffer , CancelValidFlag );
			}
			else
			{
				return dx_KeyInputSingleCharString_x64( x , y , CharMaxLength , StrBuffer , CancelValidFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_KeyInputNumber")]
		extern static int  dx_KeyInputNumber_x86( int  x, int  y, int  MaxNum, int  MinNum, int  CancelValidFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_KeyInputNumber")]
		extern static int  dx_KeyInputNumber_x64( int  x, int  y, int  MaxNum, int  MinNum, int  CancelValidFlag);
		public static int  KeyInputNumber( int  x, int  y, int  MaxNum, int  MinNum, int  CancelValidFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_KeyInputNumber_x86( x , y , MaxNum , MinNum , CancelValidFlag );
			}
			else
			{
				return dx_KeyInputNumber_x64( x , y , MaxNum , MinNum , CancelValidFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetIMEInputModeStr")]
		extern static int  dx_GetIMEInputModeStr_x86( System.Text.StringBuilder  GetBuffer);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetIMEInputModeStr")]
		extern static int  dx_GetIMEInputModeStr_x64( System.Text.StringBuilder  GetBuffer);
		public static int  GetIMEInputModeStr( System.Text.StringBuilder  GetBuffer)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetIMEInputModeStr_x86( GetBuffer );
			}
			else
			{
				return dx_GetIMEInputModeStr_x64( GetBuffer );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputStringFont")]
		extern static int  dx_SetKeyInputStringFont_x86( int  FontHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputStringFont")]
		extern static int  dx_SetKeyInputStringFont_x64( int  FontHandle);
		public static int  SetKeyInputStringFont( int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputStringFont_x86( FontHandle );
			}
			else
			{
				return dx_SetKeyInputStringFont_x64( FontHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawKeyInputModeString")]
		extern static int  dx_DrawKeyInputModeString_x86( int  x, int  y);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawKeyInputModeString")]
		extern static int  dx_DrawKeyInputModeString_x64( int  x, int  y);
		public static int  DrawKeyInputModeString( int  x, int  y)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawKeyInputModeString_x86( x , y );
			}
			else
			{
				return dx_DrawKeyInputModeString_x64( x , y );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitKeyInput")]
		extern static int  dx_InitKeyInput_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitKeyInput")]
		extern static int  dx_InitKeyInput_x64( );
		public static int  InitKeyInput( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitKeyInput_x86( );
			}
			else
			{
				return dx_InitKeyInput_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeKeyInput")]
		extern static int  dx_MakeKeyInput_x86( int  MaxStrLength, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag, int  DoubleCharOnlyFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeKeyInput")]
		extern static int  dx_MakeKeyInput_x64( int  MaxStrLength, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag, int  DoubleCharOnlyFlag);
		public static int  MakeKeyInput( int  MaxStrLength, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeKeyInput_x86( MaxStrLength , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag , FALSE );
			}
			else
			{
				return dx_MakeKeyInput_x64( MaxStrLength , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag , FALSE );
			}
		}
		public static int  MakeKeyInput( int  MaxStrLength, int  CancelValidFlag, int  SingleCharOnlyFlag, int  NumCharOnlyFlag, int  DoubleCharOnlyFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeKeyInput_x86( MaxStrLength , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag , DoubleCharOnlyFlag );
			}
			else
			{
				return dx_MakeKeyInput_x64( MaxStrLength , CancelValidFlag , SingleCharOnlyFlag , NumCharOnlyFlag , DoubleCharOnlyFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteKeyInput")]
		extern static int  dx_DeleteKeyInput_x86( int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteKeyInput")]
		extern static int  dx_DeleteKeyInput_x64( int  InputHandle);
		public static int  DeleteKeyInput( int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteKeyInput_x86( InputHandle );
			}
			else
			{
				return dx_DeleteKeyInput_x64( InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetActiveKeyInput")]
		extern static int  dx_SetActiveKeyInput_x86( int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetActiveKeyInput")]
		extern static int  dx_SetActiveKeyInput_x64( int  InputHandle);
		public static int  SetActiveKeyInput( int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetActiveKeyInput_x86( InputHandle );
			}
			else
			{
				return dx_SetActiveKeyInput_x64( InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetActiveKeyInput")]
		extern static int  dx_GetActiveKeyInput_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetActiveKeyInput")]
		extern static int  dx_GetActiveKeyInput_x64( );
		public static int  GetActiveKeyInput( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetActiveKeyInput_x86( );
			}
			else
			{
				return dx_GetActiveKeyInput_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckKeyInput")]
		extern static int  dx_CheckKeyInput_x86( int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckKeyInput")]
		extern static int  dx_CheckKeyInput_x64( int  InputHandle);
		public static int  CheckKeyInput( int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckKeyInput_x86( InputHandle );
			}
			else
			{
				return dx_CheckKeyInput_x64( InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReStartKeyInput")]
		extern static int  dx_ReStartKeyInput_x86( int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReStartKeyInput")]
		extern static int  dx_ReStartKeyInput_x64( int  InputHandle);
		public static int  ReStartKeyInput( int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReStartKeyInput_x86( InputHandle );
			}
			else
			{
				return dx_ReStartKeyInput_x64( InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessActKeyInput")]
		extern static int  dx_ProcessActKeyInput_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ProcessActKeyInput")]
		extern static int  dx_ProcessActKeyInput_x64( );
		public static int  ProcessActKeyInput( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ProcessActKeyInput_x86( );
			}
			else
			{
				return dx_ProcessActKeyInput_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawKeyInputString")]
		extern static int  dx_DrawKeyInputString_x86( int  x, int  y, int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawKeyInputString")]
		extern static int  dx_DrawKeyInputString_x64( int  x, int  y, int  InputHandle);
		public static int  DrawKeyInputString( int  x, int  y, int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawKeyInputString_x86( x , y , InputHandle );
			}
			else
			{
				return dx_DrawKeyInputString_x64( x , y , InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputSelectArea")]
		extern static int  dx_SetKeyInputSelectArea_x86( int  SelectStart, int  SelectEnd, int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputSelectArea")]
		extern static int  dx_SetKeyInputSelectArea_x64( int  SelectStart, int  SelectEnd, int  InputHandle);
		public static int  SetKeyInputSelectArea( int  SelectStart, int  SelectEnd, int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputSelectArea_x86( SelectStart , SelectEnd , InputHandle );
			}
			else
			{
				return dx_SetKeyInputSelectArea_x64( SelectStart , SelectEnd , InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputSelectArea")]
		extern static int  dx_GetKeyInputSelectArea_x86( out int  SelectStart, out int  SelectEnd, int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetKeyInputSelectArea")]
		extern static int  dx_GetKeyInputSelectArea_x64( out int  SelectStart, out int  SelectEnd, int  InputHandle);
		public static int  GetKeyInputSelectArea( out int  SelectStart, out int  SelectEnd, int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetKeyInputSelectArea_x86( out SelectStart , out SelectEnd , InputHandle );
			}
			else
			{
				return dx_GetKeyInputSelectArea_x64( out SelectStart , out SelectEnd , InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputDrawStartPos")]
		extern static int  dx_SetKeyInputDrawStartPos_x86( int  DrawStartPos, int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputDrawStartPos")]
		extern static int  dx_SetKeyInputDrawStartPos_x64( int  DrawStartPos, int  InputHandle);
		public static int  SetKeyInputDrawStartPos( int  DrawStartPos, int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputDrawStartPos_x86( DrawStartPos , InputHandle );
			}
			else
			{
				return dx_SetKeyInputDrawStartPos_x64( DrawStartPos , InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputDrawStartPos")]
		extern static int  dx_GetKeyInputDrawStartPos_x86( int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetKeyInputDrawStartPos")]
		extern static int  dx_GetKeyInputDrawStartPos_x64( int  InputHandle);
		public static int  GetKeyInputDrawStartPos( int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetKeyInputDrawStartPos_x86( InputHandle );
			}
			else
			{
				return dx_GetKeyInputDrawStartPos_x64( InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputCursorBrinkTime")]
		extern static int  dx_SetKeyInputCursorBrinkTime_x86( int  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputCursorBrinkTime")]
		extern static int  dx_SetKeyInputCursorBrinkTime_x64( int  Time);
		public static int  SetKeyInputCursorBrinkTime( int  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputCursorBrinkTime_x86( Time );
			}
			else
			{
				return dx_SetKeyInputCursorBrinkTime_x64( Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputCursorBrinkFlag")]
		extern static int  dx_SetKeyInputCursorBrinkFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputCursorBrinkFlag")]
		extern static int  dx_SetKeyInputCursorBrinkFlag_x64( int  Flag);
		public static int  SetKeyInputCursorBrinkFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputCursorBrinkFlag_x86( Flag );
			}
			else
			{
				return dx_SetKeyInputCursorBrinkFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputString")]
		extern static int  dx_SetKeyInputString_x86( string  String, int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputString")]
		extern static int  dx_SetKeyInputString_x64( string  String, int  InputHandle);
		public static int  SetKeyInputString( string  String, int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputString_x86( String , InputHandle );
			}
			else
			{
				return dx_SetKeyInputString_x64( String , InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputNumber")]
		extern static int  dx_SetKeyInputNumber_x86( int  Number, int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputNumber")]
		extern static int  dx_SetKeyInputNumber_x64( int  Number, int  InputHandle);
		public static int  SetKeyInputNumber( int  Number, int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputNumber_x86( Number , InputHandle );
			}
			else
			{
				return dx_SetKeyInputNumber_x64( Number , InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputNumberToFloat")]
		extern static int  dx_SetKeyInputNumberToFloat_x86( float  Number, int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputNumberToFloat")]
		extern static int  dx_SetKeyInputNumberToFloat_x64( float  Number, int  InputHandle);
		public static int  SetKeyInputNumberToFloat( float  Number, int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputNumberToFloat_x86( Number , InputHandle );
			}
			else
			{
				return dx_SetKeyInputNumberToFloat_x64( Number , InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputString")]
		extern static int  dx_GetKeyInputString_x86( System.Text.StringBuilder  StrBuffer, int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetKeyInputString")]
		extern static int  dx_GetKeyInputString_x64( System.Text.StringBuilder  StrBuffer, int  InputHandle);
		public static int  GetKeyInputString( System.Text.StringBuilder  StrBuffer, int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetKeyInputString_x86( StrBuffer , InputHandle );
			}
			else
			{
				return dx_GetKeyInputString_x64( StrBuffer , InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputNumber")]
		extern static int  dx_GetKeyInputNumber_x86( int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetKeyInputNumber")]
		extern static int  dx_GetKeyInputNumber_x64( int  InputHandle);
		public static int  GetKeyInputNumber( int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetKeyInputNumber_x86( InputHandle );
			}
			else
			{
				return dx_GetKeyInputNumber_x64( InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputNumberToFloat")]
		extern static float  dx_GetKeyInputNumberToFloat_x86( int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetKeyInputNumberToFloat")]
		extern static float  dx_GetKeyInputNumberToFloat_x64( int  InputHandle);
		public static float  GetKeyInputNumberToFloat( int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetKeyInputNumberToFloat_x86( InputHandle );
			}
			else
			{
				return dx_GetKeyInputNumberToFloat_x64( InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyInputCursorPosition")]
		extern static int  dx_SetKeyInputCursorPosition_x86( int  Position, int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyInputCursorPosition")]
		extern static int  dx_SetKeyInputCursorPosition_x64( int  Position, int  InputHandle);
		public static int  SetKeyInputCursorPosition( int  Position, int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyInputCursorPosition_x86( Position , InputHandle );
			}
			else
			{
				return dx_SetKeyInputCursorPosition_x64( Position , InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetKeyInputCursorPosition")]
		extern static int  dx_GetKeyInputCursorPosition_x86( int  InputHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetKeyInputCursorPosition")]
		extern static int  dx_GetKeyInputCursorPosition_x64( int  InputHandle);
		public static int  GetKeyInputCursorPosition( int  InputHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetKeyInputCursorPosition_x86( InputHandle );
			}
			else
			{
				return dx_GetKeyInputCursorPosition_x64( InputHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_open")]
		extern static int  dx_FileRead_open_x86( string  FilePath, int  ASync);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_open")]
		extern static int  dx_FileRead_open_x64( string  FilePath, int  ASync);
		public static int  FileRead_open( string  FilePath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_open_x86( FilePath , FALSE );
			}
			else
			{
				return dx_FileRead_open_x64( FilePath , FALSE );
			}
		}
		public static int  FileRead_open( string  FilePath, int  ASync)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_open_x86( FilePath , ASync );
			}
			else
			{
				return dx_FileRead_open_x64( FilePath , ASync );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_size")]
		extern static int  dx_FileRead_size_x86( string  FilePath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_size")]
		extern static int  dx_FileRead_size_x64( string  FilePath);
		public static int  FileRead_size( string  FilePath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_size_x86( FilePath );
			}
			else
			{
				return dx_FileRead_size_x64( FilePath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_close")]
		extern static int  dx_FileRead_close_x86( int  FileHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_close")]
		extern static int  dx_FileRead_close_x64( int  FileHandle);
		public static int  FileRead_close( int  FileHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_close_x86( FileHandle );
			}
			else
			{
				return dx_FileRead_close_x64( FileHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_tell")]
		extern static int  dx_FileRead_tell_x86( int  FileHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_tell")]
		extern static int  dx_FileRead_tell_x64( int  FileHandle);
		public static int  FileRead_tell( int  FileHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_tell_x86( FileHandle );
			}
			else
			{
				return dx_FileRead_tell_x64( FileHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_seek")]
		extern static int  dx_FileRead_seek_x86( int  FileHandle, int  Offset, int  Origin);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_seek")]
		extern static int  dx_FileRead_seek_x64( int  FileHandle, int  Offset, int  Origin);
		public static int  FileRead_seek( int  FileHandle, int  Offset, int  Origin)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_seek_x86( FileHandle , Offset , Origin );
			}
			else
			{
				return dx_FileRead_seek_x64( FileHandle , Offset , Origin );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_read")]
		extern unsafe static int  dx_FileRead_read_x86( void *  Buffer, int  ReadSize, int  FileHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_read")]
		extern unsafe static int  dx_FileRead_read_x64( void *  Buffer, int  ReadSize, int  FileHandle);
		public unsafe static int  FileRead_read( void *  Buffer, int  ReadSize, int  FileHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_read_x86( Buffer , ReadSize , FileHandle );
			}
			else
			{
				return dx_FileRead_read_x64( Buffer , ReadSize , FileHandle );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_idle_chk")]
		extern static int  dx_FileRead_idle_chk_x86( int  FileHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_idle_chk")]
		extern static int  dx_FileRead_idle_chk_x64( int  FileHandle);
		public static int  FileRead_idle_chk( int  FileHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_idle_chk_x86( FileHandle );
			}
			else
			{
				return dx_FileRead_idle_chk_x64( FileHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_eof")]
		extern static int  dx_FileRead_eof_x86( int  FileHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_eof")]
		extern static int  dx_FileRead_eof_x64( int  FileHandle);
		public static int  FileRead_eof( int  FileHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_eof_x86( FileHandle );
			}
			else
			{
				return dx_FileRead_eof_x64( FileHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_gets")]
		extern static int  dx_FileRead_gets_x86( System.Text.StringBuilder  Buffer, int  BufferSize, int  FileHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_gets")]
		extern static int  dx_FileRead_gets_x64( System.Text.StringBuilder  Buffer, int  BufferSize, int  FileHandle);
		public static int  FileRead_gets( System.Text.StringBuilder  Buffer, int  BufferSize, int  FileHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_gets_x86( Buffer , BufferSize , FileHandle );
			}
			else
			{
				return dx_FileRead_gets_x64( Buffer , BufferSize , FileHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_createInfo")]
		extern static uint  dx_FileRead_createInfo_x86( string  ObjectPath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_createInfo")]
		extern static uint  dx_FileRead_createInfo_x64( string  ObjectPath);
		public static uint  FileRead_createInfo( string  ObjectPath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_createInfo_x86( ObjectPath );
			}
			else
			{
				return dx_FileRead_createInfo_x64( ObjectPath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_getInfoNum")]
		extern static int  dx_FileRead_getInfoNum_x86( uint  FileInfoHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_getInfoNum")]
		extern static int  dx_FileRead_getInfoNum_x64( uint  FileInfoHandle);
		public static int  FileRead_getInfoNum( uint  FileInfoHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_getInfoNum_x86( FileInfoHandle );
			}
			else
			{
				return dx_FileRead_getInfoNum_x64( FileInfoHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FileRead_deleteInfo")]
		extern static int  dx_FileRead_deleteInfo_x86( uint  FileInfoHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FileRead_deleteInfo")]
		extern static int  dx_FileRead_deleteInfo_x64( uint  FileInfoHandle);
		public static int  FileRead_deleteInfo( uint  FileInfoHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FileRead_deleteInfo_x86( FileInfoHandle );
			}
			else
			{
				return dx_FileRead_deleteInfo_x64( FileInfoHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStreamFunctionDefault")]
		extern static int  dx_GetStreamFunctionDefault_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetStreamFunctionDefault")]
		extern static int  dx_GetStreamFunctionDefault_x64( );
		public static int  GetStreamFunctionDefault( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetStreamFunctionDefault_x86( );
			}
			else
			{
				return dx_GetStreamFunctionDefault_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckHitKey")]
		extern static int  dx_CheckHitKey_x86( int  KeyCode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckHitKey")]
		extern static int  dx_CheckHitKey_x64( int  KeyCode);
		public static int  CheckHitKey( int  KeyCode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckHitKey_x86( KeyCode );
			}
			else
			{
				return dx_CheckHitKey_x64( KeyCode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckHitKeyAll")]
		extern static int  dx_CheckHitKeyAll_x86( int  CheckType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckHitKeyAll")]
		extern static int  dx_CheckHitKeyAll_x64( int  CheckType);
		public static int  CheckHitKeyAll( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckHitKeyAll_x86( DX_CHECKINPUT_ALL );
			}
			else
			{
				return dx_CheckHitKeyAll_x64( DX_CHECKINPUT_ALL );
			}
		}
		public static int  CheckHitKeyAll( int  CheckType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckHitKeyAll_x86( CheckType );
			}
			else
			{
				return dx_CheckHitKeyAll_x64( CheckType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetHitKeyStateAll")]
		extern static int  dx_GetHitKeyStateAll_x86( out byte  KeyStateBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetHitKeyStateAll")]
		extern static int  dx_GetHitKeyStateAll_x64( out byte  KeyStateBuf);
		public static int  GetHitKeyStateAll( out byte  KeyStateBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetHitKeyStateAll_x86( out KeyStateBuf );
			}
			else
			{
				return dx_GetHitKeyStateAll_x64( out KeyStateBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyExclusiveCooperativeLevelFlag")]
		extern static int  dx_SetKeyExclusiveCooperativeLevelFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyExclusiveCooperativeLevelFlag")]
		extern static int  dx_SetKeyExclusiveCooperativeLevelFlag_x64( int  Flag);
		public static int  SetKeyExclusiveCooperativeLevelFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyExclusiveCooperativeLevelFlag_x86( Flag );
			}
			else
			{
				return dx_SetKeyExclusiveCooperativeLevelFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadNum")]
		extern static int  dx_GetJoypadNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetJoypadNum")]
		extern static int  dx_GetJoypadNum_x64( );
		public static int  GetJoypadNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetJoypadNum_x86( );
			}
			else
			{
				return dx_GetJoypadNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadInputState")]
		extern static int  dx_GetJoypadInputState_x86( int  InputType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetJoypadInputState")]
		extern static int  dx_GetJoypadInputState_x64( int  InputType);
		public static int  GetJoypadInputState( int  InputType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetJoypadInputState_x86( InputType );
			}
			else
			{
				return dx_GetJoypadInputState_x64( InputType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadAnalogInput")]
		extern static int  dx_GetJoypadAnalogInput_x86( out int  XBuf, out int  YBuf, int  InputType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetJoypadAnalogInput")]
		extern static int  dx_GetJoypadAnalogInput_x64( out int  XBuf, out int  YBuf, int  InputType);
		public static int  GetJoypadAnalogInput( out int  XBuf, out int  YBuf, int  InputType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetJoypadAnalogInput_x86( out XBuf , out YBuf , InputType );
			}
			else
			{
				return dx_GetJoypadAnalogInput_x64( out XBuf , out YBuf , InputType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadAnalogInputRight")]
		extern static int  dx_GetJoypadAnalogInputRight_x86( out int  XBuf, out int  YBuf, int  InputType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetJoypadAnalogInputRight")]
		extern static int  dx_GetJoypadAnalogInputRight_x64( out int  XBuf, out int  YBuf, int  InputType);
		public static int  GetJoypadAnalogInputRight( out int  XBuf, out int  YBuf, int  InputType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetJoypadAnalogInputRight_x86( out XBuf , out YBuf , InputType );
			}
			else
			{
				return dx_GetJoypadAnalogInputRight_x64( out XBuf , out YBuf , InputType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadDirectInputState")]
		extern static int  dx_GetJoypadDirectInputState_x86( int  InputType, out DINPUT_JOYSTATE  DInputState);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetJoypadDirectInputState")]
		extern static int  dx_GetJoypadDirectInputState_x64( int  InputType, out DINPUT_JOYSTATE  DInputState);
		public static int  GetJoypadDirectInputState( int  InputType, out DINPUT_JOYSTATE  DInputState)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetJoypadDirectInputState_x86( InputType , out DInputState );
			}
			else
			{
				return dx_GetJoypadDirectInputState_x64( InputType , out DInputState );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_KeyboradBufferProcess")]
		extern static int  dx_KeyboradBufferProcess_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_KeyboradBufferProcess")]
		extern static int  dx_KeyboradBufferProcess_x64( );
		public static int  KeyboradBufferProcess( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_KeyboradBufferProcess_x86( );
			}
			else
			{
				return dx_KeyboradBufferProcess_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvertKeyCodeToVirtualKey")]
		extern static int  dx_ConvertKeyCodeToVirtualKey_x86( int  KeyCode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConvertKeyCodeToVirtualKey")]
		extern static int  dx_ConvertKeyCodeToVirtualKey_x64( int  KeyCode);
		public static int  ConvertKeyCodeToVirtualKey( int  KeyCode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConvertKeyCodeToVirtualKey_x86( KeyCode );
			}
			else
			{
				return dx_ConvertKeyCodeToVirtualKey_x64( KeyCode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvertVirtualKeyToKeyCode")]
		extern static int  dx_ConvertVirtualKeyToKeyCode_x86( int  VirtualKey);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConvertVirtualKeyToKeyCode")]
		extern static int  dx_ConvertVirtualKeyToKeyCode_x64( int  VirtualKey);
		public static int  ConvertVirtualKeyToKeyCode( int  VirtualKey)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConvertVirtualKeyToKeyCode_x86( VirtualKey );
			}
			else
			{
				return dx_ConvertVirtualKeyToKeyCode_x64( VirtualKey );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetJoypadInputToKeyInput")]
		extern static int  dx_SetJoypadInputToKeyInput_x86( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3, int  KeyInput4);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetJoypadInputToKeyInput")]
		extern static int  dx_SetJoypadInputToKeyInput_x64( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3, int  KeyInput4);
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetJoypadInputToKeyInput_x86( InputType , PadInput , KeyInput1 , -1 , -1 , -1 );
			}
			else
			{
				return dx_SetJoypadInputToKeyInput_x64( InputType , PadInput , KeyInput1 , -1 , -1 , -1 );
			}
		}
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetJoypadInputToKeyInput_x86( InputType , PadInput , KeyInput1 , KeyInput2 , -1 , -1 );
			}
			else
			{
				return dx_SetJoypadInputToKeyInput_x64( InputType , PadInput , KeyInput1 , KeyInput2 , -1 , -1 );
			}
		}
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetJoypadInputToKeyInput_x86( InputType , PadInput , KeyInput1 , KeyInput2 , KeyInput3 , -1 );
			}
			else
			{
				return dx_SetJoypadInputToKeyInput_x64( InputType , PadInput , KeyInput1 , KeyInput2 , KeyInput3 , -1 );
			}
		}
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3, int  KeyInput4)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetJoypadInputToKeyInput_x86( InputType , PadInput , KeyInput1 , KeyInput2 , KeyInput3 , KeyInput4 );
			}
			else
			{
				return dx_SetJoypadInputToKeyInput_x64( InputType , PadInput , KeyInput1 , KeyInput2 , KeyInput3 , KeyInput4 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetJoypadDeadZone")]
		extern static int  dx_SetJoypadDeadZone_x86( int  InputType, double  Zone);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetJoypadDeadZone")]
		extern static int  dx_SetJoypadDeadZone_x64( int  InputType, double  Zone);
		public static int  SetJoypadDeadZone( int  InputType, double  Zone)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetJoypadDeadZone_x86( InputType , Zone );
			}
			else
			{
				return dx_SetJoypadDeadZone_x64( InputType , Zone );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StartJoypadVibration")]
		extern static int  dx_StartJoypadVibration_x86( int  InputType, int  Power, int  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StartJoypadVibration")]
		extern static int  dx_StartJoypadVibration_x64( int  InputType, int  Power, int  Time);
		public static int  StartJoypadVibration( int  InputType, int  Power, int  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StartJoypadVibration_x86( InputType , Power , Time );
			}
			else
			{
				return dx_StartJoypadVibration_x64( InputType , Power , Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopJoypadVibration")]
		extern static int  dx_StopJoypadVibration_x86( int  InputType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StopJoypadVibration")]
		extern static int  dx_StopJoypadVibration_x64( int  InputType);
		public static int  StopJoypadVibration( int  InputType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StopJoypadVibration_x86( InputType );
			}
			else
			{
				return dx_StopJoypadVibration_x64( InputType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadPOVState")]
		extern static int  dx_GetJoypadPOVState_x86( int  InputType, int  POVNumber);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetJoypadPOVState")]
		extern static int  dx_GetJoypadPOVState_x64( int  InputType, int  POVNumber);
		public static int  GetJoypadPOVState( int  InputType, int  POVNumber)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetJoypadPOVState_x86( InputType , POVNumber );
			}
			else
			{
				return dx_GetJoypadPOVState_x64( InputType , POVNumber );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetJoypadName")]
		extern static int  dx_GetJoypadName_x86( int  InputType, System.Text.StringBuilder  InstanceNameBuffer, System.Text.StringBuilder  ProductNameBuffer);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetJoypadName")]
		extern static int  dx_GetJoypadName_x64( int  InputType, System.Text.StringBuilder  InstanceNameBuffer, System.Text.StringBuilder  ProductNameBuffer);
		public static int  GetJoypadName( int  InputType, System.Text.StringBuilder  InstanceNameBuffer, System.Text.StringBuilder  ProductNameBuffer)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetJoypadName_x86( InputType , InstanceNameBuffer , ProductNameBuffer );
			}
			else
			{
				return dx_GetJoypadName_x64( InputType , InstanceNameBuffer , ProductNameBuffer );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReSetupJoypad")]
		extern static int  dx_ReSetupJoypad_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReSetupJoypad")]
		extern static int  dx_ReSetupJoypad_x64( );
		public static int  ReSetupJoypad( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReSetupJoypad_x86( );
			}
			else
			{
				return dx_ReSetupJoypad_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetKeyboardNotDirectInputFlag")]
		extern static int  dx_SetKeyboardNotDirectInputFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetKeyboardNotDirectInputFlag")]
		extern static int  dx_SetKeyboardNotDirectInputFlag_x64( int  Flag);
		public static int  SetKeyboardNotDirectInputFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetKeyboardNotDirectInputFlag_x86( Flag );
			}
			else
			{
				return dx_SetKeyboardNotDirectInputFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDirectInputFlag")]
		extern static int  dx_SetUseDirectInputFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseDirectInputFlag")]
		extern static int  dx_SetUseDirectInputFlag_x64( int  Flag);
		public static int  SetUseDirectInputFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseDirectInputFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseDirectInputFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseJoypadVibrationFlag")]
		extern static int  dx_SetUseJoypadVibrationFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseJoypadVibrationFlag")]
		extern static int  dx_SetUseJoypadVibrationFlag_x64( int  Flag);
		public static int  SetUseJoypadVibrationFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseJoypadVibrationFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseJoypadVibrationFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeGraph")]
		extern static int  dx_MakeGraph_x86( int  SizeX, int  SizeY, int  NotUse3DFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeGraph")]
		extern static int  dx_MakeGraph_x64( int  SizeX, int  SizeY, int  NotUse3DFlag);
		public static int  MakeGraph( int  SizeX, int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeGraph_x86( SizeX , SizeY , FALSE );
			}
			else
			{
				return dx_MakeGraph_x64( SizeX , SizeY , FALSE );
			}
		}
		public static int  MakeGraph( int  SizeX, int  SizeY, int  NotUse3DFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeGraph_x86( SizeX , SizeY , NotUse3DFlag );
			}
			else
			{
				return dx_MakeGraph_x64( SizeX , SizeY , NotUse3DFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeScreen")]
		extern static int  dx_MakeScreen_x86( int  SizeX, int  SizeY, int  UseAlphaChannel);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeScreen")]
		extern static int  dx_MakeScreen_x64( int  SizeX, int  SizeY, int  UseAlphaChannel);
		public static int  MakeScreen( int  SizeX, int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeScreen_x86( SizeX , SizeY , FALSE );
			}
			else
			{
				return dx_MakeScreen_x64( SizeX , SizeY , FALSE );
			}
		}
		public static int  MakeScreen( int  SizeX, int  SizeY, int  UseAlphaChannel)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeScreen_x86( SizeX , SizeY , UseAlphaChannel );
			}
			else
			{
				return dx_MakeScreen_x64( SizeX , SizeY , UseAlphaChannel );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DerivationGraph")]
		extern static int  dx_DerivationGraph_x86( int  SrcX, int  SrcY, int  Width, int  Height, int  SrcGraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DerivationGraph")]
		extern static int  dx_DerivationGraph_x64( int  SrcX, int  SrcY, int  Width, int  Height, int  SrcGraphHandle);
		public static int  DerivationGraph( int  SrcX, int  SrcY, int  Width, int  Height, int  SrcGraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DerivationGraph_x86( SrcX , SrcY , Width , Height , SrcGraphHandle );
			}
			else
			{
				return dx_DerivationGraph_x64( SrcX , SrcY , Width , Height , SrcGraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteGraph")]
		extern static int  dx_DeleteGraph_x86( int  GrHandle, int  LogOutFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteGraph")]
		extern static int  dx_DeleteGraph_x64( int  GrHandle, int  LogOutFlag);
		public static int  DeleteGraph( int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteGraph_x86( GrHandle , FALSE );
			}
			else
			{
				return dx_DeleteGraph_x64( GrHandle , FALSE );
			}
		}
		public static int  DeleteGraph( int  GrHandle, int  LogOutFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteGraph_x86( GrHandle , LogOutFlag );
			}
			else
			{
				return dx_DeleteGraph_x64( GrHandle , LogOutFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSharingGraph")]
		extern static int  dx_DeleteSharingGraph_x86( int  GrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteSharingGraph")]
		extern static int  dx_DeleteSharingGraph_x64( int  GrHandle);
		public static int  DeleteSharingGraph( int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteSharingGraph_x86( GrHandle );
			}
			else
			{
				return dx_DeleteSharingGraph_x64( GrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphNum")]
		extern static int  dx_GetGraphNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetGraphNum")]
		extern static int  dx_GetGraphNum_x64( );
		public static int  GetGraphNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetGraphNum_x86( );
			}
			else
			{
				return dx_GetGraphNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FillGraph")]
		extern static int  dx_FillGraph_x86( int  GrHandle, int  Red, int  Green, int  Blue, int  Alpha);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FillGraph")]
		extern static int  dx_FillGraph_x64( int  GrHandle, int  Red, int  Green, int  Blue, int  Alpha);
		public static int  FillGraph( int  GrHandle, int  Red, int  Green, int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FillGraph_x86( GrHandle , Red , Green , Blue , 255 );
			}
			else
			{
				return dx_FillGraph_x64( GrHandle , Red , Green , Blue , 255 );
			}
		}
		public static int  FillGraph( int  GrHandle, int  Red, int  Green, int  Blue, int  Alpha)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FillGraph_x86( GrHandle , Red , Green , Blue , Alpha );
			}
			else
			{
				return dx_FillGraph_x64( GrHandle , Red , Green , Blue , Alpha );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphLostFlag")]
		extern static int  dx_SetGraphLostFlag_x86( int  GrHandle, out int  LostFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetGraphLostFlag")]
		extern static int  dx_SetGraphLostFlag_x64( int  GrHandle, out int  LostFlag);
		public static int  SetGraphLostFlag( int  GrHandle, out int  LostFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetGraphLostFlag_x86( GrHandle , out LostFlag );
			}
			else
			{
				return dx_SetGraphLostFlag_x64( GrHandle , out LostFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitGraph")]
		extern static int  dx_InitGraph_x86( int  LogOutFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitGraph")]
		extern static int  dx_InitGraph_x64( int  LogOutFlag);
		public static int  InitGraph( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitGraph_x86( FALSE );
			}
			else
			{
				return dx_InitGraph_x64( FALSE );
			}
		}
		public static int  InitGraph( int  LogOutFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitGraph_x86( LogOutFlag );
			}
			else
			{
				return dx_InitGraph_x64( LogOutFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadFileGraphAll")]
		extern static int  dx_ReloadFileGraphAll_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReloadFileGraphAll")]
		extern static int  dx_ReloadFileGraphAll_x64( );
		public static int  ReloadFileGraphAll( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReloadFileGraphAll_x86( );
			}
			else
			{
				return dx_ReloadFileGraphAll_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadBmpToGraph")]
		extern static int  dx_LoadBmpToGraph_x86( string  FileName, int  TextureFlag, int  ReverseFlag, int  SurfaceMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadBmpToGraph")]
		extern static int  dx_LoadBmpToGraph_x64( string  FileName, int  TextureFlag, int  ReverseFlag, int  SurfaceMode);
		public static int  LoadBmpToGraph( string  FileName, int  TextureFlag, int  ReverseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadBmpToGraph_x86( FileName , TextureFlag , ReverseFlag , DX_MOVIESURFACE_NORMAL );
			}
			else
			{
				return dx_LoadBmpToGraph_x64( FileName , TextureFlag , ReverseFlag , DX_MOVIESURFACE_NORMAL );
			}
		}
		public static int  LoadBmpToGraph( string  FileName, int  TextureFlag, int  ReverseFlag, int  SurfaceMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadBmpToGraph_x86( FileName , TextureFlag , ReverseFlag , SurfaceMode );
			}
			else
			{
				return dx_LoadBmpToGraph_x64( FileName , TextureFlag , ReverseFlag , SurfaceMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadGraph")]
		extern static int  dx_LoadGraph_x86( string  FileName, int  NotUse3DFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadGraph")]
		extern static int  dx_LoadGraph_x64( string  FileName, int  NotUse3DFlag);
		public static int  LoadGraph( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadGraph_x86( FileName , FALSE );
			}
			else
			{
				return dx_LoadGraph_x64( FileName , FALSE );
			}
		}
		public static int  LoadGraph( string  FileName, int  NotUse3DFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadGraph_x86( FileName , NotUse3DFlag );
			}
			else
			{
				return dx_LoadGraph_x64( FileName , NotUse3DFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadReverseGraph")]
		extern static int  dx_LoadReverseGraph_x86( string  FileName, int  NotUse3DFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadReverseGraph")]
		extern static int  dx_LoadReverseGraph_x64( string  FileName, int  NotUse3DFlag);
		public static int  LoadReverseGraph( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadReverseGraph_x86( FileName , FALSE );
			}
			else
			{
				return dx_LoadReverseGraph_x64( FileName , FALSE );
			}
		}
		public static int  LoadReverseGraph( string  FileName, int  NotUse3DFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadReverseGraph_x86( FileName , NotUse3DFlag );
			}
			else
			{
				return dx_LoadReverseGraph_x64( FileName , NotUse3DFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivGraph")]
		extern static int  dx_LoadDivGraph_x86( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadDivGraph")]
		extern static int  dx_LoadDivGraph_x64( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag);
		public static int  LoadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadDivGraph_x86( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , FALSE );
			}
			else
			{
				return dx_LoadDivGraph_x64( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , FALSE );
			}
		}
		public static int  LoadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadDivGraph_x86( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , NotUse3DFlag );
			}
			else
			{
				return dx_LoadDivGraph_x64( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , NotUse3DFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivBmpToGraph")]
		extern static int  dx_LoadDivBmpToGraph_x86( string  FileName, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf, int  TextureFlag, int  ReverseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadDivBmpToGraph")]
		extern static int  dx_LoadDivBmpToGraph_x64( string  FileName, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf, int  TextureFlag, int  ReverseFlag);
		public static int  LoadDivBmpToGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf, int  TextureFlag, int  ReverseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadDivBmpToGraph_x86( FileName , AllNum , XNum , YNum , SizeX , SizeY , out HandleBuf , TextureFlag , ReverseFlag );
			}
			else
			{
				return dx_LoadDivBmpToGraph_x64( FileName , AllNum , XNum , YNum , SizeX , SizeY , out HandleBuf , TextureFlag , ReverseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadReverseDivGraph")]
		extern static int  dx_LoadReverseDivGraph_x86( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadReverseDivGraph")]
		extern static int  dx_LoadReverseDivGraph_x64( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag);
		public static int  LoadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadReverseDivGraph_x86( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , FALSE );
			}
			else
			{
				return dx_LoadReverseDivGraph_x64( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , FALSE );
			}
		}
		public static int  LoadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  NotUse3DFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadReverseDivGraph_x86( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , NotUse3DFlag );
			}
			else
			{
				return dx_LoadReverseDivGraph_x64( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , NotUse3DFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadBlendGraph")]
		extern static int  dx_LoadBlendGraph_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadBlendGraph")]
		extern static int  dx_LoadBlendGraph_x64( string  FileName);
		public static int  LoadBlendGraph( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadBlendGraph_x86( FileName );
			}
			else
			{
				return dx_LoadBlendGraph_x64( FileName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivGraphToResource")]
		extern static int  dx_LoadDivGraphToResource_x86( int  ResourceID, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadDivGraphToResource")]
		extern static int  dx_LoadDivGraphToResource_x64( int  ResourceID, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		public static int  LoadDivGraphToResource( int  ResourceID, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadDivGraphToResource_x86( ResourceID , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
			}
			else
			{
				return dx_LoadDivGraphToResource_x64( ResourceID , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivGraphToResource_2")]
		extern static int  dx_LoadDivGraphToResource_2_x86( string  ResourceName, string  ResourceType, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadDivGraphToResource_2")]
		extern static int  dx_LoadDivGraphToResource_2_x64( string  ResourceName, string  ResourceType, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		public static int  LoadDivGraphToResource( string  ResourceName, string  ResourceType, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadDivGraphToResource_2_x86( ResourceName , ResourceType , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
			}
			else
			{
				return dx_LoadDivGraphToResource_2_x64( ResourceName , ResourceType , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_CreateGraphFromMem")]
		extern unsafe static int  dx_CreateGraphFromMem_x86( void *  RGBFileImage, int  RGBFileImageSize, void *  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateGraphFromMem")]
		extern unsafe static int  dx_CreateGraphFromMem_x64( void *  RGBFileImage, int  RGBFileImageSize, void *  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag);
		public unsafe static int  CreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , null , 0 , TRUE , FALSE );
			}
			else
			{
				return dx_CreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , null , 0 , TRUE , FALSE );
			}
		}
		public unsafe static int  CreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, void *  AlphaFileImage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AlphaFileImage , 0 , TRUE , FALSE );
			}
			else
			{
				return dx_CreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AlphaFileImage , 0 , TRUE , FALSE );
			}
		}
		public unsafe static int  CreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, void *  AlphaFileImage, int  AlphaFileImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AlphaFileImage , AlphaFileImageSize , TRUE , FALSE );
			}
			else
			{
				return dx_CreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AlphaFileImage , AlphaFileImageSize , TRUE , FALSE );
			}
		}
		public unsafe static int  CreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, void *  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AlphaFileImage , AlphaFileImageSize , TextureFlag , FALSE );
			}
			else
			{
				return dx_CreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AlphaFileImage , AlphaFileImageSize , TextureFlag , FALSE );
			}
		}
		public unsafe static int  CreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, void *  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AlphaFileImage , AlphaFileImageSize , TextureFlag , ReverseFlag );
			}
			else
			{
				return dx_CreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AlphaFileImage , AlphaFileImageSize , TextureFlag , ReverseFlag );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateGraphFromMem")]
		extern unsafe static int  dx_ReCreateGraphFromMem_x86( void *  RGBFileImage, int  RGBFileImageSize, int  GrHandle, void *  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReCreateGraphFromMem")]
		extern unsafe static int  dx_ReCreateGraphFromMem_x64( void *  RGBFileImage, int  RGBFileImageSize, int  GrHandle, void *  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag);
		public unsafe static int  ReCreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , GrHandle , null , 0 , TRUE , FALSE );
			}
			else
			{
				return dx_ReCreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , GrHandle , null , 0 , TRUE , FALSE );
			}
		}
		public unsafe static int  ReCreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  GrHandle, void *  AlphaFileImage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , 0 , TRUE , FALSE );
			}
			else
			{
				return dx_ReCreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , 0 , TRUE , FALSE );
			}
		}
		public unsafe static int  ReCreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  GrHandle, void *  AlphaFileImage, int  AlphaFileImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , AlphaFileImageSize , TRUE , FALSE );
			}
			else
			{
				return dx_ReCreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , AlphaFileImageSize , TRUE , FALSE );
			}
		}
		public unsafe static int  ReCreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  GrHandle, void *  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , AlphaFileImageSize , TextureFlag , FALSE );
			}
			else
			{
				return dx_ReCreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , AlphaFileImageSize , TextureFlag , FALSE );
			}
		}
		public unsafe static int  ReCreateGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  GrHandle, void *  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateGraphFromMem_x86( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , AlphaFileImageSize , TextureFlag , ReverseFlag );
			}
			else
			{
				return dx_ReCreateGraphFromMem_x64( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , AlphaFileImageSize , TextureFlag , ReverseFlag );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_CreateDivGraphFromMem")]
		extern unsafe static int  dx_CreateDivGraphFromMem_x86( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaFileImage, int  AlphaFileImageSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateDivGraphFromMem")]
		extern unsafe static int  dx_CreateDivGraphFromMem_x64( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaFileImage, int  AlphaFileImageSize);
		public unsafe static int  CreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TRUE , FALSE , null , 0 );
			}
			else
			{
				return dx_CreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TRUE , FALSE , null , 0 );
			}
		}
		public unsafe static int  CreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , FALSE , null , 0 );
			}
			else
			{
				return dx_CreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , FALSE , null , 0 );
			}
		}
		public unsafe static int  CreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , null , 0 );
			}
			else
			{
				return dx_CreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , null , 0 );
			}
		}
		public unsafe static int  CreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaFileImage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaFileImage , 0 );
			}
			else
			{
				return dx_CreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaFileImage , 0 );
			}
		}
		public unsafe static int  CreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaFileImage, int  AlphaFileImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaFileImage , AlphaFileImageSize );
			}
			else
			{
				return dx_CreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaFileImage , AlphaFileImageSize );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateDivGraphFromMem")]
		extern unsafe static int  dx_ReCreateDivGraphFromMem_x86( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaFileImage, int  AlphaFileImageSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReCreateDivGraphFromMem")]
		extern unsafe static int  dx_ReCreateDivGraphFromMem_x64( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaFileImage, int  AlphaFileImageSize);
		public unsafe static int  ReCreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TRUE , FALSE , null , 0 );
			}
			else
			{
				return dx_ReCreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TRUE , FALSE , null , 0 );
			}
		}
		public unsafe static int  ReCreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , FALSE , null , 0 );
			}
			else
			{
				return dx_ReCreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , FALSE , null , 0 );
			}
		}
		public unsafe static int  ReCreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , null , 0 );
			}
			else
			{
				return dx_ReCreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , null , 0 );
			}
		}
		public unsafe static int  ReCreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaFileImage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaFileImage , 0 );
			}
			else
			{
				return dx_ReCreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaFileImage , 0 );
			}
		}
		public unsafe static int  ReCreateDivGraphFromMem( void *  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, int  TextureFlag, int  ReverseFlag, void *  AlphaFileImage, int  AlphaFileImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateDivGraphFromMem_x86( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaFileImage , AlphaFileImageSize );
			}
			else
			{
				return dx_ReCreateDivGraphFromMem_x64( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , TextureFlag , ReverseFlag , AlphaFileImage , AlphaFileImageSize );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_CreateGraph")]
		extern unsafe static int  dx_CreateGraph_x86( int  Width, int  Height, int  Pitch, void *  RGBImage, void *  AlphaImage, int  GrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateGraph")]
		extern unsafe static int  dx_CreateGraph_x64( int  Width, int  Height, int  Pitch, void *  RGBImage, void *  AlphaImage, int  GrHandle);
		public unsafe static int  CreateGraph( int  Width, int  Height, int  Pitch, void *  RGBImage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraph_x86( Width , Height , Pitch , RGBImage , null , -1 );
			}
			else
			{
				return dx_CreateGraph_x64( Width , Height , Pitch , RGBImage , null , -1 );
			}
		}
		public unsafe static int  CreateGraph( int  Width, int  Height, int  Pitch, void *  RGBImage, void *  AlphaImage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraph_x86( Width , Height , Pitch , RGBImage , AlphaImage , -1 );
			}
			else
			{
				return dx_CreateGraph_x64( Width , Height , Pitch , RGBImage , AlphaImage , -1 );
			}
		}
		public unsafe static int  CreateGraph( int  Width, int  Height, int  Pitch, void *  RGBImage, void *  AlphaImage, int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraph_x86( Width , Height , Pitch , RGBImage , AlphaImage , GrHandle );
			}
			else
			{
				return dx_CreateGraph_x64( Width , Height , Pitch , RGBImage , AlphaImage , GrHandle );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_CreateDivGraph")]
		extern unsafe static int  dx_CreateDivGraph_x86( int  Width, int  Height, int  Pitch, void *  RGBImage, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, void *  AlphaImage);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateDivGraph")]
		extern unsafe static int  dx_CreateDivGraph_x64( int  Width, int  Height, int  Pitch, void *  RGBImage, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, void *  AlphaImage);
		public unsafe static int  CreateDivGraph( int  Width, int  Height, int  Pitch, void *  RGBImage, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateDivGraph_x86( Width , Height , Pitch , RGBImage , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , null );
			}
			else
			{
				return dx_CreateDivGraph_x64( Width , Height , Pitch , RGBImage , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , null );
			}
		}
		public unsafe static int  CreateDivGraph( int  Width, int  Height, int  Pitch, void *  RGBImage, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, int *  HandleBuf, void *  AlphaImage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateDivGraph_x86( Width , Height , Pitch , RGBImage , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , AlphaImage );
			}
			else
			{
				return dx_CreateDivGraph_x64( Width , Height , Pitch , RGBImage , AllNum , XNum , YNum , SizeX , SizeY , HandleBuf , AlphaImage );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateGraph")]
		extern unsafe static int  dx_ReCreateGraph_x86( int  Width, int  Height, int  Pitch, void *  RGBImage, int  GrHandle, void *  AlphaImage);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReCreateGraph")]
		extern unsafe static int  dx_ReCreateGraph_x64( int  Width, int  Height, int  Pitch, void *  RGBImage, int  GrHandle, void *  AlphaImage);
		public unsafe static int  ReCreateGraph( int  Width, int  Height, int  Pitch, void *  RGBImage, int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateGraph_x86( Width , Height , Pitch , RGBImage , GrHandle , null );
			}
			else
			{
				return dx_ReCreateGraph_x64( Width , Height , Pitch , RGBImage , GrHandle , null );
			}
		}
		public unsafe static int  ReCreateGraph( int  Width, int  Height, int  Pitch, void *  RGBImage, int  GrHandle, void *  AlphaImage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateGraph_x86( Width , Height , Pitch , RGBImage , GrHandle , AlphaImage );
			}
			else
			{
				return dx_ReCreateGraph_x64( Width , Height , Pitch , RGBImage , GrHandle , AlphaImage );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_CreateBlendGraphFromSoftImage")]
		extern static int  dx_CreateBlendGraphFromSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateBlendGraphFromSoftImage")]
		extern static int  dx_CreateBlendGraphFromSoftImage_x64( int  SIHandle);
		public static int  CreateBlendGraphFromSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateBlendGraphFromSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_CreateBlendGraphFromSoftImage_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateGraphFromSoftImage")]
		extern static int  dx_CreateGraphFromSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateGraphFromSoftImage")]
		extern static int  dx_CreateGraphFromSoftImage_x64( int  SIHandle);
		public static int  CreateGraphFromSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraphFromSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_CreateGraphFromSoftImage_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateGraphFromRectSoftImage")]
		extern static int  dx_CreateGraphFromRectSoftImage_x86( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateGraphFromRectSoftImage")]
		extern static int  dx_CreateGraphFromRectSoftImage_x64( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY);
		public static int  CreateGraphFromRectSoftImage( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGraphFromRectSoftImage_x86( SIHandle , x , y , SizeX , SizeY );
			}
			else
			{
				return dx_CreateGraphFromRectSoftImage_x64( SIHandle , x , y , SizeX , SizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateGraphFromSoftImage")]
		extern static int  dx_ReCreateGraphFromSoftImage_x86( int  SIHandle, int  GrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReCreateGraphFromSoftImage")]
		extern static int  dx_ReCreateGraphFromSoftImage_x64( int  SIHandle, int  GrHandle);
		public static int  ReCreateGraphFromSoftImage( int  SIHandle, int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateGraphFromSoftImage_x86( SIHandle , GrHandle );
			}
			else
			{
				return dx_ReCreateGraphFromSoftImage_x64( SIHandle , GrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReCreateGraphFromRectSoftImage")]
		extern static int  dx_ReCreateGraphFromRectSoftImage_x86( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY, int  GrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReCreateGraphFromRectSoftImage")]
		extern static int  dx_ReCreateGraphFromRectSoftImage_x64( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY, int  GrHandle);
		public static int  ReCreateGraphFromRectSoftImage( int  SIHandle, int  x, int  y, int  SizeX, int  SizeY, int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReCreateGraphFromRectSoftImage_x86( SIHandle , x , y , SizeX , SizeY , GrHandle );
			}
			else
			{
				return dx_ReCreateGraphFromRectSoftImage_x64( SIHandle , x , y , SizeX , SizeY , GrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateDivGraphFromSoftImage")]
		extern static int  dx_CreateDivGraphFromSoftImage_x86( int  SIHandle, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateDivGraphFromSoftImage")]
		extern static int  dx_CreateDivGraphFromSoftImage_x64( int  SIHandle, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf);
		public static int  CreateDivGraphFromSoftImage( int  SIHandle, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, out int  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateDivGraphFromSoftImage_x86( SIHandle , AllNum , XNum , YNum , SizeX , SizeY , out HandleBuf );
			}
			else
			{
				return dx_CreateDivGraphFromSoftImage_x64( SIHandle , AllNum , XNum , YNum , SizeX , SizeY , out HandleBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadGraph")]
		extern static int  dx_ReloadGraph_x86( string  FileName, int  GrHandle, int  ReverseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReloadGraph")]
		extern static int  dx_ReloadGraph_x64( string  FileName, int  GrHandle, int  ReverseFlag);
		public static int  ReloadGraph( string  FileName, int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReloadGraph_x86( FileName , GrHandle , FALSE );
			}
			else
			{
				return dx_ReloadGraph_x64( FileName , GrHandle , FALSE );
			}
		}
		public static int  ReloadGraph( string  FileName, int  GrHandle, int  ReverseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReloadGraph_x86( FileName , GrHandle , ReverseFlag );
			}
			else
			{
				return dx_ReloadGraph_x64( FileName , GrHandle , ReverseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadDivGraph")]
		extern static int  dx_ReloadDivGraph_x86( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  ReverseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReloadDivGraph")]
		extern static int  dx_ReloadDivGraph_x64( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  ReverseFlag);
		public static int  ReloadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReloadDivGraph_x86( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , FALSE );
			}
			else
			{
				return dx_ReloadDivGraph_x64( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , FALSE );
			}
		}
		public static int  ReloadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf, int  ReverseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReloadDivGraph_x86( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , ReverseFlag );
			}
			else
			{
				return dx_ReloadDivGraph_x64( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf , ReverseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadReverseGraph")]
		extern static int  dx_ReloadReverseGraph_x86( string  FileName, int  GrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReloadReverseGraph")]
		extern static int  dx_ReloadReverseGraph_x64( string  FileName, int  GrHandle);
		public static int  ReloadReverseGraph( string  FileName, int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReloadReverseGraph_x86( FileName , GrHandle );
			}
			else
			{
				return dx_ReloadReverseGraph_x64( FileName , GrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReloadReverseDivGraph")]
		extern static int  dx_ReloadReverseDivGraph_x86( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReloadReverseDivGraph")]
		extern static int  dx_ReloadReverseDivGraph_x64( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		public static int  ReloadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReloadReverseDivGraph_x86( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
			}
			else
			{
				return dx_ReloadReverseDivGraph_x64( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphColorBitDepth")]
		extern static int  dx_SetGraphColorBitDepth_x86( int  ColorBitDepth);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetGraphColorBitDepth")]
		extern static int  dx_SetGraphColorBitDepth_x64( int  ColorBitDepth);
		public static int  SetGraphColorBitDepth( int  ColorBitDepth)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetGraphColorBitDepth_x86( ColorBitDepth );
			}
			else
			{
				return dx_SetGraphColorBitDepth_x64( ColorBitDepth );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphColorBitDepth")]
		extern static int  dx_GetGraphColorBitDepth_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetGraphColorBitDepth")]
		extern static int  dx_GetGraphColorBitDepth_x64( );
		public static int  GetGraphColorBitDepth( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetGraphColorBitDepth_x86( );
			}
			else
			{
				return dx_GetGraphColorBitDepth_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCreateGraphColorBitDepth")]
		extern static int  dx_SetCreateGraphColorBitDepth_x86( int  BitDepth);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCreateGraphColorBitDepth")]
		extern static int  dx_SetCreateGraphColorBitDepth_x64( int  BitDepth);
		public static int  SetCreateGraphColorBitDepth( int  BitDepth)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCreateGraphColorBitDepth_x86( BitDepth );
			}
			else
			{
				return dx_SetCreateGraphColorBitDepth_x64( BitDepth );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCreateGraphColorBitDepth")]
		extern static int  dx_GetCreateGraphColorBitDepth_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCreateGraphColorBitDepth")]
		extern static int  dx_GetCreateGraphColorBitDepth_x64( );
		public static int  GetCreateGraphColorBitDepth( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCreateGraphColorBitDepth_x86( );
			}
			else
			{
				return dx_GetCreateGraphColorBitDepth_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCreateGraphChannelBitDepth")]
		extern static int  dx_SetCreateGraphChannelBitDepth_x86( int  BitDepth);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCreateGraphChannelBitDepth")]
		extern static int  dx_SetCreateGraphChannelBitDepth_x64( int  BitDepth);
		public static int  SetCreateGraphChannelBitDepth( int  BitDepth)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCreateGraphChannelBitDepth_x86( BitDepth );
			}
			else
			{
				return dx_SetCreateGraphChannelBitDepth_x64( BitDepth );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCreateGraphChannelBitDepth")]
		extern static int  dx_GetCreateGraphChannelBitDepth_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCreateGraphChannelBitDepth")]
		extern static int  dx_GetCreateGraphChannelBitDepth_x64( );
		public static int  GetCreateGraphChannelBitDepth( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCreateGraphChannelBitDepth_x86( );
			}
			else
			{
				return dx_GetCreateGraphChannelBitDepth_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidGraphCreateFlag")]
		extern static int  dx_SetDrawValidGraphCreateFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawValidGraphCreateFlag")]
		extern static int  dx_SetDrawValidGraphCreateFlag_x64( int  Flag);
		public static int  SetDrawValidGraphCreateFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawValidGraphCreateFlag_x86( Flag );
			}
			else
			{
				return dx_SetDrawValidGraphCreateFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawValidGraphCreateFlag")]
		extern static int  dx_GetDrawValidGraphCreateFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawValidGraphCreateFlag")]
		extern static int  dx_GetDrawValidGraphCreateFlag_x64( );
		public static int  GetDrawValidGraphCreateFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawValidGraphCreateFlag_x86( );
			}
			else
			{
				return dx_GetDrawValidGraphCreateFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidFlagOf3DGraph")]
		extern static int  dx_SetDrawValidFlagOf3DGraph_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawValidFlagOf3DGraph")]
		extern static int  dx_SetDrawValidFlagOf3DGraph_x64( int  Flag);
		public static int  SetDrawValidFlagOf3DGraph( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawValidFlagOf3DGraph_x86( Flag );
			}
			else
			{
				return dx_SetDrawValidFlagOf3DGraph_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLeftUpColorIsTransColorFlag")]
		extern static int  dx_SetLeftUpColorIsTransColorFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLeftUpColorIsTransColorFlag")]
		extern static int  dx_SetLeftUpColorIsTransColorFlag_x64( int  Flag);
		public static int  SetLeftUpColorIsTransColorFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLeftUpColorIsTransColorFlag_x86( Flag );
			}
			else
			{
				return dx_SetLeftUpColorIsTransColorFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseBlendGraphCreateFlag")]
		extern static int  dx_SetUseBlendGraphCreateFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseBlendGraphCreateFlag")]
		extern static int  dx_SetUseBlendGraphCreateFlag_x64( int  Flag);
		public static int  SetUseBlendGraphCreateFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseBlendGraphCreateFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseBlendGraphCreateFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseBlendGraphCreateFlag")]
		extern static int  dx_GetUseBlendGraphCreateFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseBlendGraphCreateFlag")]
		extern static int  dx_GetUseBlendGraphCreateFlag_x64( );
		public static int  GetUseBlendGraphCreateFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseBlendGraphCreateFlag_x86( );
			}
			else
			{
				return dx_GetUseBlendGraphCreateFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseAlphaTestGraphCreateFlag")]
		extern static int  dx_SetUseAlphaTestGraphCreateFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseAlphaTestGraphCreateFlag")]
		extern static int  dx_SetUseAlphaTestGraphCreateFlag_x64( int  Flag);
		public static int  SetUseAlphaTestGraphCreateFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseAlphaTestGraphCreateFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseAlphaTestGraphCreateFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseAlphaTestGraphCreateFlag")]
		extern static int  dx_GetUseAlphaTestGraphCreateFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseAlphaTestGraphCreateFlag")]
		extern static int  dx_GetUseAlphaTestGraphCreateFlag_x64( );
		public static int  GetUseAlphaTestGraphCreateFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseAlphaTestGraphCreateFlag_x86( );
			}
			else
			{
				return dx_GetUseAlphaTestGraphCreateFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseAlphaTestFlag")]
		extern static int  dx_SetUseAlphaTestFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseAlphaTestFlag")]
		extern static int  dx_SetUseAlphaTestFlag_x64( int  Flag);
		public static int  SetUseAlphaTestFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseAlphaTestFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseAlphaTestFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseAlphaTestFlag")]
		extern static int  dx_GetUseAlphaTestFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseAlphaTestFlag")]
		extern static int  dx_GetUseAlphaTestFlag_x64( );
		public static int  GetUseAlphaTestFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseAlphaTestFlag_x86( );
			}
			else
			{
				return dx_GetUseAlphaTestFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseNoBlendModeParam")]
		extern static int  dx_SetUseNoBlendModeParam_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseNoBlendModeParam")]
		extern static int  dx_SetUseNoBlendModeParam_x64( int  Flag);
		public static int  SetUseNoBlendModeParam( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseNoBlendModeParam_x86( Flag );
			}
			else
			{
				return dx_SetUseNoBlendModeParam_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidAlphaChannelGraphCreateFlag")]
		extern static int  dx_SetDrawValidAlphaChannelGraphCreateFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawValidAlphaChannelGraphCreateFlag")]
		extern static int  dx_SetDrawValidAlphaChannelGraphCreateFlag_x64( int  Flag);
		public static int  SetDrawValidAlphaChannelGraphCreateFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawValidAlphaChannelGraphCreateFlag_x86( Flag );
			}
			else
			{
				return dx_SetDrawValidAlphaChannelGraphCreateFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawValidAlphaChannelGraphCreateFlag")]
		extern static int  dx_GetDrawValidAlphaChannelGraphCreateFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawValidAlphaChannelGraphCreateFlag")]
		extern static int  dx_GetDrawValidAlphaChannelGraphCreateFlag_x64( );
		public static int  GetDrawValidAlphaChannelGraphCreateFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawValidAlphaChannelGraphCreateFlag_x86( );
			}
			else
			{
				return dx_GetDrawValidAlphaChannelGraphCreateFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidFloatTypeGraphCreateFlag")]
		extern static int  dx_SetDrawValidFloatTypeGraphCreateFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawValidFloatTypeGraphCreateFlag")]
		extern static int  dx_SetDrawValidFloatTypeGraphCreateFlag_x64( int  Flag);
		public static int  SetDrawValidFloatTypeGraphCreateFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawValidFloatTypeGraphCreateFlag_x86( Flag );
			}
			else
			{
				return dx_SetDrawValidFloatTypeGraphCreateFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawValidFloatTypeGraphCreateFlag")]
		extern static int  dx_GetDrawValidFloatTypeGraphCreateFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawValidFloatTypeGraphCreateFlag")]
		extern static int  dx_GetDrawValidFloatTypeGraphCreateFlag_x64( );
		public static int  GetDrawValidFloatTypeGraphCreateFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawValidFloatTypeGraphCreateFlag_x86( );
			}
			else
			{
				return dx_GetDrawValidFloatTypeGraphCreateFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidGraphCreateZBufferFlag")]
		extern static int  dx_SetDrawValidGraphCreateZBufferFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawValidGraphCreateZBufferFlag")]
		extern static int  dx_SetDrawValidGraphCreateZBufferFlag_x64( int  Flag);
		public static int  SetDrawValidGraphCreateZBufferFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawValidGraphCreateZBufferFlag_x86( Flag );
			}
			else
			{
				return dx_SetDrawValidGraphCreateZBufferFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawValidGraphCreateZBufferFlag")]
		extern static int  dx_GetDrawValidGraphCreateZBufferFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawValidGraphCreateZBufferFlag")]
		extern static int  dx_GetDrawValidGraphCreateZBufferFlag_x64( );
		public static int  GetDrawValidGraphCreateZBufferFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawValidGraphCreateZBufferFlag_x86( );
			}
			else
			{
				return dx_GetDrawValidGraphCreateZBufferFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCreateDrawValidGraphChannelNum")]
		extern static int  dx_SetCreateDrawValidGraphChannelNum_x86( int  ChannelNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCreateDrawValidGraphChannelNum")]
		extern static int  dx_SetCreateDrawValidGraphChannelNum_x64( int  ChannelNum);
		public static int  SetCreateDrawValidGraphChannelNum( int  ChannelNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCreateDrawValidGraphChannelNum_x86( ChannelNum );
			}
			else
			{
				return dx_SetCreateDrawValidGraphChannelNum_x64( ChannelNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCreateDrawValidGraphChannelNum")]
		extern static int  dx_GetCreateDrawValidGraphChannelNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCreateDrawValidGraphChannelNum")]
		extern static int  dx_GetCreateDrawValidGraphChannelNum_x64( );
		public static int  GetCreateDrawValidGraphChannelNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCreateDrawValidGraphChannelNum_x86( );
			}
			else
			{
				return dx_GetCreateDrawValidGraphChannelNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawValidMultiSample")]
		extern static int  dx_SetDrawValidMultiSample_x86( int  Samples, int  Quality);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawValidMultiSample")]
		extern static int  dx_SetDrawValidMultiSample_x64( int  Samples, int  Quality);
		public static int  SetDrawValidMultiSample( int  Samples, int  Quality)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawValidMultiSample_x86( Samples , Quality );
			}
			else
			{
				return dx_SetDrawValidMultiSample_x64( Samples , Quality );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMultiSampleQuality")]
		extern static int  dx_GetMultiSampleQuality_x86( int  Samples);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMultiSampleQuality")]
		extern static int  dx_GetMultiSampleQuality_x64( int  Samples);
		public static int  GetMultiSampleQuality( int  Samples)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMultiSampleQuality_x86( Samples );
			}
			else
			{
				return dx_GetMultiSampleQuality_x64( Samples );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseTransColor")]
		extern static int  dx_SetUseTransColor_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseTransColor")]
		extern static int  dx_SetUseTransColor_x64( int  Flag);
		public static int  SetUseTransColor( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseTransColor_x86( Flag );
			}
			else
			{
				return dx_SetUseTransColor_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseTransColorGraphCreateFlag")]
		extern static int  dx_SetUseTransColorGraphCreateFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseTransColorGraphCreateFlag")]
		extern static int  dx_SetUseTransColorGraphCreateFlag_x64( int  Flag);
		public static int  SetUseTransColorGraphCreateFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseTransColorGraphCreateFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseTransColorGraphCreateFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseGraphAlphaChannel")]
		extern static int  dx_SetUseGraphAlphaChannel_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseGraphAlphaChannel")]
		extern static int  dx_SetUseGraphAlphaChannel_x64( int  Flag);
		public static int  SetUseGraphAlphaChannel( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseGraphAlphaChannel_x86( Flag );
			}
			else
			{
				return dx_SetUseGraphAlphaChannel_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseGraphAlphaChannel")]
		extern static int  dx_GetUseGraphAlphaChannel_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseGraphAlphaChannel")]
		extern static int  dx_GetUseGraphAlphaChannel_x64( );
		public static int  GetUseGraphAlphaChannel( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseGraphAlphaChannel_x86( );
			}
			else
			{
				return dx_GetUseGraphAlphaChannel_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseAlphaChannelGraphCreateFlag")]
		extern static int  dx_SetUseAlphaChannelGraphCreateFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseAlphaChannelGraphCreateFlag")]
		extern static int  dx_SetUseAlphaChannelGraphCreateFlag_x64( int  Flag);
		public static int  SetUseAlphaChannelGraphCreateFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseAlphaChannelGraphCreateFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseAlphaChannelGraphCreateFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseAlphaChannelGraphCreateFlag")]
		extern static int  dx_GetUseAlphaChannelGraphCreateFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseAlphaChannelGraphCreateFlag")]
		extern static int  dx_GetUseAlphaChannelGraphCreateFlag_x64( );
		public static int  GetUseAlphaChannelGraphCreateFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseAlphaChannelGraphCreateFlag_x86( );
			}
			else
			{
				return dx_GetUseAlphaChannelGraphCreateFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseNotManageTextureFlag")]
		extern static int  dx_SetUseNotManageTextureFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseNotManageTextureFlag")]
		extern static int  dx_SetUseNotManageTextureFlag_x64( int  Flag);
		public static int  SetUseNotManageTextureFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseNotManageTextureFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseNotManageTextureFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseNotManageTextureFlag")]
		extern static int  dx_GetUseNotManageTextureFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseNotManageTextureFlag")]
		extern static int  dx_GetUseNotManageTextureFlag_x64( );
		public static int  GetUseNotManageTextureFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseNotManageTextureFlag_x86( );
			}
			else
			{
				return dx_GetUseNotManageTextureFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransColor")]
		extern static int  dx_SetTransColor_x86( int  Red, int  Green, int  Blue);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetTransColor")]
		extern static int  dx_SetTransColor_x64( int  Red, int  Green, int  Blue);
		public static int  SetTransColor( int  Red, int  Green, int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTransColor_x86( Red , Green , Blue );
			}
			else
			{
				return dx_SetTransColor_x64( Red , Green , Blue );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransColor")]
		extern static int  dx_GetTransColor_x86( out int  Red, out int  Green, out int  Blue);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetTransColor")]
		extern static int  dx_GetTransColor_x64( out int  Red, out int  Green, out int  Blue);
		public static int  GetTransColor( out int  Red, out int  Green, out int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetTransColor_x86( out Red , out Green , out Blue );
			}
			else
			{
				return dx_GetTransColor_x64( out Red , out Green , out Blue );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDivGraphFlag")]
		extern static int  dx_SetUseDivGraphFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseDivGraphFlag")]
		extern static int  dx_SetUseDivGraphFlag_x64( int  Flag);
		public static int  SetUseDivGraphFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseDivGraphFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseDivGraphFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseMaxTextureSize")]
		extern static int  dx_SetUseMaxTextureSize_x86( int  Size);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseMaxTextureSize")]
		extern static int  dx_SetUseMaxTextureSize_x64( int  Size);
		public static int  SetUseMaxTextureSize( int  Size)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseMaxTextureSize_x86( Size );
			}
			else
			{
				return dx_SetUseMaxTextureSize_x64( Size );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseGraphBaseDataBackup")]
		extern static int  dx_SetUseGraphBaseDataBackup_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseGraphBaseDataBackup")]
		extern static int  dx_SetUseGraphBaseDataBackup_x64( int  Flag);
		public static int  SetUseGraphBaseDataBackup( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseGraphBaseDataBackup_x86( Flag );
			}
			else
			{
				return dx_SetUseGraphBaseDataBackup_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseGraphBaseDataBackup")]
		extern static int  dx_GetUseGraphBaseDataBackup_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseGraphBaseDataBackup")]
		extern static int  dx_GetUseGraphBaseDataBackup_x64( );
		public static int  GetUseGraphBaseDataBackup( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseGraphBaseDataBackup_x86( );
			}
			else
			{
				return dx_GetUseGraphBaseDataBackup_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseSystemMemGraphCreateFlag")]
		extern static int  dx_SetUseSystemMemGraphCreateFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseSystemMemGraphCreateFlag")]
		extern static int  dx_SetUseSystemMemGraphCreateFlag_x64( int  Flag);
		public static int  SetUseSystemMemGraphCreateFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseSystemMemGraphCreateFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseSystemMemGraphCreateFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseSystemMemGraphCreateFlag")]
		extern static int  dx_GetUseSystemMemGraphCreateFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseSystemMemGraphCreateFlag")]
		extern static int  dx_GetUseSystemMemGraphCreateFlag_x64( );
		public static int  GetUseSystemMemGraphCreateFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseSystemMemGraphCreateFlag_x86( );
			}
			else
			{
				return dx_GetUseSystemMemGraphCreateFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GraphUnLock")]
		extern static int  dx_GraphUnLock_x86( int  GrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GraphUnLock")]
		extern static int  dx_GraphUnLock_x64( int  GrHandle);
		public static int  GraphUnLock( int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GraphUnLock_x86( GrHandle );
			}
			else
			{
				return dx_GraphUnLock_x64( GrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseGraphZBuffer")]
		extern static int  dx_SetUseGraphZBuffer_x86( int  GrHandle, int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseGraphZBuffer")]
		extern static int  dx_SetUseGraphZBuffer_x64( int  GrHandle, int  UseFlag);
		public static int  SetUseGraphZBuffer( int  GrHandle, int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseGraphZBuffer_x86( GrHandle , UseFlag );
			}
			else
			{
				return dx_SetUseGraphZBuffer_x64( GrHandle , UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CopyGraphZBufferImage")]
		extern static int  dx_CopyGraphZBufferImage_x86( int  DestGrHandle, int  SrcGrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CopyGraphZBufferImage")]
		extern static int  dx_CopyGraphZBufferImage_x64( int  DestGrHandle, int  SrcGrHandle);
		public static int  CopyGraphZBufferImage( int  DestGrHandle, int  SrcGrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CopyGraphZBufferImage_x86( DestGrHandle , SrcGrHandle );
			}
			else
			{
				return dx_CopyGraphZBufferImage_x64( DestGrHandle , SrcGrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphSize")]
		extern static int  dx_GetGraphSize_x86( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetGraphSize")]
		extern static int  dx_GetGraphSize_x64( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf);
		public static int  GetGraphSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetGraphSize_x86( GrHandle , out SizeXBuf , out SizeYBuf );
			}
			else
			{
				return dx_GetGraphSize_x64( GrHandle , out SizeXBuf , out SizeYBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphTextureSize")]
		extern static int  dx_GetGraphTextureSize_x86( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetGraphTextureSize")]
		extern static int  dx_GetGraphTextureSize_x64( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf);
		public static int  GetGraphTextureSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetGraphTextureSize_x86( GrHandle , out SizeXBuf , out SizeYBuf );
			}
			else
			{
				return dx_GetGraphTextureSize_x64( GrHandle , out SizeXBuf , out SizeYBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphMipmapCount")]
		extern static int  dx_GetGraphMipmapCount_x86( int  GrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetGraphMipmapCount")]
		extern static int  dx_GetGraphMipmapCount_x64( int  GrHandle);
		public static int  GetGraphMipmapCount( int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetGraphMipmapCount_x86( GrHandle );
			}
			else
			{
				return dx_GetGraphMipmapCount_x64( GrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphFilePath")]
		extern static int  dx_GetGraphFilePath_x86( int  GrHandle, System.Text.StringBuilder  FilePathBuffer);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetGraphFilePath")]
		extern static int  dx_GetGraphFilePath_x64( int  GrHandle, System.Text.StringBuilder  FilePathBuffer);
		public static int  GetGraphFilePath( int  GrHandle, System.Text.StringBuilder  FilePathBuffer)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetGraphFilePath_x86( GrHandle , FilePathBuffer );
			}
			else
			{
				return dx_GetGraphFilePath_x64( GrHandle , FilePathBuffer );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMaxGraphTextureSize")]
		extern static int  dx_GetMaxGraphTextureSize_x86( out int  SizeX, out int  SizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMaxGraphTextureSize")]
		extern static int  dx_GetMaxGraphTextureSize_x64( out int  SizeX, out int  SizeY);
		public static int  GetMaxGraphTextureSize( out int  SizeX, out int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMaxGraphTextureSize_x86( out SizeX , out SizeY );
			}
			else
			{
				return dx_GetMaxGraphTextureSize_x64( out SizeX , out SizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetValidRestoreShredPoint")]
		extern static int  dx_GetValidRestoreShredPoint_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetValidRestoreShredPoint")]
		extern static int  dx_GetValidRestoreShredPoint_x64( );
		public static int  GetValidRestoreShredPoint( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetValidRestoreShredPoint_x86( );
			}
			else
			{
				return dx_GetValidRestoreShredPoint_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCreateGraphColorData")]
		extern static int  dx_GetCreateGraphColorData_x86( out COLORDATA  ColorData, out IMAGEFORMATDESC  Format);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCreateGraphColorData")]
		extern static int  dx_GetCreateGraphColorData_x64( out COLORDATA  ColorData, out IMAGEFORMATDESC  Format);
		public static int  GetCreateGraphColorData( out COLORDATA  ColorData, out IMAGEFORMATDESC  Format)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCreateGraphColorData_x86( out ColorData , out Format );
			}
			else
			{
				return dx_GetCreateGraphColorData_x64( out ColorData , out Format );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphPalette")]
		extern static int  dx_GetGraphPalette_x86( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetGraphPalette")]
		extern static int  dx_GetGraphPalette_x64( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue);
		public static int  GetGraphPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetGraphPalette_x86( GrHandle , ColorIndex , out Red , out Green , out Blue );
			}
			else
			{
				return dx_GetGraphPalette_x64( GrHandle , ColorIndex , out Red , out Green , out Blue );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphOriginalPalette")]
		extern static int  dx_GetGraphOriginalPalette_x86( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetGraphOriginalPalette")]
		extern static int  dx_GetGraphOriginalPalette_x64( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue);
		public static int  GetGraphOriginalPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetGraphOriginalPalette_x86( GrHandle , ColorIndex , out Red , out Green , out Blue );
			}
			else
			{
				return dx_GetGraphOriginalPalette_x64( GrHandle , ColorIndex , out Red , out Green , out Blue );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphPalette")]
		extern static int  dx_SetGraphPalette_x86( int  GrHandle, int  ColorIndex, int  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetGraphPalette")]
		extern static int  dx_SetGraphPalette_x64( int  GrHandle, int  ColorIndex, int  Color);
		public static int  SetGraphPalette( int  GrHandle, int  ColorIndex, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetGraphPalette_x86( GrHandle , ColorIndex , Color );
			}
			else
			{
				return dx_SetGraphPalette_x64( GrHandle , ColorIndex , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetGraphPalette")]
		extern static int  dx_ResetGraphPalette_x86( int  GrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetGraphPalette")]
		extern static int  dx_ResetGraphPalette_x64( int  GrHandle);
		public static int  ResetGraphPalette( int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetGraphPalette_x86( GrHandle );
			}
			else
			{
				return dx_ResetGraphPalette_x64( GrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLine")]
		extern static int  dx_DrawLine_x86( int  x1, int  y1, int  x2, int  y2, int  Color, int  Thickness);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawLine")]
		extern static int  dx_DrawLine_x64( int  x1, int  y1, int  x2, int  y2, int  Color, int  Thickness);
		public static int  DrawLine( int  x1, int  y1, int  x2, int  y2, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawLine_x86( x1 , y1 , x2 , y2 , Color , 1 );
			}
			else
			{
				return dx_DrawLine_x64( x1 , y1 , x2 , y2 , Color , 1 );
			}
		}
		public static int  DrawLine( int  x1, int  y1, int  x2, int  y2, int  Color, int  Thickness)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawLine_x86( x1 , y1 , x2 , y2 , Color , Thickness );
			}
			else
			{
				return dx_DrawLine_x64( x1 , y1 , x2 , y2 , Color , Thickness );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBox")]
		extern static int  dx_DrawBox_x86( int  x1, int  y1, int  x2, int  y2, int  Color, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawBox")]
		extern static int  dx_DrawBox_x64( int  x1, int  y1, int  x2, int  y2, int  Color, int  FillFlag);
		public static int  DrawBox( int  x1, int  y1, int  x2, int  y2, int  Color, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawBox_x86( x1 , y1 , x2 , y2 , Color , FillFlag );
			}
			else
			{
				return dx_DrawBox_x64( x1 , y1 , x2 , y2 , Color , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawFillBox")]
		extern static int  dx_DrawFillBox_x86( int  x1, int  y1, int  x2, int  y2, int  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawFillBox")]
		extern static int  dx_DrawFillBox_x64( int  x1, int  y1, int  x2, int  y2, int  Color);
		public static int  DrawFillBox( int  x1, int  y1, int  x2, int  y2, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawFillBox_x86( x1 , y1 , x2 , y2 , Color );
			}
			else
			{
				return dx_DrawFillBox_x64( x1 , y1 , x2 , y2 , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLineBox")]
		extern static int  dx_DrawLineBox_x86( int  x1, int  y1, int  x2, int  y2, int  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawLineBox")]
		extern static int  dx_DrawLineBox_x64( int  x1, int  y1, int  x2, int  y2, int  Color);
		public static int  DrawLineBox( int  x1, int  y1, int  x2, int  y2, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawLineBox_x86( x1 , y1 , x2 , y2 , Color );
			}
			else
			{
				return dx_DrawLineBox_x64( x1 , y1 , x2 , y2 , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCircle")]
		extern static int  dx_DrawCircle_x86( int  x, int  y, int  r, int  Color, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawCircle")]
		extern static int  dx_DrawCircle_x64( int  x, int  y, int  r, int  Color, int  FillFlag);
		public static int  DrawCircle( int  x, int  y, int  r, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawCircle_x86( x , y , r , Color , TRUE );
			}
			else
			{
				return dx_DrawCircle_x64( x , y , r , Color , TRUE );
			}
		}
		public static int  DrawCircle( int  x, int  y, int  r, int  Color, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawCircle_x86( x , y , r , Color , FillFlag );
			}
			else
			{
				return dx_DrawCircle_x64( x , y , r , Color , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawOval")]
		extern static int  dx_DrawOval_x86( int  x, int  y, int  rx, int  ry, int  Color, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawOval")]
		extern static int  dx_DrawOval_x64( int  x, int  y, int  rx, int  ry, int  Color, int  FillFlag);
		public static int  DrawOval( int  x, int  y, int  rx, int  ry, int  Color, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawOval_x86( x , y , rx , ry , Color , FillFlag );
			}
			else
			{
				return dx_DrawOval_x64( x , y , rx , ry , Color , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTriangle")]
		extern static int  dx_DrawTriangle_x86( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  Color, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawTriangle")]
		extern static int  dx_DrawTriangle_x64( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  Color, int  FillFlag);
		public static int  DrawTriangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  Color, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawTriangle_x86( x1 , y1 , x2 , y2 , x3 , y3 , Color , FillFlag );
			}
			else
			{
				return dx_DrawTriangle_x64( x1 , y1 , x2 , y2 , x3 , y3 , Color , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawQuadrangle")]
		extern static int  dx_DrawQuadrangle_x86( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  Color, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawQuadrangle")]
		extern static int  dx_DrawQuadrangle_x64( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  Color, int  FillFlag);
		public static int  DrawQuadrangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  Color, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawQuadrangle_x86( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FillFlag );
			}
			else
			{
				return dx_DrawQuadrangle_x64( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixel")]
		extern static int  dx_DrawPixel_x86( int  x, int  y, int  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPixel")]
		extern static int  dx_DrawPixel_x64( int  x, int  y, int  Color);
		public static int  DrawPixel( int  x, int  y, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPixel_x86( x , y , Color );
			}
			else
			{
				return dx_DrawPixel_x64( x , y , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Paint")]
		extern static int  dx_Paint_x86( int  x, int  y, int  FillColor, int  BoundaryColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Paint")]
		extern static int  dx_Paint_x64( int  x, int  y, int  FillColor, int  BoundaryColor);
		public static int  Paint( int  x, int  y, int  FillColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Paint_x86( x , y , FillColor , -1 );
			}
			else
			{
				return dx_Paint_x64( x , y , FillColor , -1 );
			}
		}
		public static int  Paint( int  x, int  y, int  FillColor, int  BoundaryColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Paint_x86( x , y , FillColor , BoundaryColor );
			}
			else
			{
				return dx_Paint_x64( x , y , FillColor , BoundaryColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelSet")]
		extern static int  dx_DrawPixelSet_x86( out POINTDATA  PointData, int  Num);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPixelSet")]
		extern static int  dx_DrawPixelSet_x64( out POINTDATA  PointData, int  Num);
		public static int  DrawPixelSet( out POINTDATA  PointData, int  Num)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPixelSet_x86( out PointData , Num );
			}
			else
			{
				return dx_DrawPixelSet_x64( out PointData , Num );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLineSet")]
		extern static int  dx_DrawLineSet_x86( out LINEDATA  LineData, int  Num);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawLineSet")]
		extern static int  dx_DrawLineSet_x64( out LINEDATA  LineData, int  Num);
		public static int  DrawLineSet( out LINEDATA  LineData, int  Num)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawLineSet_x86( out LineData , Num );
			}
			else
			{
				return dx_DrawLineSet_x64( out LineData , Num );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixel3D")]
		extern static int  dx_DrawPixel3D_x86( VECTOR  Pos, int  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPixel3D")]
		extern static int  dx_DrawPixel3D_x64( VECTOR  Pos, int  Color);
		public static int  DrawPixel3D( VECTOR  Pos, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPixel3D_x86( Pos , Color );
			}
			else
			{
				return dx_DrawPixel3D_x64( Pos , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLine3D")]
		extern static int  dx_DrawLine3D_x86( VECTOR  Pos1, VECTOR  Pos2, int  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawLine3D")]
		extern static int  dx_DrawLine3D_x64( VECTOR  Pos1, VECTOR  Pos2, int  Color);
		public static int  DrawLine3D( VECTOR  Pos1, VECTOR  Pos2, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawLine3D_x86( Pos1 , Pos2 , Color );
			}
			else
			{
				return dx_DrawLine3D_x64( Pos1 , Pos2 , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTriangle3D")]
		extern static int  dx_DrawTriangle3D_x86( VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3, int  Color, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawTriangle3D")]
		extern static int  dx_DrawTriangle3D_x64( VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3, int  Color, int  FillFlag);
		public static int  DrawTriangle3D( VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3, int  Color, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawTriangle3D_x86( Pos1 , Pos2 , Pos3 , Color , FillFlag );
			}
			else
			{
				return dx_DrawTriangle3D_x64( Pos1 , Pos2 , Pos3 , Color , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCube3D")]
		extern static int  dx_DrawCube3D_x86( VECTOR  Pos1, VECTOR  Pos2, int  DifColor, int  SpcColor, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawCube3D")]
		extern static int  dx_DrawCube3D_x64( VECTOR  Pos1, VECTOR  Pos2, int  DifColor, int  SpcColor, int  FillFlag);
		public static int  DrawCube3D( VECTOR  Pos1, VECTOR  Pos2, int  DifColor, int  SpcColor, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawCube3D_x86( Pos1 , Pos2 , DifColor , SpcColor , FillFlag );
			}
			else
			{
				return dx_DrawCube3D_x64( Pos1 , Pos2 , DifColor , SpcColor , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawSphere3D")]
		extern static int  dx_DrawSphere3D_x86( VECTOR  CenterPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawSphere3D")]
		extern static int  dx_DrawSphere3D_x64( VECTOR  CenterPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag);
		public static int  DrawSphere3D( VECTOR  CenterPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawSphere3D_x86( CenterPos , r , DivNum , DifColor , SpcColor , FillFlag );
			}
			else
			{
				return dx_DrawSphere3D_x64( CenterPos , r , DivNum , DifColor , SpcColor , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCapsule3D")]
		extern static int  dx_DrawCapsule3D_x86( VECTOR  Pos1, VECTOR  Pos2, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawCapsule3D")]
		extern static int  dx_DrawCapsule3D_x64( VECTOR  Pos1, VECTOR  Pos2, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag);
		public static int  DrawCapsule3D( VECTOR  Pos1, VECTOR  Pos2, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawCapsule3D_x86( Pos1 , Pos2 , r , DivNum , DifColor , SpcColor , FillFlag );
			}
			else
			{
				return dx_DrawCapsule3D_x64( Pos1 , Pos2 , r , DivNum , DifColor , SpcColor , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCone3D")]
		extern static int  dx_DrawCone3D_x86( VECTOR  TopPos, VECTOR  BottomPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawCone3D")]
		extern static int  dx_DrawCone3D_x64( VECTOR  TopPos, VECTOR  BottomPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag);
		public static int  DrawCone3D( VECTOR  TopPos, VECTOR  BottomPos, float  r, int  DivNum, int  DifColor, int  SpcColor, int  FillFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawCone3D_x86( TopPos , BottomPos , r , DivNum , DifColor , SpcColor , FillFlag );
			}
			else
			{
				return dx_DrawCone3D_x64( TopPos , BottomPos , r , DivNum , DifColor , SpcColor , FillFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadGraphScreen")]
		extern static int  dx_LoadGraphScreen_x86( int  x, int  y, string  GraphName, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadGraphScreen")]
		extern static int  dx_LoadGraphScreen_x64( int  x, int  y, string  GraphName, int  TransFlag);
		public static int  LoadGraphScreen( int  x, int  y, string  GraphName, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadGraphScreen_x86( x , y , GraphName , TransFlag );
			}
			else
			{
				return dx_LoadGraphScreen_x64( x , y , GraphName , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawGraph")]
		extern static int  dx_DrawGraph_x86( int  x, int  y, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawGraph")]
		extern static int  dx_DrawGraph_x64( int  x, int  y, int  GrHandle, int  TransFlag);
		public static int  DrawGraph( int  x, int  y, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawGraph_x86( x , y , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawGraph_x64( x , y , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendGraph")]
		extern static int  dx_DrawExtendGraph_x86( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendGraph")]
		extern static int  dx_DrawExtendGraph_x64( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  TransFlag);
		public static int  DrawExtendGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendGraph_x86( x1 , y1 , x2 , y2 , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawExtendGraph_x64( x1 , y1 , x2 , y2 , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph")]
		extern static int  dx_DrawRotaGraph_x86( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraph")]
		extern static int  dx_DrawRotaGraph_x64( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph_x86( x , y , ExRate , Angle , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawRotaGraph_x64( x , y , ExRate , Angle , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawRotaGraph( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph_x86( x , y , ExRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraph_x64( x , y , ExRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph2")]
		extern static int  dx_DrawRotaGraph2_x86( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraph2")]
		extern static int  dx_DrawRotaGraph2_x64( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph2( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph2_x86( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawRotaGraph2_x64( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawRotaGraph2( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph2_x86( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraph2_x64( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph3")]
		extern static int  dx_DrawRotaGraph3_x86( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraph3")]
		extern static int  dx_DrawRotaGraph3_x64( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph3( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph3_x86( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawRotaGraph3_x64( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawRotaGraph3( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph3_x86( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraph3_x64( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawModiGraph")]
		extern static int  dx_DrawModiGraph_x86( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawModiGraph")]
		extern static int  dx_DrawModiGraph_x64( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  TransFlag);
		public static int  DrawModiGraph( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawModiGraph_x86( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawModiGraph_x64( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTurnGraph")]
		extern static int  dx_DrawTurnGraph_x86( int  x, int  y, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawTurnGraph")]
		extern static int  dx_DrawTurnGraph_x64( int  x, int  y, int  GrHandle, int  TransFlag);
		public static int  DrawTurnGraph( int  x, int  y, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawTurnGraph_x86( x , y , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawTurnGraph_x64( x , y , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawGraphF")]
		extern static int  dx_DrawGraphF_x86( float  xf, float  yf, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawGraphF")]
		extern static int  dx_DrawGraphF_x64( float  xf, float  yf, int  GrHandle, int  TransFlag);
		public static int  DrawGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawGraphF_x86( xf , yf , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawGraphF_x64( xf , yf , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendGraphF")]
		extern static int  dx_DrawExtendGraphF_x86( float  x1f, float  y1f, float  x2f, float  y2, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendGraphF")]
		extern static int  dx_DrawExtendGraphF_x64( float  x1f, float  y1f, float  x2f, float  y2, int  GrHandle, int  TransFlag);
		public static int  DrawExtendGraphF( float  x1f, float  y1f, float  x2f, float  y2, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendGraphF_x86( x1f , y1f , x2f , y2 , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawExtendGraphF_x64( x1f , y1f , x2f , y2 , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraphF")]
		extern static int  dx_DrawRotaGraphF_x86( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraphF")]
		extern static int  dx_DrawRotaGraphF_x64( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraphF( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraphF_x86( xf , yf , ExRate , Angle , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawRotaGraphF_x64( xf , yf , ExRate , Angle , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawRotaGraphF( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraphF_x86( xf , yf , ExRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraphF_x64( xf , yf , ExRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph2F")]
		extern static int  dx_DrawRotaGraph2F_x86( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraph2F")]
		extern static int  dx_DrawRotaGraph2F_x64( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph2F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph2F_x86( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawRotaGraph2F_x64( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawRotaGraph2F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph2F_x86( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraph2F_x64( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph3F")]
		extern static int  dx_DrawRotaGraph3F_x86( float  xf, float  yf, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraph3F")]
		extern static int  dx_DrawRotaGraph3F_x64( float  xf, float  yf, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph3F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph3F_x86( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawRotaGraph3F_x64( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawRotaGraph3F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph3F_x86( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraph3F_x64( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawModiGraphF")]
		extern static int  dx_DrawModiGraphF_x86( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawModiGraphF")]
		extern static int  dx_DrawModiGraphF_x64( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag);
		public static int  DrawModiGraphF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawModiGraphF_x86( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawModiGraphF_x64( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTurnGraphF")]
		extern static int  dx_DrawTurnGraphF_x86( float  xf, float  yf, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawTurnGraphF")]
		extern static int  dx_DrawTurnGraphF_x64( float  xf, float  yf, int  GrHandle, int  TransFlag);
		public static int  DrawTurnGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawTurnGraphF_x86( xf , yf , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawTurnGraphF_x64( xf , yf , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTile")]
		extern static int  dx_DrawTile_x86( int  x1, int  y1, int  x2, int  y2, int  Tx, int  Ty, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawTile")]
		extern static int  dx_DrawTile_x64( int  x1, int  y1, int  x2, int  y2, int  Tx, int  Ty, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag);
		public static int  DrawTile( int  x1, int  y1, int  x2, int  y2, int  Tx, int  Ty, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawTile_x86( x1 , y1 , x2 , y2 , Tx , Ty , ExtRate , Angle , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawTile_x64( x1 , y1 , x2 , y2 , Tx , Ty , ExtRate , Angle , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectGraph")]
		extern static int  dx_DrawRectGraph_x86( int  DestX, int  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectGraph")]
		extern static int  dx_DrawRectGraph_x64( int  DestX, int  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectGraph( int  DestX, int  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectGraph_x86( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRectGraph_x64( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectExtendGraph")]
		extern static int  dx_DrawRectExtendGraph_x86( int  DestX1, int  DestY1, int  DestX2, int  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectExtendGraph")]
		extern static int  dx_DrawRectExtendGraph_x64( int  DestX1, int  DestY1, int  DestX2, int  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag);
		public static int  DrawRectExtendGraph( int  DestX1, int  DestY1, int  DestX2, int  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectExtendGraph_x86( DestX1 , DestY1 , DestX2 , DestY2 , SrcX , SrcY , SrcWidth , SrcHeight , GraphHandle , TransFlag );
			}
			else
			{
				return dx_DrawRectExtendGraph_x64( DestX1 , DestY1 , DestX2 , DestY2 , SrcX , SrcY , SrcWidth , SrcHeight , GraphHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectRotaGraph")]
		extern static int  dx_DrawRectRotaGraph_x86( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectRotaGraph")]
		extern static int  dx_DrawRectRotaGraph_x64( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectRotaGraph( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectRotaGraph_x86( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRectRotaGraph_x64( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectRotaGraph2")]
		extern static int  dx_DrawRectRotaGraph2_x86( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectRotaGraph2")]
		extern static int  dx_DrawRectRotaGraph2_x64( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectRotaGraph2( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectRotaGraph2_x86( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRectRotaGraph2_x64( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectRotaGraph3")]
		extern static int  dx_DrawRectRotaGraph3_x86( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectRotaGraph3")]
		extern static int  dx_DrawRectRotaGraph3_x64( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectRotaGraph3( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectRotaGraph3_x86( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRectRotaGraph3_x64( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectGraphF")]
		extern static int  dx_DrawRectGraphF_x86( float  DestX, float  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectGraphF")]
		extern static int  dx_DrawRectGraphF_x64( float  DestX, float  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectGraphF( float  DestX, float  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectGraphF_x86( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRectGraphF_x64( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectExtendGraphF")]
		extern static int  dx_DrawRectExtendGraphF_x86( float  DestX1, float  DestY1, float  DestX2, float  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectExtendGraphF")]
		extern static int  dx_DrawRectExtendGraphF_x64( float  DestX1, float  DestY1, float  DestX2, float  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag);
		public static int  DrawRectExtendGraphF( float  DestX1, float  DestY1, float  DestX2, float  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectExtendGraphF_x86( DestX1 , DestY1 , DestX2 , DestY2 , SrcX , SrcY , SrcWidth , SrcHeight , GraphHandle , TransFlag );
			}
			else
			{
				return dx_DrawRectExtendGraphF_x64( DestX1 , DestY1 , DestX2 , DestY2 , SrcX , SrcY , SrcWidth , SrcHeight , GraphHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectRotaGraphF")]
		extern static int  dx_DrawRectRotaGraphF_x86( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectRotaGraphF")]
		extern static int  dx_DrawRectRotaGraphF_x64( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectRotaGraphF( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectRotaGraphF_x86( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRectRotaGraphF_x64( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectRotaGraph2F")]
		extern static int  dx_DrawRectRotaGraph2F_x86( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectRotaGraph2F")]
		extern static int  dx_DrawRectRotaGraph2F_x64( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectRotaGraph2F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectRotaGraph2F_x86( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRectRotaGraph2F_x64( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRate , Angle , GraphHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRectRotaGraph3F")]
		extern static int  dx_DrawRectRotaGraph3F_x86( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRectRotaGraph3F")]
		extern static int  dx_DrawRectRotaGraph3F_x64( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRectRotaGraph3F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRectRotaGraph3F_x86( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRectRotaGraph3F_x64( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBlendGraph")]
		extern static int  dx_DrawBlendGraph_x86( int  x, int  y, int  GrHandle, int  TransFlag, int  BlendGraph, int  BorderParam, int  BorderRange);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawBlendGraph")]
		extern static int  dx_DrawBlendGraph_x64( int  x, int  y, int  GrHandle, int  TransFlag, int  BlendGraph, int  BorderParam, int  BorderRange);
		public static int  DrawBlendGraph( int  x, int  y, int  GrHandle, int  TransFlag, int  BlendGraph, int  BorderParam, int  BorderRange)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawBlendGraph_x86( x , y , GrHandle , TransFlag , BlendGraph , BorderParam , BorderRange );
			}
			else
			{
				return dx_DrawBlendGraph_x64( x , y , GrHandle , TransFlag , BlendGraph , BorderParam , BorderRange );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBlendGraphPos")]
		extern static int  dx_DrawBlendGraphPos_x86( int  x, int  y, int  GrHandle, int  TransFlag, int  bx, int  by, int  BlendGraph, int  BorderParam, int  BorderRange);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawBlendGraphPos")]
		extern static int  dx_DrawBlendGraphPos_x64( int  x, int  y, int  GrHandle, int  TransFlag, int  bx, int  by, int  BlendGraph, int  BorderParam, int  BorderRange);
		public static int  DrawBlendGraphPos( int  x, int  y, int  GrHandle, int  TransFlag, int  bx, int  by, int  BlendGraph, int  BorderParam, int  BorderRange)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawBlendGraphPos_x86( x , y , GrHandle , TransFlag , bx , by , BlendGraph , BorderParam , BorderRange );
			}
			else
			{
				return dx_DrawBlendGraphPos_x64( x , y , GrHandle , TransFlag , bx , by , BlendGraph , BorderParam , BorderRange );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCircleGauge")]
		extern static int  dx_DrawCircleGauge_x86( int  CenterX, int  CenterY, double  Percent, int  GrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawCircleGauge")]
		extern static int  dx_DrawCircleGauge_x64( int  CenterX, int  CenterY, double  Percent, int  GrHandle);
		public static int  DrawCircleGauge( int  CenterX, int  CenterY, double  Percent, int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawCircleGauge_x86( CenterX , CenterY , Percent , GrHandle );
			}
			else
			{
				return dx_DrawCircleGauge_x64( CenterX , CenterY , Percent , GrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawGraphToZBuffer")]
		extern static int  dx_DrawGraphToZBuffer_x86( int  X, int  Y, int  GrHandle, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawGraphToZBuffer")]
		extern static int  dx_DrawGraphToZBuffer_x64( int  X, int  Y, int  GrHandle, int  WriteZMode);
		public static int  DrawGraphToZBuffer( int  X, int  Y, int  GrHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawGraphToZBuffer_x86( X , Y , GrHandle , WriteZMode );
			}
			else
			{
				return dx_DrawGraphToZBuffer_x64( X , Y , GrHandle , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawTurnGraphToZBuffer")]
		extern static int  dx_DrawTurnGraphToZBuffer_x86( int  x, int  y, int  GrHandle, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawTurnGraphToZBuffer")]
		extern static int  dx_DrawTurnGraphToZBuffer_x64( int  x, int  y, int  GrHandle, int  WriteZMode);
		public static int  DrawTurnGraphToZBuffer( int  x, int  y, int  GrHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawTurnGraphToZBuffer_x86( x , y , GrHandle , WriteZMode );
			}
			else
			{
				return dx_DrawTurnGraphToZBuffer_x64( x , y , GrHandle , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendGraphToZBuffer")]
		extern static int  dx_DrawExtendGraphToZBuffer_x86( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendGraphToZBuffer")]
		extern static int  dx_DrawExtendGraphToZBuffer_x64( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  WriteZMode);
		public static int  DrawExtendGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendGraphToZBuffer_x86( x1 , y1 , x2 , y2 , GrHandle , WriteZMode );
			}
			else
			{
				return dx_DrawExtendGraphToZBuffer_x64( x1 , y1 , x2 , y2 , GrHandle , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraphToZBuffer")]
		extern static int  dx_DrawRotaGraphToZBuffer_x86( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraphToZBuffer")]
		extern static int  dx_DrawRotaGraphToZBuffer_x64( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag);
		public static int  DrawRotaGraphToZBuffer( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraphToZBuffer_x86( x , y , ExRate , Angle , GrHandle , WriteZMode , FALSE );
			}
			else
			{
				return dx_DrawRotaGraphToZBuffer_x64( x , y , ExRate , Angle , GrHandle , WriteZMode , FALSE );
			}
		}
		public static int  DrawRotaGraphToZBuffer( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraphToZBuffer_x86( x , y , ExRate , Angle , GrHandle , WriteZMode , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraphToZBuffer_x64( x , y , ExRate , Angle , GrHandle , WriteZMode , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph2ToZBuffer")]
		extern static int  dx_DrawRotaGraph2ToZBuffer_x86( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraph2ToZBuffer")]
		extern static int  dx_DrawRotaGraph2ToZBuffer_x64( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag);
		public static int  DrawRotaGraph2ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph2ToZBuffer_x86( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , FALSE );
			}
			else
			{
				return dx_DrawRotaGraph2ToZBuffer_x64( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , FALSE );
			}
		}
		public static int  DrawRotaGraph2ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph2ToZBuffer_x86( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraph2ToZBuffer_x64( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph3ToZBuffer")]
		extern static int  dx_DrawRotaGraph3ToZBuffer_x86( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraph3ToZBuffer")]
		extern static int  dx_DrawRotaGraph3ToZBuffer_x64( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag);
		public static int  DrawRotaGraph3ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph3ToZBuffer_x86( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , FALSE );
			}
			else
			{
				return dx_DrawRotaGraph3ToZBuffer_x64( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , FALSE );
			}
		}
		public static int  DrawRotaGraph3ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  WriteZMode, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph3ToZBuffer_x86( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraph3ToZBuffer_x64( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawModiGraphToZBuffer")]
		extern static int  dx_DrawModiGraphToZBuffer_x86( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawModiGraphToZBuffer")]
		extern static int  dx_DrawModiGraphToZBuffer_x64( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  WriteZMode);
		public static int  DrawModiGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawModiGraphToZBuffer_x86( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , WriteZMode );
			}
			else
			{
				return dx_DrawModiGraphToZBuffer_x64( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBoxToZBuffer")]
		extern static int  dx_DrawBoxToZBuffer_x86( int  x1, int  y1, int  x2, int  y2, int  FillFlag, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawBoxToZBuffer")]
		extern static int  dx_DrawBoxToZBuffer_x64( int  x1, int  y1, int  x2, int  y2, int  FillFlag, int  WriteZMode);
		public static int  DrawBoxToZBuffer( int  x1, int  y1, int  x2, int  y2, int  FillFlag, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawBoxToZBuffer_x86( x1 , y1 , x2 , y2 , FillFlag , WriteZMode );
			}
			else
			{
				return dx_DrawBoxToZBuffer_x64( x1 , y1 , x2 , y2 , FillFlag , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawCircleToZBuffer")]
		extern static int  dx_DrawCircleToZBuffer_x86( int  x, int  y, int  r, int  FillFlag, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawCircleToZBuffer")]
		extern static int  dx_DrawCircleToZBuffer_x64( int  x, int  y, int  r, int  FillFlag, int  WriteZMode);
		public static int  DrawCircleToZBuffer( int  x, int  y, int  r, int  FillFlag, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawCircleToZBuffer_x86( x , y , r , FillFlag , WriteZMode );
			}
			else
			{
				return dx_DrawCircleToZBuffer_x64( x , y , r , FillFlag , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon")]
		extern static int  dx_DrawPolygon_x86( out VERTEX  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag, int  UVScaling);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygon")]
		extern static int  dx_DrawPolygon_x64( out VERTEX  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag, int  UVScaling);
		public static int  DrawPolygon( out VERTEX  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon_x86( out Vertex , PolygonNum , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawPolygon_x64( out Vertex , PolygonNum , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawPolygon( out VERTEX  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag, int  UVScaling)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon_x86( out Vertex , PolygonNum , GrHandle , TransFlag , UVScaling );
			}
			else
			{
				return dx_DrawPolygon_x64( out Vertex , PolygonNum , GrHandle , TransFlag , UVScaling );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon2D")]
		extern static int  dx_DrawPolygon2D_x86( out VERTEX2D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygon2D")]
		extern static int  dx_DrawPolygon2D_x64( out VERTEX2D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon2D( out VERTEX2D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon2D_x86( out Vertex , PolygonNum , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPolygon2D_x64( out Vertex , PolygonNum , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3D")]
		extern static int  dx_DrawPolygon3D_x86( out VERTEX3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygon3D")]
		extern static int  dx_DrawPolygon3D_x64( out VERTEX3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3D( out VERTEX3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon3D_x86( out Vertex , PolygonNum , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPolygon3D_x64( out Vertex , PolygonNum , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed2D")]
		extern static int  dx_DrawPolygonIndexed2D_x86( out VERTEX2D  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygonIndexed2D")]
		extern static int  dx_DrawPolygonIndexed2D_x64( out VERTEX2D  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed2D( out VERTEX2D  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygonIndexed2D_x86( out Vertex , VertexNum , out Indices , PolygonNum , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPolygonIndexed2D_x64( out Vertex , VertexNum , out Indices , PolygonNum , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed3D")]
		extern static int  dx_DrawPolygonIndexed3D_x86( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygonIndexed3D")]
		extern static int  dx_DrawPolygonIndexed3D_x64( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed3D( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygonIndexed3D_x86( out Vertex , VertexNum , out Indices , PolygonNum , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPolygonIndexed3D_x64( out Vertex , VertexNum , out Indices , PolygonNum , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed3DBase")]
		extern static int  dx_DrawPolygonIndexed3DBase_x86( out VERTEX_3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygonIndexed3DBase")]
		extern static int  dx_DrawPolygonIndexed3DBase_x64( out VERTEX_3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed3DBase( out VERTEX_3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygonIndexed3DBase_x86( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPolygonIndexed3DBase_x64( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3DBase")]
		extern static int  dx_DrawPolygon3DBase_x86( out VERTEX_3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygon3DBase")]
		extern static int  dx_DrawPolygon3DBase_x64( out VERTEX_3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3DBase( out VERTEX_3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon3DBase_x86( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPolygon3DBase_x64( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3D_2")]
		extern static int  dx_DrawPolygon3D_2_x86( out VERTEX_3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygon3D_2")]
		extern static int  dx_DrawPolygon3D_2_x64( out VERTEX_3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3D( out VERTEX_3D  Vertex, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon3D_2_x86( out Vertex , PolygonNum , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPolygon3D_2_x64( out Vertex , PolygonNum , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonBase")]
		extern static int  dx_DrawPolygonBase_x86( out VERTEX  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag, int  UVScaling);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygonBase")]
		extern static int  dx_DrawPolygonBase_x64( out VERTEX  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag, int  UVScaling);
		public static int  DrawPolygonBase( out VERTEX  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygonBase_x86( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawPolygonBase_x64( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawPolygonBase( out VERTEX  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag, int  UVScaling)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygonBase_x86( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag , UVScaling );
			}
			else
			{
				return dx_DrawPolygonBase_x64( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag , UVScaling );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive2D")]
		extern static int  dx_DrawPrimitive2D_x86( out VERTEX2D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitive2D")]
		extern static int  dx_DrawPrimitive2D_x64( out VERTEX2D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive2D( out VERTEX2D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitive2D_x86( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPrimitive2D_x64( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3D")]
		extern static int  dx_DrawPrimitive3D_x86( out VERTEX3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitive3D")]
		extern static int  dx_DrawPrimitive3D_x64( out VERTEX3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive3D( out VERTEX3D  Vertex, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitive3D_x86( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPrimitive3D_x64( out Vertex , VertexNum , PrimitiveType , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed2D")]
		extern static int  dx_DrawPrimitiveIndexed2D_x86( out VERTEX2D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitiveIndexed2D")]
		extern static int  dx_DrawPrimitiveIndexed2D_x64( out VERTEX2D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed2D( out VERTEX2D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitiveIndexed2D_x86( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPrimitiveIndexed2D_x64( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3D")]
		extern static int  dx_DrawPrimitiveIndexed3D_x86( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitiveIndexed3D")]
		extern static int  dx_DrawPrimitiveIndexed3D_x64( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed3D( out VERTEX3D  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitiveIndexed3D_x86( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPrimitiveIndexed3D_x64( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3D_UseVertexBuffer")]
		extern static int  dx_DrawPolygon3D_UseVertexBuffer_x86( int  VertexBufHandle, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygon3D_UseVertexBuffer")]
		extern static int  dx_DrawPolygon3D_UseVertexBuffer_x64( int  VertexBufHandle, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3D_UseVertexBuffer( int  VertexBufHandle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon3D_UseVertexBuffer_x86( VertexBufHandle , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPolygon3D_UseVertexBuffer_x64( VertexBufHandle , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3D_UseVertexBuffer")]
		extern static int  dx_DrawPrimitive3D_UseVertexBuffer_x86( int  VertexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitive3D_UseVertexBuffer")]
		extern static int  dx_DrawPrimitive3D_UseVertexBuffer_x64( int  VertexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive3D_UseVertexBuffer( int  VertexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitive3D_UseVertexBuffer_x86( VertexBufHandle , PrimitiveType , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPrimitive3D_UseVertexBuffer_x64( VertexBufHandle , PrimitiveType , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3D_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitive3D_UseVertexBuffer2_x86( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitive3D_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitive3D_UseVertexBuffer2_x64( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive3D_UseVertexBuffer2( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitive3D_UseVertexBuffer2_x86( VertexBufHandle , PrimitiveType , StartVertex , UseVertexNum , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPrimitive3D_UseVertexBuffer2_x64( VertexBufHandle , PrimitiveType , StartVertex , UseVertexNum , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed3D_UseVertexBuffer")]
		extern static int  dx_DrawPolygonIndexed3D_UseVertexBuffer_x86( int  VertexBufHandle, int  IndexBufHandle, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygonIndexed3D_UseVertexBuffer")]
		extern static int  dx_DrawPolygonIndexed3D_UseVertexBuffer_x64( int  VertexBufHandle, int  IndexBufHandle, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygonIndexed3D_UseVertexBuffer_x86( VertexBufHandle , IndexBufHandle , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPolygonIndexed3D_UseVertexBuffer_x64( VertexBufHandle , IndexBufHandle , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3D_UseVertexBuffer")]
		extern static int  dx_DrawPrimitiveIndexed3D_UseVertexBuffer_x86( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitiveIndexed3D_UseVertexBuffer")]
		extern static int  dx_DrawPrimitiveIndexed3D_UseVertexBuffer_x64( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitiveIndexed3D_UseVertexBuffer_x86( VertexBufHandle , IndexBufHandle , PrimitiveType , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPrimitiveIndexed3D_UseVertexBuffer_x64( VertexBufHandle , IndexBufHandle , PrimitiveType , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3D_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitiveIndexed3D_UseVertexBuffer2_x86( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitiveIndexed3D_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitiveIndexed3D_UseVertexBuffer2_x64( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed3D_UseVertexBuffer2( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitiveIndexed3D_UseVertexBuffer2_x86( VertexBufHandle , IndexBufHandle , PrimitiveType , BaseVertex , StartVertex , UseVertexNum , StartIndex , UseIndexNum , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawPrimitiveIndexed3D_UseVertexBuffer2_x64( VertexBufHandle , IndexBufHandle , PrimitiveType , BaseVertex , StartVertex , UseVertexNum , StartIndex , UseIndexNum , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawGraph3D")]
		extern static int  dx_DrawGraph3D_x86( float  x, float  y, float  z, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawGraph3D")]
		extern static int  dx_DrawGraph3D_x64( float  x, float  y, float  z, int  GrHandle, int  TransFlag);
		public static int  DrawGraph3D( float  x, float  y, float  z, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawGraph3D_x86( x , y , z , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawGraph3D_x64( x , y , z , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendGraph3D")]
		extern static int  dx_DrawExtendGraph3D_x86( float  x, float  y, float  z, double  ExRateX, double  ExRateY, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendGraph3D")]
		extern static int  dx_DrawExtendGraph3D_x64( float  x, float  y, float  z, double  ExRateX, double  ExRateY, int  GrHandle, int  TransFlag);
		public static int  DrawExtendGraph3D( float  x, float  y, float  z, double  ExRateX, double  ExRateY, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendGraph3D_x86( x , y , z , ExRateX , ExRateY , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawExtendGraph3D_x64( x , y , z , ExRateX , ExRateY , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRotaGraph3D")]
		extern static int  dx_DrawRotaGraph3D_x86( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRotaGraph3D")]
		extern static int  dx_DrawRotaGraph3D_x64( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRotaGraph3D( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph3D_x86( x , y , z , ExRate , Angle , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawRotaGraph3D_x64( x , y , z , ExRate , Angle , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawRotaGraph3D( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRotaGraph3D_x86( x , y , z , ExRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRotaGraph3D_x64( x , y , z , ExRate , Angle , GrHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawRota2Graph3D")]
		extern static int  dx_DrawRota2Graph3D_x86( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawRota2Graph3D")]
		extern static int  dx_DrawRota2Graph3D_x64( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawRota2Graph3D( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRota2Graph3D_x86( x , y , z , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawRota2Graph3D_x64( x , y , z , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawRota2Graph3D( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawRota2Graph3D_x86( x , y , z , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawRota2Graph3D_x64( x , y , z , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawModiBillboard3D")]
		extern static int  dx_DrawModiBillboard3D_x86( VECTOR  Pos, float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawModiBillboard3D")]
		extern static int  dx_DrawModiBillboard3D_x64( VECTOR  Pos, float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag);
		public static int  DrawModiBillboard3D( VECTOR  Pos, float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawModiBillboard3D_x86( Pos , x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
			}
			else
			{
				return dx_DrawModiBillboard3D_x64( Pos , x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawBillboard3D")]
		extern static int  dx_DrawBillboard3D_x86( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawBillboard3D")]
		extern static int  dx_DrawBillboard3D_x64( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  TurnFlag);
		public static int  DrawBillboard3D( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawBillboard3D_x86( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , FALSE );
			}
			else
			{
				return dx_DrawBillboard3D_x64( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , FALSE );
			}
		}
		public static int  DrawBillboard3D( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  TurnFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawBillboard3D_x86( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , TurnFlag );
			}
			else
			{
				return dx_DrawBillboard3D_x64( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , TurnFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawMode")]
		extern static int  dx_SetDrawMode_x86( int  DrawMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawMode")]
		extern static int  dx_SetDrawMode_x64( int  DrawMode);
		public static int  SetDrawMode( int  DrawMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawMode_x86( DrawMode );
			}
			else
			{
				return dx_SetDrawMode_x64( DrawMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawMode")]
		extern static int  dx_GetDrawMode_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawMode")]
		extern static int  dx_GetDrawMode_x64( );
		public static int  GetDrawMode( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawMode_x86( );
			}
			else
			{
				return dx_GetDrawMode_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawBlendMode")]
		extern static int  dx_SetDrawBlendMode_x86( int  BlendMode, int  BlendParam);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawBlendMode")]
		extern static int  dx_SetDrawBlendMode_x64( int  BlendMode, int  BlendParam);
		public static int  SetDrawBlendMode( int  BlendMode, int  BlendParam)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawBlendMode_x86( BlendMode , BlendParam );
			}
			else
			{
				return dx_SetDrawBlendMode_x64( BlendMode , BlendParam );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawBlendMode")]
		extern static int  dx_GetDrawBlendMode_x86( out int  BlendMode, out int  BlendParam);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawBlendMode")]
		extern static int  dx_GetDrawBlendMode_x64( out int  BlendMode, out int  BlendParam);
		public static int  GetDrawBlendMode( out int  BlendMode, out int  BlendParam)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawBlendMode_x86( out BlendMode , out BlendParam );
			}
			else
			{
				return dx_GetDrawBlendMode_x64( out BlendMode , out BlendParam );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawAlphaTest")]
		extern static int  dx_SetDrawAlphaTest_x86( int  TestMode, int  TestParam);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawAlphaTest")]
		extern static int  dx_SetDrawAlphaTest_x64( int  TestMode, int  TestParam);
		public static int  SetDrawAlphaTest( int  TestMode, int  TestParam)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawAlphaTest_x86( TestMode , TestParam );
			}
			else
			{
				return dx_SetDrawAlphaTest_x64( TestMode , TestParam );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBlendGraph")]
		extern static int  dx_SetBlendGraph_x86( int  BlendGraph, int  BorderParam, int  BorderRange);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetBlendGraph")]
		extern static int  dx_SetBlendGraph_x64( int  BlendGraph, int  BorderParam, int  BorderRange);
		public static int  SetBlendGraph( int  BlendGraph, int  BorderParam, int  BorderRange)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBlendGraph_x86( BlendGraph , BorderParam , BorderRange );
			}
			else
			{
				return dx_SetBlendGraph_x64( BlendGraph , BorderParam , BorderRange );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBlendGraphPosition")]
		extern static int  dx_SetBlendGraphPosition_x86( int  x, int  y);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetBlendGraphPosition")]
		extern static int  dx_SetBlendGraphPosition_x64( int  x, int  y);
		public static int  SetBlendGraphPosition( int  x, int  y)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBlendGraphPosition_x86( x , y );
			}
			else
			{
				return dx_SetBlendGraphPosition_x64( x , y );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawBright")]
		extern static int  dx_SetDrawBright_x86( int  RedBright, int  GreenBright, int  BlueBright);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawBright")]
		extern static int  dx_SetDrawBright_x64( int  RedBright, int  GreenBright, int  BlueBright);
		public static int  SetDrawBright( int  RedBright, int  GreenBright, int  BlueBright)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawBright_x86( RedBright , GreenBright , BlueBright );
			}
			else
			{
				return dx_SetDrawBright_x64( RedBright , GreenBright , BlueBright );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawBright")]
		extern static int  dx_GetDrawBright_x86( out int  Red, out int  Green, out int  Blue);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawBright")]
		extern static int  dx_GetDrawBright_x64( out int  Red, out int  Green, out int  Blue);
		public static int  GetDrawBright( out int  Red, out int  Green, out int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawBright_x86( out Red , out Green , out Blue );
			}
			else
			{
				return dx_GetDrawBright_x64( out Red , out Green , out Blue );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetIgnoreDrawGraphColor")]
		extern static int  dx_SetIgnoreDrawGraphColor_x86( int  EnableFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetIgnoreDrawGraphColor")]
		extern static int  dx_SetIgnoreDrawGraphColor_x64( int  EnableFlag);
		public static int  SetIgnoreDrawGraphColor( int  EnableFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetIgnoreDrawGraphColor_x86( EnableFlag );
			}
			else
			{
				return dx_SetIgnoreDrawGraphColor_x64( EnableFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaxAnisotropy")]
		extern static int  dx_SetMaxAnisotropy_x86( int  MaxAnisotropy);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMaxAnisotropy")]
		extern static int  dx_SetMaxAnisotropy_x64( int  MaxAnisotropy);
		public static int  SetMaxAnisotropy( int  MaxAnisotropy)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMaxAnisotropy_x86( MaxAnisotropy );
			}
			else
			{
				return dx_SetMaxAnisotropy_x64( MaxAnisotropy );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseZBufferFlag")]
		extern static int  dx_SetUseZBufferFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseZBufferFlag")]
		extern static int  dx_SetUseZBufferFlag_x64( int  Flag);
		public static int  SetUseZBufferFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseZBufferFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseZBufferFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWriteZBufferFlag")]
		extern static int  dx_SetWriteZBufferFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWriteZBufferFlag")]
		extern static int  dx_SetWriteZBufferFlag_x64( int  Flag);
		public static int  SetWriteZBufferFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWriteZBufferFlag_x86( Flag );
			}
			else
			{
				return dx_SetWriteZBufferFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBufferCmpType")]
		extern static int  dx_SetZBufferCmpType_x86( int  CmpType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetZBufferCmpType")]
		extern static int  dx_SetZBufferCmpType_x64( int  CmpType);
		public static int  SetZBufferCmpType( int  CmpType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetZBufferCmpType_x86( CmpType );
			}
			else
			{
				return dx_SetZBufferCmpType_x64( CmpType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBias")]
		extern static int  dx_SetZBias_x86( int  Bias);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetZBias")]
		extern static int  dx_SetZBias_x64( int  Bias);
		public static int  SetZBias( int  Bias)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetZBias_x86( Bias );
			}
			else
			{
				return dx_SetZBias_x64( Bias );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseZBuffer3D")]
		extern static int  dx_SetUseZBuffer3D_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseZBuffer3D")]
		extern static int  dx_SetUseZBuffer3D_x64( int  Flag);
		public static int  SetUseZBuffer3D( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseZBuffer3D_x86( Flag );
			}
			else
			{
				return dx_SetUseZBuffer3D_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWriteZBuffer3D")]
		extern static int  dx_SetWriteZBuffer3D_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWriteZBuffer3D")]
		extern static int  dx_SetWriteZBuffer3D_x64( int  Flag);
		public static int  SetWriteZBuffer3D( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWriteZBuffer3D_x86( Flag );
			}
			else
			{
				return dx_SetWriteZBuffer3D_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBufferCmpType3D")]
		extern static int  dx_SetZBufferCmpType3D_x86( int  CmpType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetZBufferCmpType3D")]
		extern static int  dx_SetZBufferCmpType3D_x64( int  CmpType);
		public static int  SetZBufferCmpType3D( int  CmpType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetZBufferCmpType3D_x86( CmpType );
			}
			else
			{
				return dx_SetZBufferCmpType3D_x64( CmpType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBias3D")]
		extern static int  dx_SetZBias3D_x86( int  Bias);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetZBias3D")]
		extern static int  dx_SetZBias3D_x64( int  Bias);
		public static int  SetZBias3D( int  Bias)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetZBias3D_x86( Bias );
			}
			else
			{
				return dx_SetZBias3D_x64( Bias );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawZ")]
		extern static int  dx_SetDrawZ_x86( float  Z);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawZ")]
		extern static int  dx_SetDrawZ_x64( float  Z);
		public static int  SetDrawZ( float  Z)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawZ_x86( Z );
			}
			else
			{
				return dx_SetDrawZ_x64( Z );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawArea")]
		extern static int  dx_SetDrawArea_x86( int  x1, int  y1, int  x2, int  y2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawArea")]
		extern static int  dx_SetDrawArea_x64( int  x1, int  y1, int  x2, int  y2);
		public static int  SetDrawArea( int  x1, int  y1, int  x2, int  y2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawArea_x86( x1 , y1 , x2 , y2 );
			}
			else
			{
				return dx_SetDrawArea_x64( x1 , y1 , x2 , y2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawArea")]
		extern static int  dx_GetDrawArea_x86( out RECT  Rect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawArea")]
		extern static int  dx_GetDrawArea_x64( out RECT  Rect);
		public static int  GetDrawArea( out RECT  Rect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawArea_x86( out Rect );
			}
			else
			{
				return dx_GetDrawArea_x64( out Rect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawAreaFull")]
		extern static int  dx_SetDrawAreaFull_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawAreaFull")]
		extern static int  dx_SetDrawAreaFull_x64( );
		public static int  SetDrawAreaFull( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawAreaFull_x86( );
			}
			else
			{
				return dx_SetDrawAreaFull_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDraw3DScale")]
		extern static int  dx_SetDraw3DScale_x86( float  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDraw3DScale")]
		extern static int  dx_SetDraw3DScale_x64( float  Scale);
		public static int  SetDraw3DScale( float  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDraw3DScale_x86( Scale );
			}
			else
			{
				return dx_SetDraw3DScale_x64( Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RunRestoreShred")]
		extern static int  dx_RunRestoreShred_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_RunRestoreShred")]
		extern static int  dx_RunRestoreShred_x64( );
		public static int  RunRestoreShred( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_RunRestoreShred_x86( );
			}
			else
			{
				return dx_RunRestoreShred_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransformToWorld")]
		extern static int  dx_SetTransformToWorld_x86( out MATRIX  Matrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetTransformToWorld")]
		extern static int  dx_SetTransformToWorld_x64( out MATRIX  Matrix);
		public static int  SetTransformToWorld( out MATRIX  Matrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTransformToWorld_x86( out Matrix );
			}
			else
			{
				return dx_SetTransformToWorld_x64( out Matrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformToWorldMatrix")]
		extern static int  dx_GetTransformToWorldMatrix_x86( out MATRIX  MatBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetTransformToWorldMatrix")]
		extern static int  dx_GetTransformToWorldMatrix_x64( out MATRIX  MatBuf);
		public static int  GetTransformToWorldMatrix( out MATRIX  MatBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetTransformToWorldMatrix_x86( out MatBuf );
			}
			else
			{
				return dx_GetTransformToWorldMatrix_x64( out MatBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransformToView")]
		extern static int  dx_SetTransformToView_x86( out MATRIX  Matrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetTransformToView")]
		extern static int  dx_SetTransformToView_x64( out MATRIX  Matrix);
		public static int  SetTransformToView( out MATRIX  Matrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTransformToView_x86( out Matrix );
			}
			else
			{
				return dx_SetTransformToView_x64( out Matrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformToViewMatrix")]
		extern static int  dx_GetTransformToViewMatrix_x86( out MATRIX  MatBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetTransformToViewMatrix")]
		extern static int  dx_GetTransformToViewMatrix_x64( out MATRIX  MatBuf);
		public static int  GetTransformToViewMatrix( out MATRIX  MatBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetTransformToViewMatrix_x86( out MatBuf );
			}
			else
			{
				return dx_GetTransformToViewMatrix_x64( out MatBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransformToProjection")]
		extern static int  dx_SetTransformToProjection_x86( out MATRIX  Matrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetTransformToProjection")]
		extern static int  dx_SetTransformToProjection_x64( out MATRIX  Matrix);
		public static int  SetTransformToProjection( out MATRIX  Matrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTransformToProjection_x86( out Matrix );
			}
			else
			{
				return dx_SetTransformToProjection_x64( out Matrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformToProjectionMatrix")]
		extern static int  dx_GetTransformToProjectionMatrix_x86( out MATRIX  MatBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetTransformToProjectionMatrix")]
		extern static int  dx_GetTransformToProjectionMatrix_x64( out MATRIX  MatBuf);
		public static int  GetTransformToProjectionMatrix( out MATRIX  MatBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetTransformToProjectionMatrix_x86( out MatBuf );
			}
			else
			{
				return dx_GetTransformToProjectionMatrix_x64( out MatBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTransformToViewport")]
		extern static int  dx_SetTransformToViewport_x86( out MATRIX  Matrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetTransformToViewport")]
		extern static int  dx_SetTransformToViewport_x64( out MATRIX  Matrix);
		public static int  SetTransformToViewport( out MATRIX  Matrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTransformToViewport_x86( out Matrix );
			}
			else
			{
				return dx_SetTransformToViewport_x64( out Matrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformToViewportMatrix")]
		extern static int  dx_GetTransformToViewportMatrix_x86( out MATRIX  MatBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetTransformToViewportMatrix")]
		extern static int  dx_GetTransformToViewportMatrix_x64( out MATRIX  MatBuf);
		public static int  GetTransformToViewportMatrix( out MATRIX  MatBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetTransformToViewportMatrix_x86( out MatBuf );
			}
			else
			{
				return dx_GetTransformToViewportMatrix_x64( out MatBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformToAPIViewportMatrix")]
		extern static int  dx_GetTransformToAPIViewportMatrix_x86( out MATRIX  MatBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetTransformToAPIViewportMatrix")]
		extern static int  dx_GetTransformToAPIViewportMatrix_x64( out MATRIX  MatBuf);
		public static int  GetTransformToAPIViewportMatrix( out MATRIX  MatBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetTransformToAPIViewportMatrix_x86( out MatBuf );
			}
			else
			{
				return dx_GetTransformToAPIViewportMatrix_x64( out MatBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDefTransformMatrix")]
		extern static int  dx_SetDefTransformMatrix_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDefTransformMatrix")]
		extern static int  dx_SetDefTransformMatrix_x64( );
		public static int  SetDefTransformMatrix( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDefTransformMatrix_x86( );
			}
			else
			{
				return dx_SetDefTransformMatrix_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTransformPosition")]
		extern static int  dx_GetTransformPosition_x86( out VECTOR  LocalPos, out float  x, out float  y);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetTransformPosition")]
		extern static int  dx_GetTransformPosition_x64( out VECTOR  LocalPos, out float  x, out float  y);
		public static int  GetTransformPosition( out VECTOR  LocalPos, out float  x, out float  y)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetTransformPosition_x86( out LocalPos , out x , out y );
			}
			else
			{
				return dx_GetTransformPosition_x64( out LocalPos , out x , out y );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetBillboardPixelSize")]
		extern static float  dx_GetBillboardPixelSize_x86( VECTOR  WorldPos, float  WorldSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetBillboardPixelSize")]
		extern static float  dx_GetBillboardPixelSize_x64( VECTOR  WorldPos, float  WorldSize);
		public static float  GetBillboardPixelSize( VECTOR  WorldPos, float  WorldSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetBillboardPixelSize_x86( WorldPos , WorldSize );
			}
			else
			{
				return dx_GetBillboardPixelSize_x64( WorldPos , WorldSize );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvWorldPosToViewPos")]
		extern static VECTOR  dx_ConvWorldPosToViewPos_x86( VECTOR  WorldPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConvWorldPosToViewPos")]
		extern static VECTOR  dx_ConvWorldPosToViewPos_x64( VECTOR  WorldPos);
		public static VECTOR  ConvWorldPosToViewPos( VECTOR  WorldPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConvWorldPosToViewPos_x86( WorldPos );
			}
			else
			{
				return dx_ConvWorldPosToViewPos_x64( WorldPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvWorldPosToScreenPos")]
		extern static VECTOR  dx_ConvWorldPosToScreenPos_x86( VECTOR  WorldPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConvWorldPosToScreenPos")]
		extern static VECTOR  dx_ConvWorldPosToScreenPos_x64( VECTOR  WorldPos);
		public static VECTOR  ConvWorldPosToScreenPos( VECTOR  WorldPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConvWorldPosToScreenPos_x86( WorldPos );
			}
			else
			{
				return dx_ConvWorldPosToScreenPos_x64( WorldPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvWorldPosToScreenPosPlusW")]
		extern static FLOAT4  dx_ConvWorldPosToScreenPosPlusW_x86( VECTOR  WorldPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConvWorldPosToScreenPosPlusW")]
		extern static FLOAT4  dx_ConvWorldPosToScreenPosPlusW_x64( VECTOR  WorldPos);
		public static FLOAT4  ConvWorldPosToScreenPosPlusW( VECTOR  WorldPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConvWorldPosToScreenPosPlusW_x86( WorldPos );
			}
			else
			{
				return dx_ConvWorldPosToScreenPosPlusW_x64( WorldPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvScreenPosToWorldPos")]
		extern static VECTOR  dx_ConvScreenPosToWorldPos_x86( VECTOR  ScreenPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConvScreenPosToWorldPos")]
		extern static VECTOR  dx_ConvScreenPosToWorldPos_x64( VECTOR  ScreenPos);
		public static VECTOR  ConvScreenPosToWorldPos( VECTOR  ScreenPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConvScreenPosToWorldPos_x86( ScreenPos );
			}
			else
			{
				return dx_ConvScreenPosToWorldPos_x64( ScreenPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ConvScreenPosToWorldPos_ZLinear")]
		extern static VECTOR  dx_ConvScreenPosToWorldPos_ZLinear_x86( VECTOR  ScreenPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ConvScreenPosToWorldPos_ZLinear")]
		extern static VECTOR  dx_ConvScreenPosToWorldPos_ZLinear_x64( VECTOR  ScreenPos);
		public static VECTOR  ConvScreenPosToWorldPos_ZLinear( VECTOR  ScreenPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ConvScreenPosToWorldPos_ZLinear_x86( ScreenPos );
			}
			else
			{
				return dx_ConvScreenPosToWorldPos_ZLinear_x64( ScreenPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseCullingFlag")]
		extern static int  dx_SetUseCullingFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseCullingFlag")]
		extern static int  dx_SetUseCullingFlag_x64( int  Flag);
		public static int  SetUseCullingFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseCullingFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseCullingFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseBackCulling")]
		extern static int  dx_SetUseBackCulling_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseBackCulling")]
		extern static int  dx_SetUseBackCulling_x64( int  Flag);
		public static int  SetUseBackCulling( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseBackCulling_x86( Flag );
			}
			else
			{
				return dx_SetUseBackCulling_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTextureAddressMode")]
		extern static int  dx_SetTextureAddressMode_x86( int  Mode, int  Stage);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetTextureAddressMode")]
		extern static int  dx_SetTextureAddressMode_x64( int  Mode, int  Stage);
		public static int  SetTextureAddressMode( int  Mode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTextureAddressMode_x86( Mode , -1 );
			}
			else
			{
				return dx_SetTextureAddressMode_x64( Mode , -1 );
			}
		}
		public static int  SetTextureAddressMode( int  Mode, int  Stage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTextureAddressMode_x86( Mode , Stage );
			}
			else
			{
				return dx_SetTextureAddressMode_x64( Mode , Stage );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTextureAddressModeUV")]
		extern static int  dx_SetTextureAddressModeUV_x86( int  ModeU, int  ModeV, int  Stage);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetTextureAddressModeUV")]
		extern static int  dx_SetTextureAddressModeUV_x64( int  ModeU, int  ModeV, int  Stage);
		public static int  SetTextureAddressModeUV( int  ModeU, int  ModeV)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTextureAddressModeUV_x86( ModeU , ModeV , -1 );
			}
			else
			{
				return dx_SetTextureAddressModeUV_x64( ModeU , ModeV , -1 );
			}
		}
		public static int  SetTextureAddressModeUV( int  ModeU, int  ModeV, int  Stage)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTextureAddressModeUV_x86( ModeU , ModeV , Stage );
			}
			else
			{
				return dx_SetTextureAddressModeUV_x64( ModeU , ModeV , Stage );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTextureAddressTransform")]
		extern static int  dx_SetTextureAddressTransform_x86( float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetTextureAddressTransform")]
		extern static int  dx_SetTextureAddressTransform_x64( float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate);
		public static int  SetTextureAddressTransform( float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTextureAddressTransform_x86( TransU , TransV , ScaleU , ScaleV , RotCenterU , RotCenterV , Rotate );
			}
			else
			{
				return dx_SetTextureAddressTransform_x64( TransU , TransV , ScaleU , ScaleV , RotCenterU , RotCenterV , Rotate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetTextureAddressTransformMatrix")]
		extern static int  dx_SetTextureAddressTransformMatrix_x86( MATRIX  Matrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetTextureAddressTransformMatrix")]
		extern static int  dx_SetTextureAddressTransformMatrix_x64( MATRIX  Matrix);
		public static int  SetTextureAddressTransformMatrix( MATRIX  Matrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetTextureAddressTransformMatrix_x86( Matrix );
			}
			else
			{
				return dx_SetTextureAddressTransformMatrix_x64( Matrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetTextureAddressTransform")]
		extern static int  dx_ResetTextureAddressTransform_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetTextureAddressTransform")]
		extern static int  dx_ResetTextureAddressTransform_x64( );
		public static int  ResetTextureAddressTransform( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetTextureAddressTransform_x86( );
			}
			else
			{
				return dx_ResetTextureAddressTransform_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogEnable")]
		extern static int  dx_SetFogEnable_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFogEnable")]
		extern static int  dx_SetFogEnable_x64( int  Flag);
		public static int  SetFogEnable( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFogEnable_x86( Flag );
			}
			else
			{
				return dx_SetFogEnable_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogMode")]
		extern static int  dx_SetFogMode_x86( int  Mode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFogMode")]
		extern static int  dx_SetFogMode_x64( int  Mode);
		public static int  SetFogMode( int  Mode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFogMode_x86( Mode );
			}
			else
			{
				return dx_SetFogMode_x64( Mode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogColor")]
		extern static int  dx_SetFogColor_x86( int  r, int  g, int  b);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFogColor")]
		extern static int  dx_SetFogColor_x64( int  r, int  g, int  b);
		public static int  SetFogColor( int  r, int  g, int  b)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFogColor_x86( r , g , b );
			}
			else
			{
				return dx_SetFogColor_x64( r , g , b );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogStartEnd")]
		extern static int  dx_SetFogStartEnd_x86( float  start, float  end);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFogStartEnd")]
		extern static int  dx_SetFogStartEnd_x64( float  start, float  end);
		public static int  SetFogStartEnd( float  start, float  end)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFogStartEnd_x86( start , end );
			}
			else
			{
				return dx_SetFogStartEnd_x64( start , end );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFogDensity")]
		extern static int  dx_SetFogDensity_x86( float  density);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFogDensity")]
		extern static int  dx_SetFogDensity_x64( float  density);
		public static int  SetFogDensity( float  density)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFogDensity_x86( density );
			}
			else
			{
				return dx_SetFogDensity_x64( density );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixel")]
		extern static int  dx_GetPixel_x86( int  x, int  y);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetPixel")]
		extern static int  dx_GetPixel_x64( int  x, int  y);
		public static int  GetPixel( int  x, int  y)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetPixel_x86( x , y );
			}
			else
			{
				return dx_GetPixel_x64( x , y );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawScreenGraph")]
		extern static int  dx_GetDrawScreenGraph_x86( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  UseClientFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawScreenGraph")]
		extern static int  dx_GetDrawScreenGraph_x64( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  UseClientFlag);
		public static int  GetDrawScreenGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawScreenGraph_x86( x1 , y1 , x2 , y2 , GrHandle , TRUE );
			}
			else
			{
				return dx_GetDrawScreenGraph_x64( x1 , y1 , x2 , y2 , GrHandle , TRUE );
			}
		}
		public static int  GetDrawScreenGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  UseClientFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawScreenGraph_x86( x1 , y1 , x2 , y2 , GrHandle , UseClientFlag );
			}
			else
			{
				return dx_GetDrawScreenGraph_x64( x1 , y1 , x2 , y2 , GrHandle , UseClientFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltDrawValidGraph")]
		extern static int  dx_BltDrawValidGraph_x86( int  TargetDrawValidGrHandle, int  x1, int  y1, int  x2, int  y2, int  DestX, int  DestY, int  DestGrHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_BltDrawValidGraph")]
		extern static int  dx_BltDrawValidGraph_x64( int  TargetDrawValidGrHandle, int  x1, int  y1, int  x2, int  y2, int  DestX, int  DestY, int  DestGrHandle);
		public static int  BltDrawValidGraph( int  TargetDrawValidGrHandle, int  x1, int  y1, int  x2, int  y2, int  DestX, int  DestY, int  DestGrHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltDrawValidGraph_x86( TargetDrawValidGrHandle , x1 , y1 , x2 , y2 , DestX , DestY , DestGrHandle );
			}
			else
			{
				return dx_BltDrawValidGraph_x64( TargetDrawValidGrHandle , x1 , y1 , x2 , y2 , DestX , DestY , DestGrHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ScreenFlip")]
		extern static int  dx_ScreenFlip_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ScreenFlip")]
		extern static int  dx_ScreenFlip_x64( );
		public static int  ScreenFlip( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ScreenFlip_x86( );
			}
			else
			{
				return dx_ScreenFlip_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ScreenCopy")]
		extern static int  dx_ScreenCopy_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ScreenCopy")]
		extern static int  dx_ScreenCopy_x64( );
		public static int  ScreenCopy( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ScreenCopy_x86( );
			}
			else
			{
				return dx_ScreenCopy_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_WaitVSync")]
		extern static int  dx_WaitVSync_x86( int  SyncNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_WaitVSync")]
		extern static int  dx_WaitVSync_x64( int  SyncNum);
		public static int  WaitVSync( int  SyncNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_WaitVSync_x86( SyncNum );
			}
			else
			{
				return dx_WaitVSync_x64( SyncNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClsDrawScreen")]
		extern static int  dx_ClsDrawScreen_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ClsDrawScreen")]
		extern static int  dx_ClsDrawScreen_x64( );
		public static int  ClsDrawScreen( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ClsDrawScreen_x86( );
			}
			else
			{
				return dx_ClsDrawScreen_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawScreen")]
		extern static int  dx_SetDrawScreen_x86( int  DrawScreen);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawScreen")]
		extern static int  dx_SetDrawScreen_x64( int  DrawScreen);
		public static int  SetDrawScreen( int  DrawScreen)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawScreen_x86( DrawScreen );
			}
			else
			{
				return dx_SetDrawScreen_x64( DrawScreen );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawScreen")]
		extern static int  dx_GetDrawScreen_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawScreen")]
		extern static int  dx_GetDrawScreen_x64( );
		public static int  GetDrawScreen( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawScreen_x86( );
			}
			else
			{
				return dx_GetDrawScreen_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetActiveGraph")]
		extern static int  dx_GetActiveGraph_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetActiveGraph")]
		extern static int  dx_GetActiveGraph_x64( );
		public static int  GetActiveGraph( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetActiveGraph_x86( );
			}
			else
			{
				return dx_GetActiveGraph_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDrawZBuffer")]
		extern static int  dx_SetDrawZBuffer_x86( int  DrawScreen);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDrawZBuffer")]
		extern static int  dx_SetDrawZBuffer_x64( int  DrawScreen);
		public static int  SetDrawZBuffer( int  DrawScreen)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDrawZBuffer_x86( DrawScreen );
			}
			else
			{
				return dx_SetDrawZBuffer_x64( DrawScreen );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltBackScreenToWindow")]
		extern static int  dx_BltBackScreenToWindow_x86( System.IntPtr  Window, int  ClientX, int  ClientY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_BltBackScreenToWindow")]
		extern static int  dx_BltBackScreenToWindow_x64( System.IntPtr  Window, int  ClientX, int  ClientY);
		public static int  BltBackScreenToWindow( System.IntPtr  Window, int  ClientX, int  ClientY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltBackScreenToWindow_x86( Window , ClientX , ClientY );
			}
			else
			{
				return dx_BltBackScreenToWindow_x64( Window , ClientX , ClientY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltRectBackScreenToWindow")]
		extern static int  dx_BltRectBackScreenToWindow_x86( System.IntPtr  Window, RECT  BackScreenRect, RECT  WindowClientRect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_BltRectBackScreenToWindow")]
		extern static int  dx_BltRectBackScreenToWindow_x64( System.IntPtr  Window, RECT  BackScreenRect, RECT  WindowClientRect);
		public static int  BltRectBackScreenToWindow( System.IntPtr  Window, RECT  BackScreenRect, RECT  WindowClientRect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltRectBackScreenToWindow_x86( Window , BackScreenRect , WindowClientRect );
			}
			else
			{
				return dx_BltRectBackScreenToWindow_x64( Window , BackScreenRect , WindowClientRect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphMode")]
		extern static int  dx_SetGraphMode_x86( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth, int  RefreshRate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetGraphMode")]
		extern static int  dx_SetGraphMode_x64( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth, int  RefreshRate);
		public static int  SetGraphMode( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetGraphMode_x86( ScreenSizeX , ScreenSizeY , ColorBitDepth , 60 );
			}
			else
			{
				return dx_SetGraphMode_x64( ScreenSizeX , ScreenSizeY , ColorBitDepth , 60 );
			}
		}
		public static int  SetGraphMode( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth, int  RefreshRate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetGraphMode_x86( ScreenSizeX , ScreenSizeY , ColorBitDepth , RefreshRate );
			}
			else
			{
				return dx_SetGraphMode_x64( ScreenSizeX , ScreenSizeY , ColorBitDepth , RefreshRate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetEmulation320x240")]
		extern static int  dx_SetEmulation320x240_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetEmulation320x240")]
		extern static int  dx_SetEmulation320x240_x64( int  Flag);
		public static int  SetEmulation320x240( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetEmulation320x240_x86( Flag );
			}
			else
			{
				return dx_SetEmulation320x240_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetZBufferSize")]
		extern static int  dx_SetZBufferSize_x86( int  ZBufferSizeX, int  ZBufferSizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetZBufferSize")]
		extern static int  dx_SetZBufferSize_x64( int  ZBufferSizeX, int  ZBufferSizeY);
		public static int  SetZBufferSize( int  ZBufferSizeX, int  ZBufferSizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetZBufferSize_x86( ZBufferSizeX , ZBufferSizeY );
			}
			else
			{
				return dx_SetZBufferSize_x64( ZBufferSizeX , ZBufferSizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWaitVSyncFlag")]
		extern static int  dx_SetWaitVSyncFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWaitVSyncFlag")]
		extern static int  dx_SetWaitVSyncFlag_x64( int  Flag);
		public static int  SetWaitVSyncFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWaitVSyncFlag_x86( Flag );
			}
			else
			{
				return dx_SetWaitVSyncFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetWaitVSyncFlag")]
		extern static int  dx_GetWaitVSyncFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetWaitVSyncFlag")]
		extern static int  dx_GetWaitVSyncFlag_x64( );
		public static int  GetWaitVSyncFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetWaitVSyncFlag_x86( );
			}
			else
			{
				return dx_GetWaitVSyncFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFullSceneAntiAliasingMode")]
		extern static int  dx_SetFullSceneAntiAliasingMode_x86( int  Samples, int  Quality);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFullSceneAntiAliasingMode")]
		extern static int  dx_SetFullSceneAntiAliasingMode_x64( int  Samples, int  Quality);
		public static int  SetFullSceneAntiAliasingMode( int  Samples, int  Quality)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFullSceneAntiAliasingMode_x86( Samples , Quality );
			}
			else
			{
				return dx_SetFullSceneAntiAliasingMode_x64( Samples , Quality );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphDisplayArea")]
		extern static int  dx_SetGraphDisplayArea_x86( int  x1, int  y1, int  x2, int  y2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetGraphDisplayArea")]
		extern static int  dx_SetGraphDisplayArea_x64( int  x1, int  y1, int  x2, int  y2);
		public static int  SetGraphDisplayArea( int  x1, int  y1, int  x2, int  y2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetGraphDisplayArea_x86( x1 , y1 , x2 , y2 );
			}
			else
			{
				return dx_SetGraphDisplayArea_x64( x1 , y1 , x2 , y2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetChangeScreenModeGraphicsSystemResetFlag")]
		extern static int  dx_SetChangeScreenModeGraphicsSystemResetFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetChangeScreenModeGraphicsSystemResetFlag")]
		extern static int  dx_SetChangeScreenModeGraphicsSystemResetFlag_x64( int  Flag);
		public static int  SetChangeScreenModeGraphicsSystemResetFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetChangeScreenModeGraphicsSystemResetFlag_x86( Flag );
			}
			else
			{
				return dx_SetChangeScreenModeGraphicsSystemResetFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetScreenState")]
		extern static int  dx_GetScreenState_x86( out int  SizeX, out int  SizeY, out int  ColorBitDepth);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetScreenState")]
		extern static int  dx_GetScreenState_x64( out int  SizeX, out int  SizeY, out int  ColorBitDepth);
		public static int  GetScreenState( out int  SizeX, out int  SizeY, out int  ColorBitDepth)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetScreenState_x86( out SizeX , out SizeY , out ColorBitDepth );
			}
			else
			{
				return dx_GetScreenState_x64( out SizeX , out SizeY , out ColorBitDepth );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawScreenSize")]
		extern static int  dx_GetDrawScreenSize_x86( out int  XBuf, out int  YBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawScreenSize")]
		extern static int  dx_GetDrawScreenSize_x64( out int  XBuf, out int  YBuf);
		public static int  GetDrawScreenSize( out int  XBuf, out int  YBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawScreenSize_x86( out XBuf , out YBuf );
			}
			else
			{
				return dx_GetDrawScreenSize_x64( out XBuf , out YBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetScreenBitDepth")]
		extern static int  dx_GetScreenBitDepth_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetScreenBitDepth")]
		extern static int  dx_GetScreenBitDepth_x64( );
		public static int  GetScreenBitDepth( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetScreenBitDepth_x86( );
			}
			else
			{
				return dx_GetScreenBitDepth_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColorBitDepth")]
		extern static int  dx_GetColorBitDepth_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetColorBitDepth")]
		extern static int  dx_GetColorBitDepth_x64( );
		public static int  GetColorBitDepth( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetColorBitDepth_x86( );
			}
			else
			{
				return dx_GetColorBitDepth_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetChangeDisplayFlag")]
		extern static int  dx_GetChangeDisplayFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetChangeDisplayFlag")]
		extern static int  dx_GetChangeDisplayFlag_x64( );
		public static int  GetChangeDisplayFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetChangeDisplayFlag_x86( );
			}
			else
			{
				return dx_GetChangeDisplayFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetVideoMemorySize")]
		extern static int  dx_GetVideoMemorySize_x86( out int  AllSize, out int  FreeSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetVideoMemorySize")]
		extern static int  dx_GetVideoMemorySize_x64( out int  AllSize, out int  FreeSize);
		public static int  GetVideoMemorySize( out int  AllSize, out int  FreeSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetVideoMemorySize_x86( out AllSize , out FreeSize );
			}
			else
			{
				return dx_GetVideoMemorySize_x64( out AllSize , out FreeSize );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetRefreshRate")]
		extern static int  dx_GetRefreshRate_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetRefreshRate")]
		extern static int  dx_GetRefreshRate_x64( );
		public static int  GetRefreshRate( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetRefreshRate_x86( );
			}
			else
			{
				return dx_GetRefreshRate_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDisplayModeNum")]
		extern static int  dx_GetDisplayModeNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDisplayModeNum")]
		extern static int  dx_GetDisplayModeNum_x64( );
		public static int  GetDisplayModeNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDisplayModeNum_x86( );
			}
			else
			{
				return dx_GetDisplayModeNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDisplayMode")]
		extern static DISPLAYMODEDATA  dx_GetDisplayMode_x86( int  ModeIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDisplayMode")]
		extern static DISPLAYMODEDATA  dx_GetDisplayMode_x64( int  ModeIndex);
		public static DISPLAYMODEDATA  GetDisplayMode( int  ModeIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDisplayMode_x86( ModeIndex );
			}
			else
			{
				return dx_GetDisplayMode_x64( ModeIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMultiDrawScreenNum")]
		extern static int  dx_GetMultiDrawScreenNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMultiDrawScreenNum")]
		extern static int  dx_GetMultiDrawScreenNum_x64( );
		public static int  GetMultiDrawScreenNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMultiDrawScreenNum_x86( );
			}
			else
			{
				return dx_GetMultiDrawScreenNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDisplayRefreshRate")]
		extern static int  dx_SetDisplayRefreshRate_x86( int  RefreshRate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDisplayRefreshRate")]
		extern static int  dx_SetDisplayRefreshRate_x64( int  RefreshRate);
		public static int  SetDisplayRefreshRate( int  RefreshRate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDisplayRefreshRate_x86( RefreshRate );
			}
			else
			{
				return dx_SetDisplayRefreshRate_x64( RefreshRate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseNormalDrawShader")]
		extern static int  dx_SetUseNormalDrawShader_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseNormalDrawShader")]
		extern static int  dx_SetUseNormalDrawShader_x64( int  Flag);
		public static int  SetUseNormalDrawShader( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseNormalDrawShader_x86( Flag );
			}
			else
			{
				return dx_SetUseNormalDrawShader_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseSoftwareRenderModeFlag")]
		extern static int  dx_SetUseSoftwareRenderModeFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseSoftwareRenderModeFlag")]
		extern static int  dx_SetUseSoftwareRenderModeFlag_x64( int  Flag);
		public static int  SetUseSoftwareRenderModeFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseSoftwareRenderModeFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseSoftwareRenderModeFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNotUse3DFlag")]
		extern static int  dx_SetNotUse3DFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetNotUse3DFlag")]
		extern static int  dx_SetNotUse3DFlag_x64( int  Flag);
		public static int  SetNotUse3DFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetNotUse3DFlag_x86( Flag );
			}
			else
			{
				return dx_SetNotUse3DFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUse3DFlag")]
		extern static int  dx_SetUse3DFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUse3DFlag")]
		extern static int  dx_SetUse3DFlag_x64( int  Flag);
		public static int  SetUse3DFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUse3DFlag_x86( Flag );
			}
			else
			{
				return dx_SetUse3DFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUse3DFlag")]
		extern static int  dx_GetUse3DFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUse3DFlag")]
		extern static int  dx_GetUse3DFlag_x64( );
		public static int  GetUse3DFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUse3DFlag_x86( );
			}
			else
			{
				return dx_GetUse3DFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetScreenMemToVramFlag")]
		extern static int  dx_SetScreenMemToVramFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetScreenMemToVramFlag")]
		extern static int  dx_SetScreenMemToVramFlag_x64( int  Flag);
		public static int  SetScreenMemToVramFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetScreenMemToVramFlag_x86( Flag );
			}
			else
			{
				return dx_SetScreenMemToVramFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetScreenMemToSystemMemFlag")]
		extern static int  dx_GetScreenMemToSystemMemFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetScreenMemToSystemMemFlag")]
		extern static int  dx_GetScreenMemToSystemMemFlag_x64( );
		public static int  GetScreenMemToSystemMemFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetScreenMemToSystemMemFlag_x86( );
			}
			else
			{
				return dx_GetScreenMemToSystemMemFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetWindowDrawRect")]
		extern static int  dx_SetWindowDrawRect_x86( out RECT  DrawRect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetWindowDrawRect")]
		extern static int  dx_SetWindowDrawRect_x64( out RECT  DrawRect);
		public static int  SetWindowDrawRect( out RECT  DrawRect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetWindowDrawRect_x86( out DrawRect );
			}
			else
			{
				return dx_SetWindowDrawRect_x64( out DrawRect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RestoreGraphSystem")]
		extern static int  dx_RestoreGraphSystem_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_RestoreGraphSystem")]
		extern static int  dx_RestoreGraphSystem_x64( );
		public static int  RestoreGraphSystem( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_RestoreGraphSystem_x86( );
			}
			else
			{
				return dx_RestoreGraphSystem_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetAeroDisableFlag")]
		extern static int  dx_SetAeroDisableFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetAeroDisableFlag")]
		extern static int  dx_SetAeroDisableFlag_x64( int  Flag);
		public static int  SetAeroDisableFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetAeroDisableFlag_x86( Flag );
			}
			else
			{
				return dx_SetAeroDisableFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDirect3D9Ex")]
		extern static int  dx_SetUseDirect3D9Ex_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseDirect3D9Ex")]
		extern static int  dx_SetUseDirect3D9Ex_x64( int  Flag);
		public static int  SetUseDirect3D9Ex( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseDirect3D9Ex_x86( Flag );
			}
			else
			{
				return dx_SetUseDirect3D9Ex_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseHardwareVertexProcessing")]
		extern static int  dx_SetUseHardwareVertexProcessing_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseHardwareVertexProcessing")]
		extern static int  dx_SetUseHardwareVertexProcessing_x64( int  Flag);
		public static int  SetUseHardwareVertexProcessing( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseHardwareVertexProcessing_x86( Flag );
			}
			else
			{
				return dx_SetUseHardwareVertexProcessing_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMultiThreadFlag")]
		extern static int  dx_SetMultiThreadFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMultiThreadFlag")]
		extern static int  dx_SetMultiThreadFlag_x64( int  Flag);
		public static int  SetMultiThreadFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMultiThreadFlag_x86( Flag );
			}
			else
			{
				return dx_SetMultiThreadFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDirectDrawDeviceIndex")]
		extern static int  dx_SetUseDirectDrawDeviceIndex_x86( int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseDirectDrawDeviceIndex")]
		extern static int  dx_SetUseDirectDrawDeviceIndex_x64( int  Index);
		public static int  SetUseDirectDrawDeviceIndex( int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseDirectDrawDeviceIndex_x86( Index );
			}
			else
			{
				return dx_SetUseDirectDrawDeviceIndex_x64( Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseOldDrawModiGraphCodeFlag")]
		extern static int  dx_SetUseOldDrawModiGraphCodeFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseOldDrawModiGraphCodeFlag")]
		extern static int  dx_SetUseOldDrawModiGraphCodeFlag_x64( int  Flag);
		public static int  SetUseOldDrawModiGraphCodeFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseOldDrawModiGraphCodeFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseOldDrawModiGraphCodeFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseVramFlag")]
		extern static int  dx_SetUseVramFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseVramFlag")]
		extern static int  dx_SetUseVramFlag_x64( int  Flag);
		public static int  SetUseVramFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseVramFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseVramFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseVramFlag")]
		extern static int  dx_GetUseVramFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseVramFlag")]
		extern static int  dx_GetUseVramFlag_x64( );
		public static int  GetUseVramFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseVramFlag_x86( );
			}
			else
			{
				return dx_GetUseVramFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetBasicBlendFlag")]
		extern static int  dx_SetBasicBlendFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetBasicBlendFlag")]
		extern static int  dx_SetBasicBlendFlag_x64( int  Flag);
		public static int  SetBasicBlendFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetBasicBlendFlag_x86( Flag );
			}
			else
			{
				return dx_SetBasicBlendFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseBasicGraphDraw3DDeviceMethodFlag")]
		extern static int  dx_SetUseBasicGraphDraw3DDeviceMethodFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseBasicGraphDraw3DDeviceMethodFlag")]
		extern static int  dx_SetUseBasicGraphDraw3DDeviceMethodFlag_x64( int  Flag);
		public static int  SetUseBasicGraphDraw3DDeviceMethodFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseBasicGraphDraw3DDeviceMethodFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseBasicGraphDraw3DDeviceMethodFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDirectDrawFlag")]
		extern static int  dx_SetUseDirectDrawFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseDirectDrawFlag")]
		extern static int  dx_SetUseDirectDrawFlag_x64( int  Flag);
		public static int  SetUseDirectDrawFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseDirectDrawFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseDirectDrawFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseGDIFlag")]
		extern static int  dx_SetUseGDIFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseGDIFlag")]
		extern static int  dx_SetUseGDIFlag_x64( int  Flag);
		public static int  SetUseGDIFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseGDIFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseGDIFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseGDIFlag")]
		extern static int  dx_GetUseGDIFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseGDIFlag")]
		extern static int  dx_GetUseGDIFlag_x64( );
		public static int  GetUseGDIFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseGDIFlag_x86( );
			}
			else
			{
				return dx_GetUseGDIFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDirectDrawDeviceDescription")]
		extern static int  dx_GetDirectDrawDeviceDescription_x86( int  Number, System.Text.StringBuilder  StringBuffer);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDirectDrawDeviceDescription")]
		extern static int  dx_GetDirectDrawDeviceDescription_x64( int  Number, System.Text.StringBuilder  StringBuffer);
		public static int  GetDirectDrawDeviceDescription( int  Number, System.Text.StringBuilder  StringBuffer)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDirectDrawDeviceDescription_x86( Number , StringBuffer );
			}
			else
			{
				return dx_GetDirectDrawDeviceDescription_x64( Number , StringBuffer );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDirectDrawDeviceNum")]
		extern static int  dx_GetDirectDrawDeviceNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDirectDrawDeviceNum")]
		extern static int  dx_GetDirectDrawDeviceNum_x64( );
		public static int  GetDirectDrawDeviceNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDirectDrawDeviceNum_x86( );
			}
			else
			{
				return dx_GetDirectDrawDeviceNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseDirect3DDevice9")]
		extern static System.IntPtr dx_GetUseDirect3DDevice9_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseDirect3DDevice9")]
		extern static System.IntPtr dx_GetUseDirect3DDevice9_x64( );
		public static System.IntPtr GetUseDirect3DDevice9( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseDirect3DDevice9_x86( );
			}
			else
			{
				return dx_GetUseDirect3DDevice9_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseDirect3D9BackBufferSurface")]
		extern static System.IntPtr dx_GetUseDirect3D9BackBufferSurface_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseDirect3D9BackBufferSurface")]
		extern static System.IntPtr dx_GetUseDirect3D9BackBufferSurface_x64( );
		public static System.IntPtr GetUseDirect3D9BackBufferSurface( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseDirect3D9BackBufferSurface_x86( );
			}
			else
			{
				return dx_GetUseDirect3D9BackBufferSurface_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RefreshDxLibDirect3DSetting")]
		extern static int  dx_RefreshDxLibDirect3DSetting_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_RefreshDxLibDirect3DSetting")]
		extern static int  dx_RefreshDxLibDirect3DSetting_x64( );
		public static int  RefreshDxLibDirect3DSetting( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_RefreshDxLibDirect3DSetting_x86( );
			}
			else
			{
				return dx_RefreshDxLibDirect3DSetting_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RenderVertex")]
		extern static int  dx_RenderVertex_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_RenderVertex")]
		extern static int  dx_RenderVertex_x64( );
		public static int  RenderVertex( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_RenderVertex_x86( );
			}
			else
			{
				return dx_RenderVertex_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveDrawScreen")]
		extern static int  dx_SaveDrawScreen_x86( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SaveDrawScreen")]
		extern static int  dx_SaveDrawScreen_x64( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel);
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreen_x86( x1 , y1 , x2 , y2 , FileName , DX_IMAGESAVETYPE_BMP , 80 , TRUE , -1 );
			}
			else
			{
				return dx_SaveDrawScreen_x64( x1 , y1 , x2 , y2 , FileName , DX_IMAGESAVETYPE_BMP , 80 , TRUE , -1 );
			}
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreen_x86( x1 , y1 , x2 , y2 , FileName , SaveType , 80 , TRUE , -1 );
			}
			else
			{
				return dx_SaveDrawScreen_x64( x1 , y1 , x2 , y2 , FileName , SaveType , 80 , TRUE , -1 );
			}
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreen_x86( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , TRUE , -1 );
			}
			else
			{
				return dx_SaveDrawScreen_x64( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , TRUE , -1 );
			}
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreen_x86( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , -1 );
			}
			else
			{
				return dx_SaveDrawScreen_x64( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , -1 );
			}
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreen_x86( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , Png_CompressionLevel );
			}
			else
			{
				return dx_SaveDrawScreen_x64( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , Png_CompressionLevel );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveDrawScreenToBMP")]
		extern static int  dx_SaveDrawScreenToBMP_x86( int  x1, int  y1, int  x2, int  y2, string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SaveDrawScreenToBMP")]
		extern static int  dx_SaveDrawScreenToBMP_x64( int  x1, int  y1, int  x2, int  y2, string  FileName);
		public static int  SaveDrawScreenToBMP( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreenToBMP_x86( x1 , y1 , x2 , y2 , FileName );
			}
			else
			{
				return dx_SaveDrawScreenToBMP_x64( x1 , y1 , x2 , y2 , FileName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveDrawScreenToJPEG")]
		extern static int  dx_SaveDrawScreenToJPEG_x86( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality, int  Sample2x1);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SaveDrawScreenToJPEG")]
		extern static int  dx_SaveDrawScreenToJPEG_x64( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality, int  Sample2x1);
		public static int  SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreenToJPEG_x86( x1 , y1 , x2 , y2 , FileName , 80 , TRUE );
			}
			else
			{
				return dx_SaveDrawScreenToJPEG_x64( x1 , y1 , x2 , y2 , FileName , 80 , TRUE );
			}
		}
		public static int  SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreenToJPEG_x86( x1 , y1 , x2 , y2 , FileName , Quality , TRUE );
			}
			else
			{
				return dx_SaveDrawScreenToJPEG_x64( x1 , y1 , x2 , y2 , FileName , Quality , TRUE );
			}
		}
		public static int  SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality, int  Sample2x1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreenToJPEG_x86( x1 , y1 , x2 , y2 , FileName , Quality , Sample2x1 );
			}
			else
			{
				return dx_SaveDrawScreenToJPEG_x64( x1 , y1 , x2 , y2 , FileName , Quality , Sample2x1 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveDrawScreenToPNG")]
		extern static int  dx_SaveDrawScreenToPNG_x86( int  x1, int  y1, int  x2, int  y2, string  FileName, int  CompressionLevel);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SaveDrawScreenToPNG")]
		extern static int  dx_SaveDrawScreenToPNG_x64( int  x1, int  y1, int  x2, int  y2, string  FileName, int  CompressionLevel);
		public static int  SaveDrawScreenToPNG( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreenToPNG_x86( x1 , y1 , x2 , y2 , FileName , -1 );
			}
			else
			{
				return dx_SaveDrawScreenToPNG_x64( x1 , y1 , x2 , y2 , FileName , -1 );
			}
		}
		public static int  SaveDrawScreenToPNG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  CompressionLevel)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveDrawScreenToPNG_x86( x1 , y1 , x2 , y2 , FileName , CompressionLevel );
			}
			else
			{
				return dx_SaveDrawScreenToPNG_x64( x1 , y1 , x2 , y2 , FileName , CompressionLevel );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateVertexBuffer")]
		extern static int  dx_CreateVertexBuffer_x86( int  VertexNum, int  VertexType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateVertexBuffer")]
		extern static int  dx_CreateVertexBuffer_x64( int  VertexNum, int  VertexType);
		public static int  CreateVertexBuffer( int  VertexNum, int  VertexType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateVertexBuffer_x86( VertexNum , VertexType );
			}
			else
			{
				return dx_CreateVertexBuffer_x64( VertexNum , VertexType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteVertexBuffer")]
		extern static int  dx_DeleteVertexBuffer_x86( int  VertexBufHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteVertexBuffer")]
		extern static int  dx_DeleteVertexBuffer_x64( int  VertexBufHandle);
		public static int  DeleteVertexBuffer( int  VertexBufHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteVertexBuffer_x86( VertexBufHandle );
			}
			else
			{
				return dx_DeleteVertexBuffer_x64( VertexBufHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitVertexBuffer")]
		extern static int  dx_InitVertexBuffer_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitVertexBuffer")]
		extern static int  dx_InitVertexBuffer_x64( );
		public static int  InitVertexBuffer( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitVertexBuffer_x86( );
			}
			else
			{
				return dx_InitVertexBuffer_x64( );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_SetVertexBufferData")]
		extern unsafe static int  dx_SetVertexBufferData_x86( int  SetIndex, void *  VertexData, int  VertexNum, int  VertexBufHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVertexBufferData")]
		extern unsafe static int  dx_SetVertexBufferData_x64( int  SetIndex, void *  VertexData, int  VertexNum, int  VertexBufHandle);
		public unsafe static int  SetVertexBufferData( int  SetIndex, void *  VertexData, int  VertexNum, int  VertexBufHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVertexBufferData_x86( SetIndex , VertexData , VertexNum , VertexBufHandle );
			}
			else
			{
				return dx_SetVertexBufferData_x64( SetIndex , VertexData , VertexNum , VertexBufHandle );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_CreateIndexBuffer")]
		extern static int  dx_CreateIndexBuffer_x86( int  IndexNum, int  IndexType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateIndexBuffer")]
		extern static int  dx_CreateIndexBuffer_x64( int  IndexNum, int  IndexType);
		public static int  CreateIndexBuffer( int  IndexNum, int  IndexType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateIndexBuffer_x86( IndexNum , IndexType );
			}
			else
			{
				return dx_CreateIndexBuffer_x64( IndexNum , IndexType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteIndexBuffer")]
		extern static int  dx_DeleteIndexBuffer_x86( int  IndexBufHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteIndexBuffer")]
		extern static int  dx_DeleteIndexBuffer_x64( int  IndexBufHandle);
		public static int  DeleteIndexBuffer( int  IndexBufHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteIndexBuffer_x86( IndexBufHandle );
			}
			else
			{
				return dx_DeleteIndexBuffer_x64( IndexBufHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitIndexBuffer")]
		extern static int  dx_InitIndexBuffer_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitIndexBuffer")]
		extern static int  dx_InitIndexBuffer_x64( );
		public static int  InitIndexBuffer( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitIndexBuffer_x86( );
			}
			else
			{
				return dx_InitIndexBuffer_x64( );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_SetIndexBufferData")]
		extern unsafe static int  dx_SetIndexBufferData_x86( int  SetIndex, void *  IndexData, int  IndexNum, int  IndexBufHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetIndexBufferData")]
		extern unsafe static int  dx_SetIndexBufferData_x64( int  SetIndex, void *  IndexData, int  IndexNum, int  IndexBufHandle);
		public unsafe static int  SetIndexBufferData( int  SetIndex, void *  IndexData, int  IndexNum, int  IndexBufHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetIndexBufferData_x86( SetIndex , IndexData , IndexNum , IndexBufHandle );
			}
			else
			{
				return dx_SetIndexBufferData_x64( SetIndex , IndexData , IndexNum , IndexBufHandle );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_GetValidShaderVersion")]
		extern static int  dx_GetValidShaderVersion_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetValidShaderVersion")]
		extern static int  dx_GetValidShaderVersion_x64( );
		public static int  GetValidShaderVersion( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetValidShaderVersion_x86( );
			}
			else
			{
				return dx_GetValidShaderVersion_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadVertexShader")]
		extern static int  dx_LoadVertexShader_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadVertexShader")]
		extern static int  dx_LoadVertexShader_x64( string  FileName);
		public static int  LoadVertexShader( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadVertexShader_x86( FileName );
			}
			else
			{
				return dx_LoadVertexShader_x64( FileName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadPixelShader")]
		extern static int  dx_LoadPixelShader_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadPixelShader")]
		extern static int  dx_LoadPixelShader_x64( string  FileName);
		public static int  LoadPixelShader( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadPixelShader_x86( FileName );
			}
			else
			{
				return dx_LoadPixelShader_x64( FileName );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadVertexShaderFromMem")]
		extern unsafe static int  dx_LoadVertexShaderFromMem_x86( void *  ImageAddress, int  ImageSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadVertexShaderFromMem")]
		extern unsafe static int  dx_LoadVertexShaderFromMem_x64( void *  ImageAddress, int  ImageSize);
		public unsafe static int  LoadVertexShaderFromMem( void *  ImageAddress, int  ImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadVertexShaderFromMem_x86( ImageAddress , ImageSize );
			}
			else
			{
				return dx_LoadVertexShaderFromMem_x64( ImageAddress , ImageSize );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadPixelShaderFromMem")]
		extern unsafe static int  dx_LoadPixelShaderFromMem_x86( void *  ImageAddress, int  ImageSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadPixelShaderFromMem")]
		extern unsafe static int  dx_LoadPixelShaderFromMem_x64( void *  ImageAddress, int  ImageSize);
		public unsafe static int  LoadPixelShaderFromMem( void *  ImageAddress, int  ImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadPixelShaderFromMem_x86( ImageAddress , ImageSize );
			}
			else
			{
				return dx_LoadPixelShaderFromMem_x64( ImageAddress , ImageSize );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteShader")]
		extern static int  dx_DeleteShader_x86( int  ShaderHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteShader")]
		extern static int  dx_DeleteShader_x64( int  ShaderHandle);
		public static int  DeleteShader( int  ShaderHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteShader_x86( ShaderHandle );
			}
			else
			{
				return dx_DeleteShader_x64( ShaderHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitShader")]
		extern static int  dx_InitShader_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitShader")]
		extern static int  dx_InitShader_x64( );
		public static int  InitShader( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitShader_x86( );
			}
			else
			{
				return dx_InitShader_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetConstIndexToShader")]
		extern static int  dx_GetConstIndexToShader_x86( string  ConstantName, int  ShaderHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetConstIndexToShader")]
		extern static int  dx_GetConstIndexToShader_x64( string  ConstantName, int  ShaderHandle);
		public static int  GetConstIndexToShader( string  ConstantName, int  ShaderHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetConstIndexToShader_x86( ConstantName , ShaderHandle );
			}
			else
			{
				return dx_GetConstIndexToShader_x64( ConstantName , ShaderHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetConstCountToShader")]
		extern static int  dx_GetConstCountToShader_x86( string  ConstantName, int  ShaderHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetConstCountToShader")]
		extern static int  dx_GetConstCountToShader_x64( string  ConstantName, int  ShaderHandle);
		public static int  GetConstCountToShader( string  ConstantName, int  ShaderHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetConstCountToShader_x86( ConstantName , ShaderHandle );
			}
			else
			{
				return dx_GetConstCountToShader_x64( ConstantName , ShaderHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstSF")]
		extern static int  dx_SetVSConstSF_x86( int  ConstantIndex, float  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstSF")]
		extern static int  dx_SetVSConstSF_x64( int  ConstantIndex, float  Param);
		public static int  SetVSConstSF( int  ConstantIndex, float  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstSF_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetVSConstSF_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstF")]
		extern static int  dx_SetVSConstF_x86( int  ConstantIndex, FLOAT4  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstF")]
		extern static int  dx_SetVSConstF_x64( int  ConstantIndex, FLOAT4  Param);
		public static int  SetVSConstF( int  ConstantIndex, FLOAT4  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstF_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetVSConstF_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstFMtx")]
		extern static int  dx_SetVSConstFMtx_x86( int  ConstantIndex, MATRIX  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstFMtx")]
		extern static int  dx_SetVSConstFMtx_x64( int  ConstantIndex, MATRIX  Param);
		public static int  SetVSConstFMtx( int  ConstantIndex, MATRIX  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstFMtx_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetVSConstFMtx_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstFMtxT")]
		extern static int  dx_SetVSConstFMtxT_x86( int  ConstantIndex, MATRIX  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstFMtxT")]
		extern static int  dx_SetVSConstFMtxT_x64( int  ConstantIndex, MATRIX  Param);
		public static int  SetVSConstFMtxT( int  ConstantIndex, MATRIX  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstFMtxT_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetVSConstFMtxT_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstSI")]
		extern static int  dx_SetVSConstSI_x86( int  ConstantIndex, int  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstSI")]
		extern static int  dx_SetVSConstSI_x64( int  ConstantIndex, int  Param);
		public static int  SetVSConstSI( int  ConstantIndex, int  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstSI_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetVSConstSI_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstI")]
		extern static int  dx_SetVSConstI_x86( int  ConstantIndex, INT4  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstI")]
		extern static int  dx_SetVSConstI_x64( int  ConstantIndex, INT4  Param);
		public static int  SetVSConstI( int  ConstantIndex, INT4  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstI_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetVSConstI_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstB")]
		extern static int  dx_SetVSConstB_x86( int  ConstantIndex, int  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstB")]
		extern static int  dx_SetVSConstB_x64( int  ConstantIndex, int  Param);
		public static int  SetVSConstB( int  ConstantIndex, int  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstB_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetVSConstB_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstSFArray")]
		extern static int  dx_SetVSConstSFArray_x86( int  ConstantIndex, out float  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstSFArray")]
		extern static int  dx_SetVSConstSFArray_x64( int  ConstantIndex, out float  ParamArray, int  ParamNum);
		public static int  SetVSConstSFArray( int  ConstantIndex, out float  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstSFArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetVSConstSFArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstFArray")]
		extern static int  dx_SetVSConstFArray_x86( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstFArray")]
		extern static int  dx_SetVSConstFArray_x64( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum);
		public static int  SetVSConstFArray( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstFArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetVSConstFArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstFMtxArray")]
		extern static int  dx_SetVSConstFMtxArray_x86( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstFMtxArray")]
		extern static int  dx_SetVSConstFMtxArray_x64( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		public static int  SetVSConstFMtxArray( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstFMtxArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetVSConstFMtxArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstFMtxTArray")]
		extern static int  dx_SetVSConstFMtxTArray_x86( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstFMtxTArray")]
		extern static int  dx_SetVSConstFMtxTArray_x64( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		public static int  SetVSConstFMtxTArray( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstFMtxTArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetVSConstFMtxTArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstSIArray")]
		extern static int  dx_SetVSConstSIArray_x86( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstSIArray")]
		extern static int  dx_SetVSConstSIArray_x64( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		public static int  SetVSConstSIArray( int  ConstantIndex, out int  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstSIArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetVSConstSIArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstIArray")]
		extern static int  dx_SetVSConstIArray_x86( int  ConstantIndex, out INT4  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstIArray")]
		extern static int  dx_SetVSConstIArray_x64( int  ConstantIndex, out INT4  ParamArray, int  ParamNum);
		public static int  SetVSConstIArray( int  ConstantIndex, out INT4  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstIArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetVSConstIArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVSConstBArray")]
		extern static int  dx_SetVSConstBArray_x86( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVSConstBArray")]
		extern static int  dx_SetVSConstBArray_x64( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		public static int  SetVSConstBArray( int  ConstantIndex, out int  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVSConstBArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetVSConstBArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetVSConstF")]
		extern static int  dx_ResetVSConstF_x86( int  ConstantIndex, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetVSConstF")]
		extern static int  dx_ResetVSConstF_x64( int  ConstantIndex, int  ParamNum);
		public static int  ResetVSConstF( int  ConstantIndex, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetVSConstF_x86( ConstantIndex , ParamNum );
			}
			else
			{
				return dx_ResetVSConstF_x64( ConstantIndex , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetVSConstI")]
		extern static int  dx_ResetVSConstI_x86( int  ConstantIndex, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetVSConstI")]
		extern static int  dx_ResetVSConstI_x64( int  ConstantIndex, int  ParamNum);
		public static int  ResetVSConstI( int  ConstantIndex, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetVSConstI_x86( ConstantIndex , ParamNum );
			}
			else
			{
				return dx_ResetVSConstI_x64( ConstantIndex , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetVSConstB")]
		extern static int  dx_ResetVSConstB_x86( int  ConstantIndex, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetVSConstB")]
		extern static int  dx_ResetVSConstB_x64( int  ConstantIndex, int  ParamNum);
		public static int  ResetVSConstB( int  ConstantIndex, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetVSConstB_x86( ConstantIndex , ParamNum );
			}
			else
			{
				return dx_ResetVSConstB_x64( ConstantIndex , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstSF")]
		extern static int  dx_SetPSConstSF_x86( int  ConstantIndex, float  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstSF")]
		extern static int  dx_SetPSConstSF_x64( int  ConstantIndex, float  Param);
		public static int  SetPSConstSF( int  ConstantIndex, float  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstSF_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetPSConstSF_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstF")]
		extern static int  dx_SetPSConstF_x86( int  ConstantIndex, FLOAT4  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstF")]
		extern static int  dx_SetPSConstF_x64( int  ConstantIndex, FLOAT4  Param);
		public static int  SetPSConstF( int  ConstantIndex, FLOAT4  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstF_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetPSConstF_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstFMtx")]
		extern static int  dx_SetPSConstFMtx_x86( int  ConstantIndex, MATRIX  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstFMtx")]
		extern static int  dx_SetPSConstFMtx_x64( int  ConstantIndex, MATRIX  Param);
		public static int  SetPSConstFMtx( int  ConstantIndex, MATRIX  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstFMtx_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetPSConstFMtx_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstFMtxT")]
		extern static int  dx_SetPSConstFMtxT_x86( int  ConstantIndex, MATRIX  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstFMtxT")]
		extern static int  dx_SetPSConstFMtxT_x64( int  ConstantIndex, MATRIX  Param);
		public static int  SetPSConstFMtxT( int  ConstantIndex, MATRIX  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstFMtxT_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetPSConstFMtxT_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstSI")]
		extern static int  dx_SetPSConstSI_x86( int  ConstantIndex, int  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstSI")]
		extern static int  dx_SetPSConstSI_x64( int  ConstantIndex, int  Param);
		public static int  SetPSConstSI( int  ConstantIndex, int  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstSI_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetPSConstSI_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstI")]
		extern static int  dx_SetPSConstI_x86( int  ConstantIndex, INT4  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstI")]
		extern static int  dx_SetPSConstI_x64( int  ConstantIndex, INT4  Param);
		public static int  SetPSConstI( int  ConstantIndex, INT4  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstI_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetPSConstI_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstB")]
		extern static int  dx_SetPSConstB_x86( int  ConstantIndex, int  Param);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstB")]
		extern static int  dx_SetPSConstB_x64( int  ConstantIndex, int  Param);
		public static int  SetPSConstB( int  ConstantIndex, int  Param)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstB_x86( ConstantIndex , Param );
			}
			else
			{
				return dx_SetPSConstB_x64( ConstantIndex , Param );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstSFArray")]
		extern static int  dx_SetPSConstSFArray_x86( int  ConstantIndex, out float  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstSFArray")]
		extern static int  dx_SetPSConstSFArray_x64( int  ConstantIndex, out float  ParamArray, int  ParamNum);
		public static int  SetPSConstSFArray( int  ConstantIndex, out float  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstSFArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetPSConstSFArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstFArray")]
		extern static int  dx_SetPSConstFArray_x86( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstFArray")]
		extern static int  dx_SetPSConstFArray_x64( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum);
		public static int  SetPSConstFArray( int  ConstantIndex, out FLOAT4  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstFArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetPSConstFArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstFMtxArray")]
		extern static int  dx_SetPSConstFMtxArray_x86( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstFMtxArray")]
		extern static int  dx_SetPSConstFMtxArray_x64( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		public static int  SetPSConstFMtxArray( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstFMtxArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetPSConstFMtxArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstFMtxTArray")]
		extern static int  dx_SetPSConstFMtxTArray_x86( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstFMtxTArray")]
		extern static int  dx_SetPSConstFMtxTArray_x64( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum);
		public static int  SetPSConstFMtxTArray( int  ConstantIndex, out MATRIX  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstFMtxTArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetPSConstFMtxTArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstSIArray")]
		extern static int  dx_SetPSConstSIArray_x86( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstSIArray")]
		extern static int  dx_SetPSConstSIArray_x64( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		public static int  SetPSConstSIArray( int  ConstantIndex, out int  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstSIArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetPSConstSIArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstIArray")]
		extern static int  dx_SetPSConstIArray_x86( int  ConstantIndex, out INT4  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstIArray")]
		extern static int  dx_SetPSConstIArray_x64( int  ConstantIndex, out INT4  ParamArray, int  ParamNum);
		public static int  SetPSConstIArray( int  ConstantIndex, out INT4  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstIArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetPSConstIArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPSConstBArray")]
		extern static int  dx_SetPSConstBArray_x86( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPSConstBArray")]
		extern static int  dx_SetPSConstBArray_x64( int  ConstantIndex, out int  ParamArray, int  ParamNum);
		public static int  SetPSConstBArray( int  ConstantIndex, out int  ParamArray, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPSConstBArray_x86( ConstantIndex , out ParamArray , ParamNum );
			}
			else
			{
				return dx_SetPSConstBArray_x64( ConstantIndex , out ParamArray , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetPSConstF")]
		extern static int  dx_ResetPSConstF_x86( int  ConstantIndex, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetPSConstF")]
		extern static int  dx_ResetPSConstF_x64( int  ConstantIndex, int  ParamNum);
		public static int  ResetPSConstF( int  ConstantIndex, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetPSConstF_x86( ConstantIndex , ParamNum );
			}
			else
			{
				return dx_ResetPSConstF_x64( ConstantIndex , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetPSConstI")]
		extern static int  dx_ResetPSConstI_x86( int  ConstantIndex, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetPSConstI")]
		extern static int  dx_ResetPSConstI_x64( int  ConstantIndex, int  ParamNum);
		public static int  ResetPSConstI( int  ConstantIndex, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetPSConstI_x86( ConstantIndex , ParamNum );
			}
			else
			{
				return dx_ResetPSConstI_x64( ConstantIndex , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetPSConstB")]
		extern static int  dx_ResetPSConstB_x86( int  ConstantIndex, int  ParamNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetPSConstB")]
		extern static int  dx_ResetPSConstB_x64( int  ConstantIndex, int  ParamNum);
		public static int  ResetPSConstB( int  ConstantIndex, int  ParamNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetPSConstB_x86( ConstantIndex , ParamNum );
			}
			else
			{
				return dx_ResetPSConstB_x64( ConstantIndex , ParamNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetRenderTargetToShader")]
		extern static int  dx_SetRenderTargetToShader_x86( int  TargetIndex, int  DrawScreen);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetRenderTargetToShader")]
		extern static int  dx_SetRenderTargetToShader_x64( int  TargetIndex, int  DrawScreen);
		public static int  SetRenderTargetToShader( int  TargetIndex, int  DrawScreen)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetRenderTargetToShader_x86( TargetIndex , DrawScreen );
			}
			else
			{
				return dx_SetRenderTargetToShader_x64( TargetIndex , DrawScreen );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseTextureToShader")]
		extern static int  dx_SetUseTextureToShader_x86( int  StageIndex, int  GraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseTextureToShader")]
		extern static int  dx_SetUseTextureToShader_x64( int  StageIndex, int  GraphHandle);
		public static int  SetUseTextureToShader( int  StageIndex, int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseTextureToShader_x86( StageIndex , GraphHandle );
			}
			else
			{
				return dx_SetUseTextureToShader_x64( StageIndex , GraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseVertexShader")]
		extern static int  dx_SetUseVertexShader_x86( int  ShaderHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseVertexShader")]
		extern static int  dx_SetUseVertexShader_x64( int  ShaderHandle);
		public static int  SetUseVertexShader( int  ShaderHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseVertexShader_x86( ShaderHandle );
			}
			else
			{
				return dx_SetUseVertexShader_x64( ShaderHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUsePixelShader")]
		extern static int  dx_SetUsePixelShader_x86( int  ShaderHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUsePixelShader")]
		extern static int  dx_SetUsePixelShader_x64( int  ShaderHandle);
		public static int  SetUsePixelShader( int  ShaderHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUsePixelShader_x86( ShaderHandle );
			}
			else
			{
				return dx_SetUsePixelShader_x64( ShaderHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CalcPolygonBinormalAndTangentsToShader")]
		extern static int  dx_CalcPolygonBinormalAndTangentsToShader_x86( out VERTEX3DSHADER  Vertex, int  PolygonNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CalcPolygonBinormalAndTangentsToShader")]
		extern static int  dx_CalcPolygonBinormalAndTangentsToShader_x64( out VERTEX3DSHADER  Vertex, int  PolygonNum);
		public static int  CalcPolygonBinormalAndTangentsToShader( out VERTEX3DSHADER  Vertex, int  PolygonNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CalcPolygonBinormalAndTangentsToShader_x86( out Vertex , PolygonNum );
			}
			else
			{
				return dx_CalcPolygonBinormalAndTangentsToShader_x64( out Vertex , PolygonNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CalcPolygonIndexedBinormalAndTangentsToShader")]
		extern static int  dx_CalcPolygonIndexedBinormalAndTangentsToShader_x86( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CalcPolygonIndexedBinormalAndTangentsToShader")]
		extern static int  dx_CalcPolygonIndexedBinormalAndTangentsToShader_x64( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum);
		public static int  CalcPolygonIndexedBinormalAndTangentsToShader( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CalcPolygonIndexedBinormalAndTangentsToShader_x86( out Vertex , VertexNum , out Indices , PolygonNum );
			}
			else
			{
				return dx_CalcPolygonIndexedBinormalAndTangentsToShader_x64( out Vertex , VertexNum , out Indices , PolygonNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon2DToShader")]
		extern static int  dx_DrawPolygon2DToShader_x86( out VERTEX2DSHADER  Vertex, int  PolygonNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygon2DToShader")]
		extern static int  dx_DrawPolygon2DToShader_x64( out VERTEX2DSHADER  Vertex, int  PolygonNum);
		public static int  DrawPolygon2DToShader( out VERTEX2DSHADER  Vertex, int  PolygonNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon2DToShader_x86( out Vertex , PolygonNum );
			}
			else
			{
				return dx_DrawPolygon2DToShader_x64( out Vertex , PolygonNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3DToShader")]
		extern static int  dx_DrawPolygon3DToShader_x86( out VERTEX3DSHADER  Vertex, int  PolygonNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygon3DToShader")]
		extern static int  dx_DrawPolygon3DToShader_x64( out VERTEX3DSHADER  Vertex, int  PolygonNum);
		public static int  DrawPolygon3DToShader( out VERTEX3DSHADER  Vertex, int  PolygonNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon3DToShader_x86( out Vertex , PolygonNum );
			}
			else
			{
				return dx_DrawPolygon3DToShader_x64( out Vertex , PolygonNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed2DToShader")]
		extern static int  dx_DrawPolygonIndexed2DToShader_x86( out VERTEX2DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygonIndexed2DToShader")]
		extern static int  dx_DrawPolygonIndexed2DToShader_x64( out VERTEX2DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum);
		public static int  DrawPolygonIndexed2DToShader( out VERTEX2DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygonIndexed2DToShader_x86( out Vertex , VertexNum , out Indices , PolygonNum );
			}
			else
			{
				return dx_DrawPolygonIndexed2DToShader_x64( out Vertex , VertexNum , out Indices , PolygonNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed3DToShader")]
		extern static int  dx_DrawPolygonIndexed3DToShader_x86( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygonIndexed3DToShader")]
		extern static int  dx_DrawPolygonIndexed3DToShader_x64( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum);
		public static int  DrawPolygonIndexed3DToShader( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  PolygonNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygonIndexed3DToShader_x86( out Vertex , VertexNum , out Indices , PolygonNum );
			}
			else
			{
				return dx_DrawPolygonIndexed3DToShader_x64( out Vertex , VertexNum , out Indices , PolygonNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive2DToShader")]
		extern static int  dx_DrawPrimitive2DToShader_x86( out VERTEX2DSHADER  Vertex, int  VertexNum, int  PrimitiveType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitive2DToShader")]
		extern static int  dx_DrawPrimitive2DToShader_x64( out VERTEX2DSHADER  Vertex, int  VertexNum, int  PrimitiveType);
		public static int  DrawPrimitive2DToShader( out VERTEX2DSHADER  Vertex, int  VertexNum, int  PrimitiveType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitive2DToShader_x86( out Vertex , VertexNum , PrimitiveType );
			}
			else
			{
				return dx_DrawPrimitive2DToShader_x64( out Vertex , VertexNum , PrimitiveType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3DToShader")]
		extern static int  dx_DrawPrimitive3DToShader_x86( out VERTEX3DSHADER  Vertex, int  VertexNum, int  PrimitiveType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitive3DToShader")]
		extern static int  dx_DrawPrimitive3DToShader_x64( out VERTEX3DSHADER  Vertex, int  VertexNum, int  PrimitiveType);
		public static int  DrawPrimitive3DToShader( out VERTEX3DSHADER  Vertex, int  VertexNum, int  PrimitiveType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitive3DToShader_x86( out Vertex , VertexNum , PrimitiveType );
			}
			else
			{
				return dx_DrawPrimitive3DToShader_x64( out Vertex , VertexNum , PrimitiveType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed2DToShader")]
		extern static int  dx_DrawPrimitiveIndexed2DToShader_x86( out VERTEX2DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitiveIndexed2DToShader")]
		extern static int  dx_DrawPrimitiveIndexed2DToShader_x64( out VERTEX2DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType);
		public static int  DrawPrimitiveIndexed2DToShader( out VERTEX2DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitiveIndexed2DToShader_x86( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType );
			}
			else
			{
				return dx_DrawPrimitiveIndexed2DToShader_x64( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3DToShader")]
		extern static int  dx_DrawPrimitiveIndexed3DToShader_x86( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitiveIndexed3DToShader")]
		extern static int  dx_DrawPrimitiveIndexed3DToShader_x64( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType);
		public static int  DrawPrimitiveIndexed3DToShader( out VERTEX3DSHADER  Vertex, int  VertexNum, out ushort  Indices, int  IndexNum, int  PrimitiveType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitiveIndexed3DToShader_x86( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType );
			}
			else
			{
				return dx_DrawPrimitiveIndexed3DToShader_x64( out Vertex , VertexNum , out Indices , IndexNum , PrimitiveType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygon3DToShader_UseVertexBuffer")]
		extern static int  dx_DrawPolygon3DToShader_UseVertexBuffer_x86( int  VertexBufHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygon3DToShader_UseVertexBuffer")]
		extern static int  dx_DrawPolygon3DToShader_UseVertexBuffer_x64( int  VertexBufHandle);
		public static int  DrawPolygon3DToShader_UseVertexBuffer( int  VertexBufHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygon3DToShader_UseVertexBuffer_x86( VertexBufHandle );
			}
			else
			{
				return dx_DrawPolygon3DToShader_UseVertexBuffer_x64( VertexBufHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPolygonIndexed3DToShader_UseVertexBuffer")]
		extern static int  dx_DrawPolygonIndexed3DToShader_UseVertexBuffer_x86( int  VertexBufHandle, int  IndexBufHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPolygonIndexed3DToShader_UseVertexBuffer")]
		extern static int  dx_DrawPolygonIndexed3DToShader_UseVertexBuffer_x64( int  VertexBufHandle, int  IndexBufHandle);
		public static int  DrawPolygonIndexed3DToShader_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPolygonIndexed3DToShader_UseVertexBuffer_x86( VertexBufHandle , IndexBufHandle );
			}
			else
			{
				return dx_DrawPolygonIndexed3DToShader_UseVertexBuffer_x64( VertexBufHandle , IndexBufHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3DToShader_UseVertexBuffer")]
		extern static int  dx_DrawPrimitive3DToShader_UseVertexBuffer_x86( int  VertexBufHandle, int  PrimitiveType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitive3DToShader_UseVertexBuffer")]
		extern static int  dx_DrawPrimitive3DToShader_UseVertexBuffer_x64( int  VertexBufHandle, int  PrimitiveType);
		public static int  DrawPrimitive3DToShader_UseVertexBuffer( int  VertexBufHandle, int  PrimitiveType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitive3DToShader_UseVertexBuffer_x86( VertexBufHandle , PrimitiveType );
			}
			else
			{
				return dx_DrawPrimitive3DToShader_UseVertexBuffer_x64( VertexBufHandle , PrimitiveType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitive3DToShader_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitive3DToShader_UseVertexBuffer2_x86( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitive3DToShader_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitive3DToShader_UseVertexBuffer2_x64( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum);
		public static int  DrawPrimitive3DToShader_UseVertexBuffer2( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitive3DToShader_UseVertexBuffer2_x86( VertexBufHandle , PrimitiveType , StartVertex , UseVertexNum );
			}
			else
			{
				return dx_DrawPrimitive3DToShader_UseVertexBuffer2_x64( VertexBufHandle , PrimitiveType , StartVertex , UseVertexNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer")]
		extern static int  dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer_x86( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer")]
		extern static int  dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer_x64( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType);
		public static int  DrawPrimitiveIndexed3DToShader_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer_x86( VertexBufHandle , IndexBufHandle , PrimitiveType );
			}
			else
			{
				return dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer_x64( VertexBufHandle , IndexBufHandle , PrimitiveType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer2_x86( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer2")]
		extern static int  dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer2_x64( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum);
		public static int  DrawPrimitiveIndexed3DToShader_UseVertexBuffer2( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer2_x86( VertexBufHandle , IndexBufHandle , PrimitiveType , BaseVertex , StartVertex , UseVertexNum , StartIndex , UseIndexNum );
			}
			else
			{
				return dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer2_x64( VertexBufHandle , IndexBufHandle , PrimitiveType , BaseVertex , StartVertex , UseVertexNum , StartIndex , UseIndexNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMovie")]
		extern static int  dx_PlayMovie_x86( string  FileName, int  ExRate, int  PlayType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlayMovie")]
		extern static int  dx_PlayMovie_x64( string  FileName, int  ExRate, int  PlayType);
		public static int  PlayMovie( string  FileName, int  ExRate, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayMovie_x86( FileName , ExRate , PlayType );
			}
			else
			{
				return dx_PlayMovie_x64( FileName , ExRate , PlayType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_OpenMovieToGraph")]
		extern static int  dx_OpenMovieToGraph_x86( string  FileName, int  FullColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_OpenMovieToGraph")]
		extern static int  dx_OpenMovieToGraph_x64( string  FileName, int  FullColor);
		public static int  OpenMovieToGraph( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_OpenMovieToGraph_x86( FileName , TRUE );
			}
			else
			{
				return dx_OpenMovieToGraph_x64( FileName , TRUE );
			}
		}
		public static int  OpenMovieToGraph( string  FileName, int  FullColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_OpenMovieToGraph_x86( FileName , FullColor );
			}
			else
			{
				return dx_OpenMovieToGraph_x64( FileName , FullColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMovieToGraph")]
		extern static int  dx_PlayMovieToGraph_x86( int  GraphHandle, int  PlayType, int  SysPlay);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlayMovieToGraph")]
		extern static int  dx_PlayMovieToGraph_x64( int  GraphHandle, int  PlayType, int  SysPlay);
		public static int  PlayMovieToGraph( int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayMovieToGraph_x86( GraphHandle , DX_PLAYTYPE_BACK , 0 );
			}
			else
			{
				return dx_PlayMovieToGraph_x64( GraphHandle , DX_PLAYTYPE_BACK , 0 );
			}
		}
		public static int  PlayMovieToGraph( int  GraphHandle, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayMovieToGraph_x86( GraphHandle , PlayType , 0 );
			}
			else
			{
				return dx_PlayMovieToGraph_x64( GraphHandle , PlayType , 0 );
			}
		}
		public static int  PlayMovieToGraph( int  GraphHandle, int  PlayType, int  SysPlay)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayMovieToGraph_x86( GraphHandle , PlayType , SysPlay );
			}
			else
			{
				return dx_PlayMovieToGraph_x64( GraphHandle , PlayType , SysPlay );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PauseMovieToGraph")]
		extern static int  dx_PauseMovieToGraph_x86( int  GraphHandle, int  SysPause);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PauseMovieToGraph")]
		extern static int  dx_PauseMovieToGraph_x64( int  GraphHandle, int  SysPause);
		public static int  PauseMovieToGraph( int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PauseMovieToGraph_x86( GraphHandle , 0 );
			}
			else
			{
				return dx_PauseMovieToGraph_x64( GraphHandle , 0 );
			}
		}
		public static int  PauseMovieToGraph( int  GraphHandle, int  SysPause)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PauseMovieToGraph_x86( GraphHandle , SysPause );
			}
			else
			{
				return dx_PauseMovieToGraph_x64( GraphHandle , SysPause );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddMovieFrameToGraph")]
		extern static int  dx_AddMovieFrameToGraph_x86( int  GraphHandle, uint  FrameNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddMovieFrameToGraph")]
		extern static int  dx_AddMovieFrameToGraph_x64( int  GraphHandle, uint  FrameNum);
		public static int  AddMovieFrameToGraph( int  GraphHandle, uint  FrameNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddMovieFrameToGraph_x86( GraphHandle , FrameNum );
			}
			else
			{
				return dx_AddMovieFrameToGraph_x64( GraphHandle , FrameNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SeekMovieToGraph")]
		extern static int  dx_SeekMovieToGraph_x86( int  GraphHandle, int  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SeekMovieToGraph")]
		extern static int  dx_SeekMovieToGraph_x64( int  GraphHandle, int  Time);
		public static int  SeekMovieToGraph( int  GraphHandle, int  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SeekMovieToGraph_x86( GraphHandle , Time );
			}
			else
			{
				return dx_SeekMovieToGraph_x64( GraphHandle , Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMovieStateToGraph")]
		extern static int  dx_GetMovieStateToGraph_x86( int  GraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMovieStateToGraph")]
		extern static int  dx_GetMovieStateToGraph_x64( int  GraphHandle);
		public static int  GetMovieStateToGraph( int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMovieStateToGraph_x86( GraphHandle );
			}
			else
			{
				return dx_GetMovieStateToGraph_x64( GraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMovieVolumeToGraph")]
		extern static int  dx_SetMovieVolumeToGraph_x86( int  Volume, int  GraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMovieVolumeToGraph")]
		extern static int  dx_SetMovieVolumeToGraph_x64( int  Volume, int  GraphHandle);
		public static int  SetMovieVolumeToGraph( int  Volume, int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMovieVolumeToGraph_x86( Volume , GraphHandle );
			}
			else
			{
				return dx_SetMovieVolumeToGraph_x64( Volume , GraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeMovieVolumeToGraph")]
		extern static int  dx_ChangeMovieVolumeToGraph_x86( int  Volume, int  GraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ChangeMovieVolumeToGraph")]
		extern static int  dx_ChangeMovieVolumeToGraph_x64( int  Volume, int  GraphHandle);
		public static int  ChangeMovieVolumeToGraph( int  Volume, int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeMovieVolumeToGraph_x86( Volume , GraphHandle );
			}
			else
			{
				return dx_ChangeMovieVolumeToGraph_x64( Volume , GraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMovieTotalFrameToGraph")]
		extern static int  dx_GetMovieTotalFrameToGraph_x86( int  GraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMovieTotalFrameToGraph")]
		extern static int  dx_GetMovieTotalFrameToGraph_x64( int  GraphHandle);
		public static int  GetMovieTotalFrameToGraph( int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMovieTotalFrameToGraph_x86( GraphHandle );
			}
			else
			{
				return dx_GetMovieTotalFrameToGraph_x64( GraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_TellMovieToGraph")]
		extern static int  dx_TellMovieToGraph_x86( int  GraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_TellMovieToGraph")]
		extern static int  dx_TellMovieToGraph_x64( int  GraphHandle);
		public static int  TellMovieToGraph( int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_TellMovieToGraph_x86( GraphHandle );
			}
			else
			{
				return dx_TellMovieToGraph_x64( GraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_TellMovieToGraphToFrame")]
		extern static int  dx_TellMovieToGraphToFrame_x86( int  GraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_TellMovieToGraphToFrame")]
		extern static int  dx_TellMovieToGraphToFrame_x64( int  GraphHandle);
		public static int  TellMovieToGraphToFrame( int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_TellMovieToGraphToFrame_x86( GraphHandle );
			}
			else
			{
				return dx_TellMovieToGraphToFrame_x64( GraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SeekMovieToGraphToFrame")]
		extern static int  dx_SeekMovieToGraphToFrame_x86( int  GraphHandle, int  Frame);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SeekMovieToGraphToFrame")]
		extern static int  dx_SeekMovieToGraphToFrame_x64( int  GraphHandle, int  Frame);
		public static int  SeekMovieToGraphToFrame( int  GraphHandle, int  Frame)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SeekMovieToGraphToFrame_x86( GraphHandle , Frame );
			}
			else
			{
				return dx_SeekMovieToGraphToFrame_x64( GraphHandle , Frame );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetOneFrameTimeMovieToGraph")]
		extern static long  dx_GetOneFrameTimeMovieToGraph_x86( int  GraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetOneFrameTimeMovieToGraph")]
		extern static long  dx_GetOneFrameTimeMovieToGraph_x64( int  GraphHandle);
		public static long  GetOneFrameTimeMovieToGraph( int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetOneFrameTimeMovieToGraph_x86( GraphHandle );
			}
			else
			{
				return dx_GetOneFrameTimeMovieToGraph_x64( GraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLastUpdateTimeMovieToGraph")]
		extern static int  dx_GetLastUpdateTimeMovieToGraph_x86( int  GraphHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLastUpdateTimeMovieToGraph")]
		extern static int  dx_GetLastUpdateTimeMovieToGraph_x64( int  GraphHandle);
		public static int  GetLastUpdateTimeMovieToGraph( int  GraphHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLastUpdateTimeMovieToGraph_x86( GraphHandle );
			}
			else
			{
				return dx_GetLastUpdateTimeMovieToGraph_x64( GraphHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMovieRightImageAlphaFlag")]
		extern static int  dx_SetMovieRightImageAlphaFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMovieRightImageAlphaFlag")]
		extern static int  dx_SetMovieRightImageAlphaFlag_x64( int  Flag);
		public static int  SetMovieRightImageAlphaFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMovieRightImageAlphaFlag_x86( Flag );
			}
			else
			{
				return dx_SetMovieRightImageAlphaFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraNearFar")]
		extern static int  dx_SetCameraNearFar_x86( float  Near, float  Far);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCameraNearFar")]
		extern static int  dx_SetCameraNearFar_x64( float  Near, float  Far);
		public static int  SetCameraNearFar( float  Near, float  Far)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCameraNearFar_x86( Near , Far );
			}
			else
			{
				return dx_SetCameraNearFar_x64( Near , Far );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraPositionAndTarget_UpVecY")]
		extern static int  dx_SetCameraPositionAndTarget_UpVecY_x86( VECTOR  Position, VECTOR  Target);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCameraPositionAndTarget_UpVecY")]
		extern static int  dx_SetCameraPositionAndTarget_UpVecY_x64( VECTOR  Position, VECTOR  Target);
		public static int  SetCameraPositionAndTarget_UpVecY( VECTOR  Position, VECTOR  Target)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCameraPositionAndTarget_UpVecY_x86( Position , Target );
			}
			else
			{
				return dx_SetCameraPositionAndTarget_UpVecY_x64( Position , Target );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraPositionAndTargetAndUpVec")]
		extern static int  dx_SetCameraPositionAndTargetAndUpVec_x86( VECTOR  Position, VECTOR  TargetPosition, VECTOR  UpVector);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCameraPositionAndTargetAndUpVec")]
		extern static int  dx_SetCameraPositionAndTargetAndUpVec_x64( VECTOR  Position, VECTOR  TargetPosition, VECTOR  UpVector);
		public static int  SetCameraPositionAndTargetAndUpVec( VECTOR  Position, VECTOR  TargetPosition, VECTOR  UpVector)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCameraPositionAndTargetAndUpVec_x86( Position , TargetPosition , UpVector );
			}
			else
			{
				return dx_SetCameraPositionAndTargetAndUpVec_x64( Position , TargetPosition , UpVector );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraPositionAndAngle")]
		extern static int  dx_SetCameraPositionAndAngle_x86( VECTOR  Position, float  VRotate, float  HRotate, float  TRotate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCameraPositionAndAngle")]
		extern static int  dx_SetCameraPositionAndAngle_x64( VECTOR  Position, float  VRotate, float  HRotate, float  TRotate);
		public static int  SetCameraPositionAndAngle( VECTOR  Position, float  VRotate, float  HRotate, float  TRotate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCameraPositionAndAngle_x86( Position , VRotate , HRotate , TRotate );
			}
			else
			{
				return dx_SetCameraPositionAndAngle_x64( Position , VRotate , HRotate , TRotate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraViewMatrix")]
		extern static int  dx_SetCameraViewMatrix_x86( MATRIX  ViewMatrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCameraViewMatrix")]
		extern static int  dx_SetCameraViewMatrix_x64( MATRIX  ViewMatrix);
		public static int  SetCameraViewMatrix( MATRIX  ViewMatrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCameraViewMatrix_x86( ViewMatrix );
			}
			else
			{
				return dx_SetCameraViewMatrix_x64( ViewMatrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraScreenCenter")]
		extern static int  dx_SetCameraScreenCenter_x86( float  x, float  y);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCameraScreenCenter")]
		extern static int  dx_SetCameraScreenCenter_x64( float  x, float  y);
		public static int  SetCameraScreenCenter( float  x, float  y)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCameraScreenCenter_x86( x , y );
			}
			else
			{
				return dx_SetCameraScreenCenter_x64( x , y );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupCamera_Perspective")]
		extern static int  dx_SetupCamera_Perspective_x86( float  Fov);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetupCamera_Perspective")]
		extern static int  dx_SetupCamera_Perspective_x64( float  Fov);
		public static int  SetupCamera_Perspective( float  Fov)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetupCamera_Perspective_x86( Fov );
			}
			else
			{
				return dx_SetupCamera_Perspective_x64( Fov );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupCamera_Ortho")]
		extern static int  dx_SetupCamera_Ortho_x86( float  Size);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetupCamera_Ortho")]
		extern static int  dx_SetupCamera_Ortho_x64( float  Size);
		public static int  SetupCamera_Ortho( float  Size)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetupCamera_Ortho_x86( Size );
			}
			else
			{
				return dx_SetupCamera_Ortho_x64( Size );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupCamera_ProjectionMatrix")]
		extern static int  dx_SetupCamera_ProjectionMatrix_x86( MATRIX  ProjectionMatrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetupCamera_ProjectionMatrix")]
		extern static int  dx_SetupCamera_ProjectionMatrix_x64( MATRIX  ProjectionMatrix);
		public static int  SetupCamera_ProjectionMatrix( MATRIX  ProjectionMatrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetupCamera_ProjectionMatrix_x86( ProjectionMatrix );
			}
			else
			{
				return dx_SetupCamera_ProjectionMatrix_x64( ProjectionMatrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCameraDotAspect")]
		extern static int  dx_SetCameraDotAspect_x86( float  DotAspect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCameraDotAspect")]
		extern static int  dx_SetCameraDotAspect_x64( float  DotAspect);
		public static int  SetCameraDotAspect( float  DotAspect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCameraDotAspect_x86( DotAspect );
			}
			else
			{
				return dx_SetCameraDotAspect_x64( DotAspect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckCameraViewClip")]
		extern static int  dx_CheckCameraViewClip_x86( VECTOR  CheckPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckCameraViewClip")]
		extern static int  dx_CheckCameraViewClip_x64( VECTOR  CheckPos);
		public static int  CheckCameraViewClip( VECTOR  CheckPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckCameraViewClip_x86( CheckPos );
			}
			else
			{
				return dx_CheckCameraViewClip_x64( CheckPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckCameraViewClip_Dir")]
		extern static int  dx_CheckCameraViewClip_Dir_x86( VECTOR  CheckPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckCameraViewClip_Dir")]
		extern static int  dx_CheckCameraViewClip_Dir_x64( VECTOR  CheckPos);
		public static int  CheckCameraViewClip_Dir( VECTOR  CheckPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckCameraViewClip_Dir_x86( CheckPos );
			}
			else
			{
				return dx_CheckCameraViewClip_Dir_x64( CheckPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckCameraViewClip_Box")]
		extern static int  dx_CheckCameraViewClip_Box_x86( VECTOR  BoxPos1, VECTOR  BoxPos2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckCameraViewClip_Box")]
		extern static int  dx_CheckCameraViewClip_Box_x64( VECTOR  BoxPos1, VECTOR  BoxPos2);
		public static int  CheckCameraViewClip_Box( VECTOR  BoxPos1, VECTOR  BoxPos2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckCameraViewClip_Box_x86( BoxPos1 , BoxPos2 );
			}
			else
			{
				return dx_CheckCameraViewClip_Box_x64( BoxPos1 , BoxPos2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraNear")]
		extern static float  dx_GetCameraNear_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraNear")]
		extern static float  dx_GetCameraNear_x64( );
		public static float  GetCameraNear( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraNear_x86( );
			}
			else
			{
				return dx_GetCameraNear_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraFar")]
		extern static float  dx_GetCameraFar_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraFar")]
		extern static float  dx_GetCameraFar_x64( );
		public static float  GetCameraFar( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraFar_x86( );
			}
			else
			{
				return dx_GetCameraFar_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraPosition")]
		extern static VECTOR  dx_GetCameraPosition_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraPosition")]
		extern static VECTOR  dx_GetCameraPosition_x64( );
		public static VECTOR  GetCameraPosition( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraPosition_x86( );
			}
			else
			{
				return dx_GetCameraPosition_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraTarget")]
		extern static VECTOR  dx_GetCameraTarget_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraTarget")]
		extern static VECTOR  dx_GetCameraTarget_x64( );
		public static VECTOR  GetCameraTarget( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraTarget_x86( );
			}
			else
			{
				return dx_GetCameraTarget_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraUpVector")]
		extern static VECTOR  dx_GetCameraUpVector_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraUpVector")]
		extern static VECTOR  dx_GetCameraUpVector_x64( );
		public static VECTOR  GetCameraUpVector( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraUpVector_x86( );
			}
			else
			{
				return dx_GetCameraUpVector_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraAngleHRotate")]
		extern static float  dx_GetCameraAngleHRotate_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraAngleHRotate")]
		extern static float  dx_GetCameraAngleHRotate_x64( );
		public static float  GetCameraAngleHRotate( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraAngleHRotate_x86( );
			}
			else
			{
				return dx_GetCameraAngleHRotate_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraAngleVRotate")]
		extern static float  dx_GetCameraAngleVRotate_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraAngleVRotate")]
		extern static float  dx_GetCameraAngleVRotate_x64( );
		public static float  GetCameraAngleVRotate( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraAngleVRotate_x86( );
			}
			else
			{
				return dx_GetCameraAngleVRotate_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraAngleTRotate")]
		extern static float  dx_GetCameraAngleTRotate_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraAngleTRotate")]
		extern static float  dx_GetCameraAngleTRotate_x64( );
		public static float  GetCameraAngleTRotate( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraAngleTRotate_x86( );
			}
			else
			{
				return dx_GetCameraAngleTRotate_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraViewMatrix")]
		extern static MATRIX  dx_GetCameraViewMatrix_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraViewMatrix")]
		extern static MATRIX  dx_GetCameraViewMatrix_x64( );
		public static MATRIX  GetCameraViewMatrix( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraViewMatrix_x86( );
			}
			else
			{
				return dx_GetCameraViewMatrix_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraBillboardMatrix")]
		extern static MATRIX  dx_GetCameraBillboardMatrix_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraBillboardMatrix")]
		extern static MATRIX  dx_GetCameraBillboardMatrix_x64( );
		public static MATRIX  GetCameraBillboardMatrix( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraBillboardMatrix_x86( );
			}
			else
			{
				return dx_GetCameraBillboardMatrix_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraFov")]
		extern static float  dx_GetCameraFov_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraFov")]
		extern static float  dx_GetCameraFov_x64( );
		public static float  GetCameraFov( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraFov_x86( );
			}
			else
			{
				return dx_GetCameraFov_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraSize")]
		extern static float  dx_GetCameraSize_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraSize")]
		extern static float  dx_GetCameraSize_x64( );
		public static float  GetCameraSize( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraSize_x86( );
			}
			else
			{
				return dx_GetCameraSize_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraProjectionMatrix")]
		extern static MATRIX  dx_GetCameraProjectionMatrix_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraProjectionMatrix")]
		extern static MATRIX  dx_GetCameraProjectionMatrix_x64( );
		public static MATRIX  GetCameraProjectionMatrix( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraProjectionMatrix_x86( );
			}
			else
			{
				return dx_GetCameraProjectionMatrix_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraDotAspect")]
		extern static float  dx_GetCameraDotAspect_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraDotAspect")]
		extern static float  dx_GetCameraDotAspect_x64( );
		public static float  GetCameraDotAspect( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraDotAspect_x86( );
			}
			else
			{
				return dx_GetCameraDotAspect_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraViewportMatrix")]
		extern static MATRIX  dx_GetCameraViewportMatrix_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraViewportMatrix")]
		extern static MATRIX  dx_GetCameraViewportMatrix_x64( );
		public static MATRIX  GetCameraViewportMatrix( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraViewportMatrix_x86( );
			}
			else
			{
				return dx_GetCameraViewportMatrix_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCameraAPIViewportMatrix")]
		extern static MATRIX  dx_GetCameraAPIViewportMatrix_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCameraAPIViewportMatrix")]
		extern static MATRIX  dx_GetCameraAPIViewportMatrix_x64( );
		public static MATRIX  GetCameraAPIViewportMatrix( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCameraAPIViewportMatrix_x86( );
			}
			else
			{
				return dx_GetCameraAPIViewportMatrix_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseLighting")]
		extern static int  dx_SetUseLighting_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseLighting")]
		extern static int  dx_SetUseLighting_x64( int  Flag);
		public static int  SetUseLighting( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseLighting_x86( Flag );
			}
			else
			{
				return dx_SetUseLighting_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaterialUseVertDifColor")]
		extern static int  dx_SetMaterialUseVertDifColor_x86( int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMaterialUseVertDifColor")]
		extern static int  dx_SetMaterialUseVertDifColor_x64( int  UseFlag);
		public static int  SetMaterialUseVertDifColor( int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMaterialUseVertDifColor_x86( UseFlag );
			}
			else
			{
				return dx_SetMaterialUseVertDifColor_x64( UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaterialUseVertSpcColor")]
		extern static int  dx_SetMaterialUseVertSpcColor_x86( int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMaterialUseVertSpcColor")]
		extern static int  dx_SetMaterialUseVertSpcColor_x64( int  UseFlag);
		public static int  SetMaterialUseVertSpcColor( int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMaterialUseVertSpcColor_x86( UseFlag );
			}
			else
			{
				return dx_SetMaterialUseVertSpcColor_x64( UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaterialParam")]
		extern static int  dx_SetMaterialParam_x86( MATERIALPARAM  Material);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMaterialParam")]
		extern static int  dx_SetMaterialParam_x64( MATERIALPARAM  Material);
		public static int  SetMaterialParam( MATERIALPARAM  Material)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMaterialParam_x86( Material );
			}
			else
			{
				return dx_SetMaterialParam_x64( Material );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseSpecular")]
		extern static int  dx_SetUseSpecular_x86( int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseSpecular")]
		extern static int  dx_SetUseSpecular_x64( int  UseFlag);
		public static int  SetUseSpecular( int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseSpecular_x86( UseFlag );
			}
			else
			{
				return dx_SetUseSpecular_x64( UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGlobalAmbientLight")]
		extern static int  dx_SetGlobalAmbientLight_x86( COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetGlobalAmbientLight")]
		extern static int  dx_SetGlobalAmbientLight_x64( COLOR_F  Color);
		public static int  SetGlobalAmbientLight( COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetGlobalAmbientLight_x86( Color );
			}
			else
			{
				return dx_SetGlobalAmbientLight_x64( Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeLightTypeDir")]
		extern static int  dx_ChangeLightTypeDir_x86( VECTOR  Direction);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ChangeLightTypeDir")]
		extern static int  dx_ChangeLightTypeDir_x64( VECTOR  Direction);
		public static int  ChangeLightTypeDir( VECTOR  Direction)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeLightTypeDir_x86( Direction );
			}
			else
			{
				return dx_ChangeLightTypeDir_x64( Direction );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeLightTypeSpot")]
		extern static int  dx_ChangeLightTypeSpot_x86( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ChangeLightTypeSpot")]
		extern static int  dx_ChangeLightTypeSpot_x64( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  ChangeLightTypeSpot( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeLightTypeSpot_x86( Position , Direction , OutAngle , InAngle , Range , Atten0 , Atten1 , Atten2 );
			}
			else
			{
				return dx_ChangeLightTypeSpot_x64( Position , Direction , OutAngle , InAngle , Range , Atten0 , Atten1 , Atten2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeLightTypePoint")]
		extern static int  dx_ChangeLightTypePoint_x86( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ChangeLightTypePoint")]
		extern static int  dx_ChangeLightTypePoint_x64( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  ChangeLightTypePoint( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeLightTypePoint_x86( Position , Range , Atten0 , Atten1 , Atten2 );
			}
			else
			{
				return dx_ChangeLightTypePoint_x64( Position , Range , Atten0 , Atten1 , Atten2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightType")]
		extern static int  dx_GetLightType_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightType")]
		extern static int  dx_GetLightType_x64( );
		public static int  GetLightType( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightType_x86( );
			}
			else
			{
				return dx_GetLightType_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightEnable")]
		extern static int  dx_SetLightEnable_x86( int  EnableFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightEnable")]
		extern static int  dx_SetLightEnable_x64( int  EnableFlag);
		public static int  SetLightEnable( int  EnableFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightEnable_x86( EnableFlag );
			}
			else
			{
				return dx_SetLightEnable_x64( EnableFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightEnable")]
		extern static int  dx_GetLightEnable_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightEnable")]
		extern static int  dx_GetLightEnable_x64( );
		public static int  GetLightEnable( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightEnable_x86( );
			}
			else
			{
				return dx_GetLightEnable_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightDifColor")]
		extern static int  dx_SetLightDifColor_x86( COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightDifColor")]
		extern static int  dx_SetLightDifColor_x64( COLOR_F  Color);
		public static int  SetLightDifColor( COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightDifColor_x86( Color );
			}
			else
			{
				return dx_SetLightDifColor_x64( Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightDifColor")]
		extern static COLOR_F  dx_GetLightDifColor_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightDifColor")]
		extern static COLOR_F  dx_GetLightDifColor_x64( );
		public static COLOR_F  GetLightDifColor( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightDifColor_x86( );
			}
			else
			{
				return dx_GetLightDifColor_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightSpcColor")]
		extern static int  dx_SetLightSpcColor_x86( COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightSpcColor")]
		extern static int  dx_SetLightSpcColor_x64( COLOR_F  Color);
		public static int  SetLightSpcColor( COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightSpcColor_x86( Color );
			}
			else
			{
				return dx_SetLightSpcColor_x64( Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightSpcColor")]
		extern static COLOR_F  dx_GetLightSpcColor_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightSpcColor")]
		extern static COLOR_F  dx_GetLightSpcColor_x64( );
		public static COLOR_F  GetLightSpcColor( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightSpcColor_x86( );
			}
			else
			{
				return dx_GetLightSpcColor_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightAmbColor")]
		extern static int  dx_SetLightAmbColor_x86( COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightAmbColor")]
		extern static int  dx_SetLightAmbColor_x64( COLOR_F  Color);
		public static int  SetLightAmbColor( COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightAmbColor_x86( Color );
			}
			else
			{
				return dx_SetLightAmbColor_x64( Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightAmbColor")]
		extern static COLOR_F  dx_GetLightAmbColor_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightAmbColor")]
		extern static COLOR_F  dx_GetLightAmbColor_x64( );
		public static COLOR_F  GetLightAmbColor( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightAmbColor_x86( );
			}
			else
			{
				return dx_GetLightAmbColor_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightDirection")]
		extern static int  dx_SetLightDirection_x86( VECTOR  Direction);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightDirection")]
		extern static int  dx_SetLightDirection_x64( VECTOR  Direction);
		public static int  SetLightDirection( VECTOR  Direction)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightDirection_x86( Direction );
			}
			else
			{
				return dx_SetLightDirection_x64( Direction );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightDirection")]
		extern static VECTOR  dx_GetLightDirection_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightDirection")]
		extern static VECTOR  dx_GetLightDirection_x64( );
		public static VECTOR  GetLightDirection( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightDirection_x86( );
			}
			else
			{
				return dx_GetLightDirection_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightPosition")]
		extern static int  dx_SetLightPosition_x86( VECTOR  Position);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightPosition")]
		extern static int  dx_SetLightPosition_x64( VECTOR  Position);
		public static int  SetLightPosition( VECTOR  Position)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightPosition_x86( Position );
			}
			else
			{
				return dx_SetLightPosition_x64( Position );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightPosition")]
		extern static VECTOR  dx_GetLightPosition_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightPosition")]
		extern static VECTOR  dx_GetLightPosition_x64( );
		public static VECTOR  GetLightPosition( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightPosition_x86( );
			}
			else
			{
				return dx_GetLightPosition_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightRangeAtten")]
		extern static int  dx_SetLightRangeAtten_x86( float  Range, float  Atten0, float  Atten1, float  Atten2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightRangeAtten")]
		extern static int  dx_SetLightRangeAtten_x64( float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  SetLightRangeAtten( float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightRangeAtten_x86( Range , Atten0 , Atten1 , Atten2 );
			}
			else
			{
				return dx_SetLightRangeAtten_x64( Range , Atten0 , Atten1 , Atten2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightRangeAtten")]
		extern static int  dx_GetLightRangeAtten_x86( out float  Range, out float  Atten0, out float  Atten1, out float  Atten2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightRangeAtten")]
		extern static int  dx_GetLightRangeAtten_x64( out float  Range, out float  Atten0, out float  Atten1, out float  Atten2);
		public static int  GetLightRangeAtten( out float  Range, out float  Atten0, out float  Atten1, out float  Atten2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightRangeAtten_x86( out Range , out Atten0 , out Atten1 , out Atten2 );
			}
			else
			{
				return dx_GetLightRangeAtten_x64( out Range , out Atten0 , out Atten1 , out Atten2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightAngle")]
		extern static int  dx_SetLightAngle_x86( float  OutAngle, float  InAngle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightAngle")]
		extern static int  dx_SetLightAngle_x64( float  OutAngle, float  InAngle);
		public static int  SetLightAngle( float  OutAngle, float  InAngle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightAngle_x86( OutAngle , InAngle );
			}
			else
			{
				return dx_SetLightAngle_x64( OutAngle , InAngle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightAngle")]
		extern static int  dx_GetLightAngle_x86( out float  OutAngle, out float  InAngle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightAngle")]
		extern static int  dx_GetLightAngle_x64( out float  OutAngle, out float  InAngle);
		public static int  GetLightAngle( out float  OutAngle, out float  InAngle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightAngle_x86( out OutAngle , out InAngle );
			}
			else
			{
				return dx_GetLightAngle_x64( out OutAngle , out InAngle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateDirLightHandle")]
		extern static int  dx_CreateDirLightHandle_x86( VECTOR  Direction);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateDirLightHandle")]
		extern static int  dx_CreateDirLightHandle_x64( VECTOR  Direction);
		public static int  CreateDirLightHandle( VECTOR  Direction)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateDirLightHandle_x86( Direction );
			}
			else
			{
				return dx_CreateDirLightHandle_x64( Direction );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateSpotLightHandle")]
		extern static int  dx_CreateSpotLightHandle_x86( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateSpotLightHandle")]
		extern static int  dx_CreateSpotLightHandle_x64( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  CreateSpotLightHandle( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateSpotLightHandle_x86( Position , Direction , OutAngle , InAngle , Range , Atten0 , Atten1 , Atten2 );
			}
			else
			{
				return dx_CreateSpotLightHandle_x64( Position , Direction , OutAngle , InAngle , Range , Atten0 , Atten1 , Atten2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePointLightHandle")]
		extern static int  dx_CreatePointLightHandle_x86( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreatePointLightHandle")]
		extern static int  dx_CreatePointLightHandle_x64( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  CreatePointLightHandle( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreatePointLightHandle_x86( Position , Range , Atten0 , Atten1 , Atten2 );
			}
			else
			{
				return dx_CreatePointLightHandle_x64( Position , Range , Atten0 , Atten1 , Atten2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteLightHandle")]
		extern static int  dx_DeleteLightHandle_x86( int  LHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteLightHandle")]
		extern static int  dx_DeleteLightHandle_x64( int  LHandle);
		public static int  DeleteLightHandle( int  LHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteLightHandle_x86( LHandle );
			}
			else
			{
				return dx_DeleteLightHandle_x64( LHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteLightHandleAll")]
		extern static int  dx_DeleteLightHandleAll_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteLightHandleAll")]
		extern static int  dx_DeleteLightHandleAll_x64( );
		public static int  DeleteLightHandleAll( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteLightHandleAll_x86( );
			}
			else
			{
				return dx_DeleteLightHandleAll_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightTypeHandle")]
		extern static int  dx_SetLightTypeHandle_x86( int  LHandle, int  LightType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightTypeHandle")]
		extern static int  dx_SetLightTypeHandle_x64( int  LHandle, int  LightType);
		public static int  SetLightTypeHandle( int  LHandle, int  LightType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightTypeHandle_x86( LHandle , LightType );
			}
			else
			{
				return dx_SetLightTypeHandle_x64( LHandle , LightType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightEnableHandle")]
		extern static int  dx_SetLightEnableHandle_x86( int  LHandle, int  EnableFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightEnableHandle")]
		extern static int  dx_SetLightEnableHandle_x64( int  LHandle, int  EnableFlag);
		public static int  SetLightEnableHandle( int  LHandle, int  EnableFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightEnableHandle_x86( LHandle , EnableFlag );
			}
			else
			{
				return dx_SetLightEnableHandle_x64( LHandle , EnableFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightDifColorHandle")]
		extern static int  dx_SetLightDifColorHandle_x86( int  LHandle, COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightDifColorHandle")]
		extern static int  dx_SetLightDifColorHandle_x64( int  LHandle, COLOR_F  Color);
		public static int  SetLightDifColorHandle( int  LHandle, COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightDifColorHandle_x86( LHandle , Color );
			}
			else
			{
				return dx_SetLightDifColorHandle_x64( LHandle , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightSpcColorHandle")]
		extern static int  dx_SetLightSpcColorHandle_x86( int  LHandle, COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightSpcColorHandle")]
		extern static int  dx_SetLightSpcColorHandle_x64( int  LHandle, COLOR_F  Color);
		public static int  SetLightSpcColorHandle( int  LHandle, COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightSpcColorHandle_x86( LHandle , Color );
			}
			else
			{
				return dx_SetLightSpcColorHandle_x64( LHandle , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightAmbColorHandle")]
		extern static int  dx_SetLightAmbColorHandle_x86( int  LHandle, COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightAmbColorHandle")]
		extern static int  dx_SetLightAmbColorHandle_x64( int  LHandle, COLOR_F  Color);
		public static int  SetLightAmbColorHandle( int  LHandle, COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightAmbColorHandle_x86( LHandle , Color );
			}
			else
			{
				return dx_SetLightAmbColorHandle_x64( LHandle , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightDirectionHandle")]
		extern static int  dx_SetLightDirectionHandle_x86( int  LHandle, VECTOR  Direction);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightDirectionHandle")]
		extern static int  dx_SetLightDirectionHandle_x64( int  LHandle, VECTOR  Direction);
		public static int  SetLightDirectionHandle( int  LHandle, VECTOR  Direction)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightDirectionHandle_x86( LHandle , Direction );
			}
			else
			{
				return dx_SetLightDirectionHandle_x64( LHandle , Direction );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightPositionHandle")]
		extern static int  dx_SetLightPositionHandle_x86( int  LHandle, VECTOR  Position);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightPositionHandle")]
		extern static int  dx_SetLightPositionHandle_x64( int  LHandle, VECTOR  Position);
		public static int  SetLightPositionHandle( int  LHandle, VECTOR  Position)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightPositionHandle_x86( LHandle , Position );
			}
			else
			{
				return dx_SetLightPositionHandle_x64( LHandle , Position );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightRangeAttenHandle")]
		extern static int  dx_SetLightRangeAttenHandle_x86( int  LHandle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightRangeAttenHandle")]
		extern static int  dx_SetLightRangeAttenHandle_x64( int  LHandle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  SetLightRangeAttenHandle( int  LHandle, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightRangeAttenHandle_x86( LHandle , Range , Atten0 , Atten1 , Atten2 );
			}
			else
			{
				return dx_SetLightRangeAttenHandle_x64( LHandle , Range , Atten0 , Atten1 , Atten2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLightAngleHandle")]
		extern static int  dx_SetLightAngleHandle_x86( int  LHandle, float  OutAngle, float  InAngle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLightAngleHandle")]
		extern static int  dx_SetLightAngleHandle_x64( int  LHandle, float  OutAngle, float  InAngle);
		public static int  SetLightAngleHandle( int  LHandle, float  OutAngle, float  InAngle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLightAngleHandle_x86( LHandle , OutAngle , InAngle );
			}
			else
			{
				return dx_SetLightAngleHandle_x64( LHandle , OutAngle , InAngle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightTypeHandle")]
		extern static int  dx_GetLightTypeHandle_x86( int  LHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightTypeHandle")]
		extern static int  dx_GetLightTypeHandle_x64( int  LHandle);
		public static int  GetLightTypeHandle( int  LHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightTypeHandle_x86( LHandle );
			}
			else
			{
				return dx_GetLightTypeHandle_x64( LHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightEnableHandle")]
		extern static int  dx_GetLightEnableHandle_x86( int  LHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightEnableHandle")]
		extern static int  dx_GetLightEnableHandle_x64( int  LHandle);
		public static int  GetLightEnableHandle( int  LHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightEnableHandle_x86( LHandle );
			}
			else
			{
				return dx_GetLightEnableHandle_x64( LHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightDifColorHandle")]
		extern static COLOR_F  dx_GetLightDifColorHandle_x86( int  LHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightDifColorHandle")]
		extern static COLOR_F  dx_GetLightDifColorHandle_x64( int  LHandle);
		public static COLOR_F  GetLightDifColorHandle( int  LHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightDifColorHandle_x86( LHandle );
			}
			else
			{
				return dx_GetLightDifColorHandle_x64( LHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightSpcColorHandle")]
		extern static COLOR_F  dx_GetLightSpcColorHandle_x86( int  LHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightSpcColorHandle")]
		extern static COLOR_F  dx_GetLightSpcColorHandle_x64( int  LHandle);
		public static COLOR_F  GetLightSpcColorHandle( int  LHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightSpcColorHandle_x86( LHandle );
			}
			else
			{
				return dx_GetLightSpcColorHandle_x64( LHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightAmbColorHandle")]
		extern static COLOR_F  dx_GetLightAmbColorHandle_x86( int  LHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightAmbColorHandle")]
		extern static COLOR_F  dx_GetLightAmbColorHandle_x64( int  LHandle);
		public static COLOR_F  GetLightAmbColorHandle( int  LHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightAmbColorHandle_x86( LHandle );
			}
			else
			{
				return dx_GetLightAmbColorHandle_x64( LHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightDirectionHandle")]
		extern static VECTOR  dx_GetLightDirectionHandle_x86( int  LHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightDirectionHandle")]
		extern static VECTOR  dx_GetLightDirectionHandle_x64( int  LHandle);
		public static VECTOR  GetLightDirectionHandle( int  LHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightDirectionHandle_x86( LHandle );
			}
			else
			{
				return dx_GetLightDirectionHandle_x64( LHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightPositionHandle")]
		extern static VECTOR  dx_GetLightPositionHandle_x86( int  LHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightPositionHandle")]
		extern static VECTOR  dx_GetLightPositionHandle_x64( int  LHandle);
		public static VECTOR  GetLightPositionHandle( int  LHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightPositionHandle_x86( LHandle );
			}
			else
			{
				return dx_GetLightPositionHandle_x64( LHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightRangeAttenHandle")]
		extern static int  dx_GetLightRangeAttenHandle_x86( int  LHandle, out float  Range, out float  Atten0, out float  Atten1, out float  Atten2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightRangeAttenHandle")]
		extern static int  dx_GetLightRangeAttenHandle_x64( int  LHandle, out float  Range, out float  Atten0, out float  Atten1, out float  Atten2);
		public static int  GetLightRangeAttenHandle( int  LHandle, out float  Range, out float  Atten0, out float  Atten1, out float  Atten2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightRangeAttenHandle_x86( LHandle , out Range , out Atten0 , out Atten1 , out Atten2 );
			}
			else
			{
				return dx_GetLightRangeAttenHandle_x64( LHandle , out Range , out Atten0 , out Atten1 , out Atten2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetLightAngleHandle")]
		extern static int  dx_GetLightAngleHandle_x86( int  LHandle, out float  OutAngle, out float  InAngle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetLightAngleHandle")]
		extern static int  dx_GetLightAngleHandle_x64( int  LHandle, out float  OutAngle, out float  InAngle);
		public static int  GetLightAngleHandle( int  LHandle, out float  OutAngle, out float  InAngle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetLightAngleHandle_x86( LHandle , out OutAngle , out InAngle );
			}
			else
			{
				return dx_GetLightAngleHandle_x64( LHandle , out OutAngle , out InAngle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetEnableLightHandleNum")]
		extern static int  dx_GetEnableLightHandleNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetEnableLightHandleNum")]
		extern static int  dx_GetEnableLightHandleNum_x64( );
		public static int  GetEnableLightHandleNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetEnableLightHandleNum_x86( );
			}
			else
			{
				return dx_GetEnableLightHandleNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetEnableLightHandle")]
		extern static int  dx_GetEnableLightHandle_x86( int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetEnableLightHandle")]
		extern static int  dx_GetEnableLightHandle_x64( int  Index);
		public static int  GetEnableLightHandle( int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetEnableLightHandle_x86( Index );
			}
			else
			{
				return dx_GetEnableLightHandle_x64( Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetTexFormatIndex")]
		extern static int  dx_GetTexFormatIndex_x86( out IMAGEFORMATDESC  Format);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetTexFormatIndex")]
		extern static int  dx_GetTexFormatIndex_x64( out IMAGEFORMATDESC  Format);
		public static int  GetTexFormatIndex( out IMAGEFORMATDESC  Format)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetTexFormatIndex_x86( out Format );
			}
			else
			{
				return dx_GetTexFormatIndex_x64( out Format );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_ColorKaiseki")]
		extern unsafe static int  dx_ColorKaiseki_x86( void *  PixelData, COLORDATA *  ColorData);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ColorKaiseki")]
		extern unsafe static int  dx_ColorKaiseki_x64( void *  PixelData, COLORDATA *  ColorData);
		public unsafe static int  ColorKaiseki( void *  PixelData, COLORDATA *  ColorData)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ColorKaiseki_x86( PixelData , ColorData );
			}
			else
			{
				return dx_ColorKaiseki_x64( PixelData , ColorData );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_CreateMaskScreen")]
		extern static int  dx_CreateMaskScreen_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateMaskScreen")]
		extern static int  dx_CreateMaskScreen_x64( );
		public static int  CreateMaskScreen( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateMaskScreen_x86( );
			}
			else
			{
				return dx_CreateMaskScreen_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMaskScreen")]
		extern static int  dx_DeleteMaskScreen_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteMaskScreen")]
		extern static int  dx_DeleteMaskScreen_x64( );
		public static int  DeleteMaskScreen( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteMaskScreen_x86( );
			}
			else
			{
				return dx_DeleteMaskScreen_x64( );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DrawMaskToDirectData")]
		extern unsafe static int  dx_DrawMaskToDirectData_x86( int  x, int  y, int  Width, int  Height, void *  MaskData, int  TransMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawMaskToDirectData")]
		extern unsafe static int  dx_DrawMaskToDirectData_x64( int  x, int  y, int  Width, int  Height, void *  MaskData, int  TransMode);
		public unsafe static int  DrawMaskToDirectData( int  x, int  y, int  Width, int  Height, void *  MaskData, int  TransMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawMaskToDirectData_x86( x , y , Width , Height , MaskData , TransMode );
			}
			else
			{
				return dx_DrawMaskToDirectData_x64( x , y , Width , Height , MaskData , TransMode );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_DrawFillMaskToDirectData")]
		extern unsafe static int  dx_DrawFillMaskToDirectData_x86( int  x1, int  y1, int  x2, int  y2, int  Width, int  Height, void *  MaskData);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawFillMaskToDirectData")]
		extern unsafe static int  dx_DrawFillMaskToDirectData_x64( int  x1, int  y1, int  x2, int  y2, int  Width, int  Height, void *  MaskData);
		public unsafe static int  DrawFillMaskToDirectData( int  x1, int  y1, int  x2, int  y2, int  Width, int  Height, void *  MaskData)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawFillMaskToDirectData_x86( x1 , y1 , x2 , y2 , Width , Height , MaskData );
			}
			else
			{
				return dx_DrawFillMaskToDirectData_x64( x1 , y1 , x2 , y2 , Width , Height , MaskData );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseMaskScreenFlag")]
		extern static int  dx_SetUseMaskScreenFlag_x86( int  ValidFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseMaskScreenFlag")]
		extern static int  dx_SetUseMaskScreenFlag_x64( int  ValidFlag);
		public static int  SetUseMaskScreenFlag( int  ValidFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseMaskScreenFlag_x86( ValidFlag );
			}
			else
			{
				return dx_SetUseMaskScreenFlag_x64( ValidFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetUseMaskScreenFlag")]
		extern static int  dx_GetUseMaskScreenFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetUseMaskScreenFlag")]
		extern static int  dx_GetUseMaskScreenFlag_x64( );
		public static int  GetUseMaskScreenFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetUseMaskScreenFlag_x86( );
			}
			else
			{
				return dx_GetUseMaskScreenFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FillMaskScreen")]
		extern static int  dx_FillMaskScreen_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FillMaskScreen")]
		extern static int  dx_FillMaskScreen_x64( int  Flag);
		public static int  FillMaskScreen( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FillMaskScreen_x86( Flag );
			}
			else
			{
				return dx_FillMaskScreen_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitMask")]
		extern static int  dx_InitMask_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitMask")]
		extern static int  dx_InitMask_x64( );
		public static int  InitMask( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitMask_x86( );
			}
			else
			{
				return dx_InitMask_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeMask")]
		extern static int  dx_MakeMask_x86( int  Width, int  Height);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeMask")]
		extern static int  dx_MakeMask_x64( int  Width, int  Height);
		public static int  MakeMask( int  Width, int  Height)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeMask_x86( Width , Height );
			}
			else
			{
				return dx_MakeMask_x64( Width , Height );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMaskSize")]
		extern static int  dx_GetMaskSize_x86( out int  WidthBuf, out int  HeightBuf, int  MaskHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMaskSize")]
		extern static int  dx_GetMaskSize_x64( out int  WidthBuf, out int  HeightBuf, int  MaskHandle);
		public static int  GetMaskSize( out int  WidthBuf, out int  HeightBuf, int  MaskHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMaskSize_x86( out WidthBuf , out HeightBuf , MaskHandle );
			}
			else
			{
				return dx_GetMaskSize_x64( out WidthBuf , out HeightBuf , MaskHandle );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_SetDataToMask")]
		extern unsafe static int  dx_SetDataToMask_x86( int  Width, int  Height, void *  MaskData, int  MaskHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDataToMask")]
		extern unsafe static int  dx_SetDataToMask_x64( int  Width, int  Height, void *  MaskData, int  MaskHandle);
		public unsafe static int  SetDataToMask( int  Width, int  Height, void *  MaskData, int  MaskHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDataToMask_x86( Width , Height , MaskData , MaskHandle );
			}
			else
			{
				return dx_SetDataToMask_x64( Width , Height , MaskData , MaskHandle );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMask")]
		extern static int  dx_DeleteMask_x86( int  MaskHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteMask")]
		extern static int  dx_DeleteMask_x64( int  MaskHandle);
		public static int  DeleteMask( int  MaskHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteMask_x86( MaskHandle );
			}
			else
			{
				return dx_DeleteMask_x64( MaskHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadMask")]
		extern static int  dx_LoadMask_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadMask")]
		extern static int  dx_LoadMask_x64( string  FileName);
		public static int  LoadMask( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadMask_x86( FileName );
			}
			else
			{
				return dx_LoadMask_x64( FileName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadDivMask")]
		extern static int  dx_LoadDivMask_x86( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadDivMask")]
		extern static int  dx_LoadDivMask_x64( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf);
		public static int  LoadDivMask( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, out int  HandleBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadDivMask_x86( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
			}
			else
			{
				return dx_LoadDivMask_x64( FileName , AllNum , XNum , YNum , XSize , YSize , out HandleBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawMask")]
		extern static int  dx_DrawMask_x86( int  x, int  y, int  MaskHandle, int  TransMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawMask")]
		extern static int  dx_DrawMask_x64( int  x, int  y, int  MaskHandle, int  TransMode);
		public static int  DrawMask( int  x, int  y, int  MaskHandle, int  TransMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawMask_x86( x , y , MaskHandle , TransMode );
			}
			else
			{
				return dx_DrawMask_x64( x , y , MaskHandle , TransMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringMask")]
		extern static int  dx_DrawStringMask_x86( int  x, int  y, int  Flag, string  String);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawStringMask")]
		extern static int  dx_DrawStringMask_x64( int  x, int  y, int  Flag, string  String);
		public static int  DrawStringMask( int  x, int  y, int  Flag, string  String)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawStringMask_x86( x , y , Flag , String );
			}
			else
			{
				return dx_DrawStringMask_x64( x , y , Flag , String );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringMaskToHandle")]
		extern static int  dx_DrawStringMaskToHandle_x86( int  x, int  y, int  Flag, int  FontHandle, string  String);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawStringMaskToHandle")]
		extern static int  dx_DrawStringMaskToHandle_x64( int  x, int  y, int  Flag, int  FontHandle, string  String);
		public static int  DrawStringMaskToHandle( int  x, int  y, int  Flag, int  FontHandle, string  String)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawStringMaskToHandle_x86( x , y , Flag , FontHandle , String );
			}
			else
			{
				return dx_DrawStringMaskToHandle_x64( x , y , Flag , FontHandle , String );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawFillMask")]
		extern static int  dx_DrawFillMask_x86( int  x1, int  y1, int  x2, int  y2, int  MaskHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawFillMask")]
		extern static int  dx_DrawFillMask_x64( int  x1, int  y1, int  x2, int  y2, int  MaskHandle);
		public static int  DrawFillMask( int  x1, int  y1, int  x2, int  y2, int  MaskHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawFillMask_x86( x1 , y1 , x2 , y2 , MaskHandle );
			}
			else
			{
				return dx_DrawFillMask_x64( x1 , y1 , x2 , y2 , MaskHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetMaskReverseEffectFlag")]
		extern static int  dx_SetMaskReverseEffectFlag_x86( int  ReverseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetMaskReverseEffectFlag")]
		extern static int  dx_SetMaskReverseEffectFlag_x64( int  ReverseFlag);
		public static int  SetMaskReverseEffectFlag( int  ReverseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetMaskReverseEffectFlag_x86( ReverseFlag );
			}
			else
			{
				return dx_SetMaskReverseEffectFlag_x64( ReverseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMaskScreenData")]
		extern static int  dx_GetMaskScreenData_x86( int  x1, int  y1, int  x2, int  y2, int  MaskHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMaskScreenData")]
		extern static int  dx_GetMaskScreenData_x64( int  x1, int  y1, int  x2, int  y2, int  MaskHandle);
		public static int  GetMaskScreenData( int  x1, int  y1, int  x2, int  y2, int  MaskHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMaskScreenData_x86( x1 , y1 , x2 , y2 , MaskHandle );
			}
			else
			{
				return dx_GetMaskScreenData_x64( x1 , y1 , x2 , y2 , MaskHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMaskUseFlag")]
		extern static int  dx_GetMaskUseFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMaskUseFlag")]
		extern static int  dx_GetMaskUseFlag_x64( );
		public static int  GetMaskUseFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMaskUseFlag_x86( );
			}
			else
			{
				return dx_GetMaskUseFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_EnumFontName")]
		extern static int  dx_EnumFontName_x86( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  JapanOnlyFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_EnumFontName")]
		extern static int  dx_EnumFontName_x64( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  JapanOnlyFlag);
		public static int  EnumFontName( System.Text.StringBuilder  NameBuffer, int  NameBufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_EnumFontName_x86( NameBuffer , NameBufferNum , TRUE );
			}
			else
			{
				return dx_EnumFontName_x64( NameBuffer , NameBufferNum , TRUE );
			}
		}
		public static int  EnumFontName( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  JapanOnlyFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_EnumFontName_x86( NameBuffer , NameBufferNum , JapanOnlyFlag );
			}
			else
			{
				return dx_EnumFontName_x64( NameBuffer , NameBufferNum , JapanOnlyFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_EnumFontNameEx")]
		extern static int  dx_EnumFontNameEx_x86( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  CharSet);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_EnumFontNameEx")]
		extern static int  dx_EnumFontNameEx_x64( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  CharSet);
		public static int  EnumFontNameEx( System.Text.StringBuilder  NameBuffer, int  NameBufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_EnumFontNameEx_x86( NameBuffer , NameBufferNum , -1 );
			}
			else
			{
				return dx_EnumFontNameEx_x64( NameBuffer , NameBufferNum , -1 );
			}
		}
		public static int  EnumFontNameEx( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  CharSet)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_EnumFontNameEx_x86( NameBuffer , NameBufferNum , CharSet );
			}
			else
			{
				return dx_EnumFontNameEx_x64( NameBuffer , NameBufferNum , CharSet );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_EnumFontNameEx2")]
		extern static int  dx_EnumFontNameEx2_x86( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, System.Text.StringBuilder  EnumFontName, int  CharSet);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_EnumFontNameEx2")]
		extern static int  dx_EnumFontNameEx2_x64( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, System.Text.StringBuilder  EnumFontName, int  CharSet);
		public static int  EnumFontNameEx2( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, System.Text.StringBuilder  EnumFontName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_EnumFontNameEx2_x86( NameBuffer , NameBufferNum , EnumFontName , -1 );
			}
			else
			{
				return dx_EnumFontNameEx2_x64( NameBuffer , NameBufferNum , EnumFontName , -1 );
			}
		}
		public static int  EnumFontNameEx2( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, System.Text.StringBuilder  EnumFontName, int  CharSet)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_EnumFontNameEx2_x86( NameBuffer , NameBufferNum , EnumFontName , CharSet );
			}
			else
			{
				return dx_EnumFontNameEx2_x64( NameBuffer , NameBufferNum , EnumFontName , CharSet );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitFontToHandle")]
		extern static int  dx_InitFontToHandle_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitFontToHandle")]
		extern static int  dx_InitFontToHandle_x64( );
		public static int  InitFontToHandle( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitFontToHandle_x86( );
			}
			else
			{
				return dx_InitFontToHandle_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateFontToHandle")]
		extern static int  dx_CreateFontToHandle_x86( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  Handle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateFontToHandle")]
		extern static int  dx_CreateFontToHandle_x64( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  Handle);
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateFontToHandle_x86( FontName , Size , Thick , -1 , -1 , -1 , FALSE , -1 );
			}
			else
			{
				return dx_CreateFontToHandle_x64( FontName , Size , Thick , -1 , -1 , -1 , FALSE , -1 );
			}
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateFontToHandle_x86( FontName , Size , Thick , FontType , -1 , -1 , FALSE , -1 );
			}
			else
			{
				return dx_CreateFontToHandle_x64( FontName , Size , Thick , FontType , -1 , -1 , FALSE , -1 );
			}
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateFontToHandle_x86( FontName , Size , Thick , FontType , CharSet , -1 , FALSE , -1 );
			}
			else
			{
				return dx_CreateFontToHandle_x64( FontName , Size , Thick , FontType , CharSet , -1 , FALSE , -1 );
			}
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateFontToHandle_x86( FontName , Size , Thick , FontType , CharSet , EdgeSize , FALSE , -1 );
			}
			else
			{
				return dx_CreateFontToHandle_x64( FontName , Size , Thick , FontType , CharSet , EdgeSize , FALSE , -1 );
			}
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateFontToHandle_x86( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic , -1 );
			}
			else
			{
				return dx_CreateFontToHandle_x64( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic , -1 );
			}
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  Handle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateFontToHandle_x86( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic , Handle );
			}
			else
			{
				return dx_CreateFontToHandle_x64( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic , Handle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontSpaceToHandle")]
		extern static int  dx_SetFontSpaceToHandle_x86( int  Point, int  FontHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFontSpaceToHandle")]
		extern static int  dx_SetFontSpaceToHandle_x64( int  Point, int  FontHandle);
		public static int  SetFontSpaceToHandle( int  Point, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFontSpaceToHandle_x86( Point , FontHandle );
			}
			else
			{
				return dx_SetFontSpaceToHandle_x64( Point , FontHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteFontToHandle")]
		extern static int  dx_DeleteFontToHandle_x86( int  FontHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteFontToHandle")]
		extern static int  dx_DeleteFontToHandle_x64( int  FontHandle);
		public static int  DeleteFontToHandle( int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteFontToHandle_x86( FontHandle );
			}
			else
			{
				return dx_DeleteFontToHandle_x64( FontHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontLostFlag")]
		extern static int  dx_SetFontLostFlag_x86( int  FontHandle, out int  LostFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFontLostFlag")]
		extern static int  dx_SetFontLostFlag_x64( int  FontHandle, out int  LostFlag);
		public static int  SetFontLostFlag( int  FontHandle, out int  LostFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFontLostFlag_x86( FontHandle , out LostFlag );
			}
			else
			{
				return dx_SetFontLostFlag_x64( FontHandle , out LostFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeFont")]
		extern static int  dx_ChangeFont_x86( string  FontName, int  CharSet);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ChangeFont")]
		extern static int  dx_ChangeFont_x64( string  FontName, int  CharSet);
		public static int  ChangeFont( string  FontName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeFont_x86( FontName , -1 );
			}
			else
			{
				return dx_ChangeFont_x64( FontName , -1 );
			}
		}
		public static int  ChangeFont( string  FontName, int  CharSet)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeFont_x86( FontName , CharSet );
			}
			else
			{
				return dx_ChangeFont_x64( FontName , CharSet );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeFontType")]
		extern static int  dx_ChangeFontType_x86( int  FontType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ChangeFontType")]
		extern static int  dx_ChangeFontType_x64( int  FontType);
		public static int  ChangeFontType( int  FontType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeFontType_x86( FontType );
			}
			else
			{
				return dx_ChangeFontType_x64( FontType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontSize")]
		extern static int  dx_SetFontSize_x86( int  FontSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFontSize")]
		extern static int  dx_SetFontSize_x64( int  FontSize);
		public static int  SetFontSize( int  FontSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFontSize_x86( FontSize );
			}
			else
			{
				return dx_SetFontSize_x64( FontSize );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontSize")]
		extern static int  dx_GetFontSize_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontSize")]
		extern static int  dx_GetFontSize_x64( );
		public static int  GetFontSize( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontSize_x86( );
			}
			else
			{
				return dx_GetFontSize_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontThickness")]
		extern static int  dx_SetFontThickness_x86( int  ThickPal);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFontThickness")]
		extern static int  dx_SetFontThickness_x64( int  ThickPal);
		public static int  SetFontThickness( int  ThickPal)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFontThickness_x86( ThickPal );
			}
			else
			{
				return dx_SetFontThickness_x64( ThickPal );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontSpace")]
		extern static int  dx_SetFontSpace_x86( int  Point);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFontSpace")]
		extern static int  dx_SetFontSpace_x64( int  Point);
		public static int  SetFontSpace( int  Point)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFontSpace_x86( Point );
			}
			else
			{
				return dx_SetFontSpace_x64( Point );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDefaultFontState")]
		extern static int  dx_SetDefaultFontState_x86( string  FontName, int  Size, int  Thick);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDefaultFontState")]
		extern static int  dx_SetDefaultFontState_x64( string  FontName, int  Size, int  Thick);
		public static int  SetDefaultFontState( string  FontName, int  Size, int  Thick)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDefaultFontState_x86( FontName , Size , Thick );
			}
			else
			{
				return dx_SetDefaultFontState_x64( FontName , Size , Thick );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDefaultFontHandle")]
		extern static int  dx_GetDefaultFontHandle_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDefaultFontHandle")]
		extern static int  dx_GetDefaultFontHandle_x64( );
		public static int  GetDefaultFontHandle( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDefaultFontHandle_x86( );
			}
			else
			{
				return dx_GetDefaultFontHandle_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontMaxWidth")]
		extern static int  dx_GetFontMaxWidth_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontMaxWidth")]
		extern static int  dx_GetFontMaxWidth_x64( );
		public static int  GetFontMaxWidth( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontMaxWidth_x86( );
			}
			else
			{
				return dx_GetFontMaxWidth_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawStringWidth")]
		extern static int  dx_GetDrawStringWidth_x86( string  String, int  StrLen, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawStringWidth")]
		extern static int  dx_GetDrawStringWidth_x64( string  String, int  StrLen, int  VerticalFlag);
		public static int  GetDrawStringWidth( string  String, int  StrLen)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawStringWidth_x86( String , StrLen , FALSE );
			}
			else
			{
				return dx_GetDrawStringWidth_x64( String , StrLen , FALSE );
			}
		}
		public static int  GetDrawStringWidth( string  String, int  StrLen, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawStringWidth_x86( String , StrLen , VerticalFlag );
			}
			else
			{
				return dx_GetDrawStringWidth_x64( String , StrLen , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawExtendStringWidth")]
		extern static int  dx_GetDrawExtendStringWidth_x86( double  ExRateX, string  String, int  StrLen, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawExtendStringWidth")]
		extern static int  dx_GetDrawExtendStringWidth_x64( double  ExRateX, string  String, int  StrLen, int  VerticalFlag);
		public static int  GetDrawExtendStringWidth( double  ExRateX, string  String, int  StrLen)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawExtendStringWidth_x86( ExRateX , String , StrLen , FALSE );
			}
			else
			{
				return dx_GetDrawExtendStringWidth_x64( ExRateX , String , StrLen , FALSE );
			}
		}
		public static int  GetDrawExtendStringWidth( double  ExRateX, string  String, int  StrLen, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawExtendStringWidth_x86( ExRateX , String , StrLen , VerticalFlag );
			}
			else
			{
				return dx_GetDrawExtendStringWidth_x64( ExRateX , String , StrLen , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontMaxWidthToHandle")]
		extern static int  dx_GetFontMaxWidthToHandle_x86( int  FontHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontMaxWidthToHandle")]
		extern static int  dx_GetFontMaxWidthToHandle_x64( int  FontHandle);
		public static int  GetFontMaxWidthToHandle( int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontMaxWidthToHandle_x86( FontHandle );
			}
			else
			{
				return dx_GetFontMaxWidthToHandle_x64( FontHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontSizeToHandle")]
		extern static int  dx_GetFontSizeToHandle_x86( int  FontHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontSizeToHandle")]
		extern static int  dx_GetFontSizeToHandle_x64( int  FontHandle);
		public static int  GetFontSizeToHandle( int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontSizeToHandle_x86( FontHandle );
			}
			else
			{
				return dx_GetFontSizeToHandle_x64( FontHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontCharInfo")]
		extern static int  dx_GetFontCharInfo_x86( int  FontHandle, string  Char, out int  DrawX, out int  DrawY, out int  NextCharX, out int  SizeX, out int  SizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontCharInfo")]
		extern static int  dx_GetFontCharInfo_x64( int  FontHandle, string  Char, out int  DrawX, out int  DrawY, out int  NextCharX, out int  SizeX, out int  SizeY);
		public static int  GetFontCharInfo( int  FontHandle, string  Char, out int  DrawX, out int  DrawY, out int  NextCharX, out int  SizeX, out int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontCharInfo_x86( FontHandle , Char , out DrawX , out DrawY , out NextCharX , out SizeX , out SizeY );
			}
			else
			{
				return dx_GetFontCharInfo_x64( FontHandle , Char , out DrawX , out DrawY , out NextCharX , out SizeX , out SizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawStringWidthToHandle")]
		extern static int  dx_GetDrawStringWidthToHandle_x86( string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawStringWidthToHandle")]
		extern static int  dx_GetDrawStringWidthToHandle_x64( string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawStringWidthToHandle( string  String, int  StrLen, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawStringWidthToHandle_x86( String , StrLen , FontHandle , FALSE );
			}
			else
			{
				return dx_GetDrawStringWidthToHandle_x64( String , StrLen , FontHandle , FALSE );
			}
		}
		public static int  GetDrawStringWidthToHandle( string  String, int  StrLen, int  FontHandle, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawStringWidthToHandle_x86( String , StrLen , FontHandle , VerticalFlag );
			}
			else
			{
				return dx_GetDrawStringWidthToHandle_x64( String , StrLen , FontHandle , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawExtendStringWidthToHandle")]
		extern static int  dx_GetDrawExtendStringWidthToHandle_x86( double  ExRateX, string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawExtendStringWidthToHandle")]
		extern static int  dx_GetDrawExtendStringWidthToHandle_x64( double  ExRateX, string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawExtendStringWidthToHandle( double  ExRateX, string  String, int  StrLen, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawExtendStringWidthToHandle_x86( ExRateX , String , StrLen , FontHandle , FALSE );
			}
			else
			{
				return dx_GetDrawExtendStringWidthToHandle_x64( ExRateX , String , StrLen , FontHandle , FALSE );
			}
		}
		public static int  GetDrawExtendStringWidthToHandle( double  ExRateX, string  String, int  StrLen, int  FontHandle, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawExtendStringWidthToHandle_x86( ExRateX , String , StrLen , FontHandle , VerticalFlag );
			}
			else
			{
				return dx_GetDrawExtendStringWidthToHandle_x64( ExRateX , String , StrLen , FontHandle , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontStateToHandle")]
		extern static int  dx_GetFontStateToHandle_x86( System.Text.StringBuilder  FontName, out int  Size, out int  Thick, int  FontHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontStateToHandle")]
		extern static int  dx_GetFontStateToHandle_x64( System.Text.StringBuilder  FontName, out int  Size, out int  Thick, int  FontHandle);
		public static int  GetFontStateToHandle( System.Text.StringBuilder  FontName, out int  Size, out int  Thick, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontStateToHandle_x86( FontName , out Size , out Thick , FontHandle );
			}
			else
			{
				return dx_GetFontStateToHandle_x64( FontName , out Size , out Thick , FontHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckFontCacheToTextureFlag")]
		extern static int  dx_CheckFontCacheToTextureFlag_x86( int  FontHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckFontCacheToTextureFlag")]
		extern static int  dx_CheckFontCacheToTextureFlag_x64( int  FontHandle);
		public static int  CheckFontCacheToTextureFlag( int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckFontCacheToTextureFlag_x86( FontHandle );
			}
			else
			{
				return dx_CheckFontCacheToTextureFlag_x64( FontHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckFontChacheToTextureFlag")]
		extern static int  dx_CheckFontChacheToTextureFlag_x86( int  FontHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckFontChacheToTextureFlag")]
		extern static int  dx_CheckFontChacheToTextureFlag_x64( int  FontHandle);
		public static int  CheckFontChacheToTextureFlag( int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckFontChacheToTextureFlag_x86( FontHandle );
			}
			else
			{
				return dx_CheckFontChacheToTextureFlag_x64( FontHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckFontHandleValid")]
		extern static int  dx_CheckFontHandleValid_x86( int  FontHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckFontHandleValid")]
		extern static int  dx_CheckFontHandleValid_x64( int  FontHandle);
		public static int  CheckFontHandleValid( int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckFontHandleValid_x86( FontHandle );
			}
			else
			{
				return dx_CheckFontHandleValid_x64( FontHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontCacheToTextureFlag")]
		extern static int  dx_SetFontCacheToTextureFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFontCacheToTextureFlag")]
		extern static int  dx_SetFontCacheToTextureFlag_x64( int  Flag);
		public static int  SetFontCacheToTextureFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFontCacheToTextureFlag_x86( Flag );
			}
			else
			{
				return dx_SetFontCacheToTextureFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontCacheToTextureFlag")]
		extern static int  dx_GetFontCacheToTextureFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontCacheToTextureFlag")]
		extern static int  dx_GetFontCacheToTextureFlag_x64( );
		public static int  GetFontCacheToTextureFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontCacheToTextureFlag_x86( );
			}
			else
			{
				return dx_GetFontCacheToTextureFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontChacheToTextureFlag")]
		extern static int  dx_SetFontChacheToTextureFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFontChacheToTextureFlag")]
		extern static int  dx_SetFontChacheToTextureFlag_x64( int  Flag);
		public static int  SetFontChacheToTextureFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFontChacheToTextureFlag_x86( Flag );
			}
			else
			{
				return dx_SetFontChacheToTextureFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontChacheToTextureFlag")]
		extern static int  dx_GetFontChacheToTextureFlag_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontChacheToTextureFlag")]
		extern static int  dx_GetFontChacheToTextureFlag_x64( );
		public static int  GetFontChacheToTextureFlag( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontChacheToTextureFlag_x86( );
			}
			else
			{
				return dx_GetFontChacheToTextureFlag_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontCacheTextureColorBitDepth")]
		extern static int  dx_SetFontCacheTextureColorBitDepth_x86( int  ColorBitDepth);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFontCacheTextureColorBitDepth")]
		extern static int  dx_SetFontCacheTextureColorBitDepth_x64( int  ColorBitDepth);
		public static int  SetFontCacheTextureColorBitDepth( int  ColorBitDepth)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFontCacheTextureColorBitDepth_x86( ColorBitDepth );
			}
			else
			{
				return dx_SetFontCacheTextureColorBitDepth_x64( ColorBitDepth );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontCacheTextureColorBitDepth")]
		extern static int  dx_GetFontCacheTextureColorBitDepth_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontCacheTextureColorBitDepth")]
		extern static int  dx_GetFontCacheTextureColorBitDepth_x64( );
		public static int  GetFontCacheTextureColorBitDepth( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontCacheTextureColorBitDepth_x86( );
			}
			else
			{
				return dx_GetFontCacheTextureColorBitDepth_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFontCacheCharNum")]
		extern static int  dx_SetFontCacheCharNum_x86( int  CharNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFontCacheCharNum")]
		extern static int  dx_SetFontCacheCharNum_x64( int  CharNum);
		public static int  SetFontCacheCharNum( int  CharNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFontCacheCharNum_x86( CharNum );
			}
			else
			{
				return dx_SetFontCacheCharNum_x64( CharNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFontCacheCharNum")]
		extern static int  dx_GetFontCacheCharNum_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFontCacheCharNum")]
		extern static int  dx_GetFontCacheCharNum_x64( );
		public static int  GetFontCacheCharNum( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFontCacheCharNum_x86( );
			}
			else
			{
				return dx_GetFontCacheCharNum_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MultiByteCharCheck")]
		extern static int  dx_MultiByteCharCheck_x86( string  Buf, int  CharSet);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MultiByteCharCheck")]
		extern static int  dx_MultiByteCharCheck_x64( string  Buf, int  CharSet);
		public static int  MultiByteCharCheck( string  Buf, int  CharSet)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MultiByteCharCheck_x86( Buf , CharSet );
			}
			else
			{
				return dx_MultiByteCharCheck_x64( Buf , CharSet );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawString")]
		extern static int  dx_DrawString_x86( int  x, int  y, string  String, int  Color, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawString")]
		extern static int  dx_DrawString_x64( int  x, int  y, string  String, int  Color, int  EdgeColor);
		public static int  DrawString( int  x, int  y, string  String, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawString_x86( x , y , String , Color , 0 );
			}
			else
			{
				return dx_DrawString_x64( x , y , String , Color , 0 );
			}
		}
		public static int  DrawString( int  x, int  y, string  String, int  Color, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawString_x86( x , y , String , Color , EdgeColor );
			}
			else
			{
				return dx_DrawString_x64( x , y , String , Color , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawVString")]
		extern static int  dx_DrawVString_x86( int  x, int  y, string  String, int  Color, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawVString")]
		extern static int  dx_DrawVString_x64( int  x, int  y, string  String, int  Color, int  EdgeColor);
		public static int  DrawVString( int  x, int  y, string  String, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawVString_x86( x , y , String , Color , 0 );
			}
			else
			{
				return dx_DrawVString_x64( x , y , String , Color , 0 );
			}
		}
		public static int  DrawVString( int  x, int  y, string  String, int  Color, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawVString_x86( x , y , String , Color , EdgeColor );
			}
			else
			{
				return dx_DrawVString_x64( x , y , String , Color , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendString")]
		extern static int  dx_DrawExtendString_x86( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendString")]
		extern static int  dx_DrawExtendString_x64( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor);
		public static int  DrawExtendString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendString_x86( x , y , ExRateX , ExRateY , String , Color , 0 );
			}
			else
			{
				return dx_DrawExtendString_x64( x , y , ExRateX , ExRateY , String , Color , 0 );
			}
		}
		public static int  DrawExtendString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendString_x86( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
			}
			else
			{
				return dx_DrawExtendString_x64( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendVString")]
		extern static int  dx_DrawExtendVString_x86( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendVString")]
		extern static int  dx_DrawExtendVString_x64( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor);
		public static int  DrawExtendVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendVString_x86( x , y , ExRateX , ExRateY , String , Color , 0 );
			}
			else
			{
				return dx_DrawExtendVString_x64( x , y , ExRateX , ExRateY , String , Color , 0 );
			}
		}
		public static int  DrawExtendVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendVString_x86( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
			}
			else
			{
				return dx_DrawExtendVString_x64( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberToI")]
		extern static int  dx_DrawNumberToI_x86( int  x, int  y, int  Num, int  RisesNum, int  Color, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawNumberToI")]
		extern static int  dx_DrawNumberToI_x64( int  x, int  y, int  Num, int  RisesNum, int  Color, int  EdgeColor);
		public static int  DrawNumberToI( int  x, int  y, int  Num, int  RisesNum, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberToI_x86( x , y , Num , RisesNum , Color , 0 );
			}
			else
			{
				return dx_DrawNumberToI_x64( x , y , Num , RisesNum , Color , 0 );
			}
		}
		public static int  DrawNumberToI( int  x, int  y, int  Num, int  RisesNum, int  Color, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberToI_x86( x , y , Num , RisesNum , Color , EdgeColor );
			}
			else
			{
				return dx_DrawNumberToI_x64( x , y , Num , RisesNum , Color , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberToF")]
		extern static int  dx_DrawNumberToF_x86( int  x, int  y, double  Num, int  Length, int  Color, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawNumberToF")]
		extern static int  dx_DrawNumberToF_x64( int  x, int  y, double  Num, int  Length, int  Color, int  EdgeColor);
		public static int  DrawNumberToF( int  x, int  y, double  Num, int  Length, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberToF_x86( x , y , Num , Length , Color , 0 );
			}
			else
			{
				return dx_DrawNumberToF_x64( x , y , Num , Length , Color , 0 );
			}
		}
		public static int  DrawNumberToF( int  x, int  y, double  Num, int  Length, int  Color, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberToF_x86( x , y , Num , Length , Color , EdgeColor );
			}
			else
			{
				return dx_DrawNumberToF_x64( x , y , Num , Length , Color , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberPlusToI")]
		extern static int  dx_DrawNumberPlusToI_x86( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawNumberPlusToI")]
		extern static int  dx_DrawNumberPlusToI_x64( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  EdgeColor);
		public static int  DrawNumberPlusToI( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberPlusToI_x86( x , y , NoteString , Num , RisesNum , Color , 0 );
			}
			else
			{
				return dx_DrawNumberPlusToI_x64( x , y , NoteString , Num , RisesNum , Color , 0 );
			}
		}
		public static int  DrawNumberPlusToI( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberPlusToI_x86( x , y , NoteString , Num , RisesNum , Color , EdgeColor );
			}
			else
			{
				return dx_DrawNumberPlusToI_x64( x , y , NoteString , Num , RisesNum , Color , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberPlusToF")]
		extern static int  dx_DrawNumberPlusToF_x86( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawNumberPlusToF")]
		extern static int  dx_DrawNumberPlusToF_x64( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  EdgeColor);
		public static int  DrawNumberPlusToF( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberPlusToF_x86( x , y , NoteString , Num , Length , Color , 0 );
			}
			else
			{
				return dx_DrawNumberPlusToF_x64( x , y , NoteString , Num , Length , Color , 0 );
			}
		}
		public static int  DrawNumberPlusToF( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberPlusToF_x86( x , y , NoteString , Num , Length , Color , EdgeColor );
			}
			else
			{
				return dx_DrawNumberPlusToF_x64( x , y , NoteString , Num , Length , Color , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringToZBuffer")]
		extern static int  dx_DrawStringToZBuffer_x86( int  x, int  y, string  String, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawStringToZBuffer")]
		extern static int  dx_DrawStringToZBuffer_x64( int  x, int  y, string  String, int  WriteZMode);
		public static int  DrawStringToZBuffer( int  x, int  y, string  String, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawStringToZBuffer_x86( x , y , String , WriteZMode );
			}
			else
			{
				return dx_DrawStringToZBuffer_x64( x , y , String , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawVStringToZBuffer")]
		extern static int  dx_DrawVStringToZBuffer_x86( int  x, int  y, string  String, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawVStringToZBuffer")]
		extern static int  dx_DrawVStringToZBuffer_x64( int  x, int  y, string  String, int  WriteZMode);
		public static int  DrawVStringToZBuffer( int  x, int  y, string  String, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawVStringToZBuffer_x86( x , y , String , WriteZMode );
			}
			else
			{
				return dx_DrawVStringToZBuffer_x64( x , y , String , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendStringToZBuffer")]
		extern static int  dx_DrawExtendStringToZBuffer_x86( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendStringToZBuffer")]
		extern static int  dx_DrawExtendStringToZBuffer_x64( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode);
		public static int  DrawExtendStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendStringToZBuffer_x86( x , y , ExRateX , ExRateY , String , WriteZMode );
			}
			else
			{
				return dx_DrawExtendStringToZBuffer_x64( x , y , ExRateX , ExRateY , String , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendVStringToZBuffer")]
		extern static int  dx_DrawExtendVStringToZBuffer_x86( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendVStringToZBuffer")]
		extern static int  dx_DrawExtendVStringToZBuffer_x64( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode);
		public static int  DrawExtendVStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendVStringToZBuffer_x86( x , y , ExRateX , ExRateY , String , WriteZMode );
			}
			else
			{
				return dx_DrawExtendVStringToZBuffer_x64( x , y , ExRateX , ExRateY , String , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringToHandle")]
		extern static int  dx_DrawStringToHandle_x86( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawStringToHandle")]
		extern static int  dx_DrawStringToHandle_x64( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag);
		public static int  DrawStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawStringToHandle_x86( x , y , String , Color , FontHandle , 0 , FALSE );
			}
			else
			{
				return dx_DrawStringToHandle_x64( x , y , String , Color , FontHandle , 0 , FALSE );
			}
		}
		public static int  DrawStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawStringToHandle_x86( x , y , String , Color , FontHandle , EdgeColor , FALSE );
			}
			else
			{
				return dx_DrawStringToHandle_x64( x , y , String , Color , FontHandle , EdgeColor , FALSE );
			}
		}
		public static int  DrawStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawStringToHandle_x86( x , y , String , Color , FontHandle , EdgeColor , VerticalFlag );
			}
			else
			{
				return dx_DrawStringToHandle_x64( x , y , String , Color , FontHandle , EdgeColor , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawVStringToHandle")]
		extern static int  dx_DrawVStringToHandle_x86( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawVStringToHandle")]
		extern static int  dx_DrawVStringToHandle_x64( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawVStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawVStringToHandle_x86( x , y , String , Color , FontHandle , 0 );
			}
			else
			{
				return dx_DrawVStringToHandle_x64( x , y , String , Color , FontHandle , 0 );
			}
		}
		public static int  DrawVStringToHandle( int  x, int  y, string  String, int  Color, int  FontHandle, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawVStringToHandle_x86( x , y , String , Color , FontHandle , EdgeColor );
			}
			else
			{
				return dx_DrawVStringToHandle_x64( x , y , String , Color , FontHandle , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendStringToHandle")]
		extern static int  dx_DrawExtendStringToHandle_x86( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendStringToHandle")]
		extern static int  dx_DrawExtendStringToHandle_x64( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag);
		public static int  DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendStringToHandle_x86( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 , FALSE );
			}
			else
			{
				return dx_DrawExtendStringToHandle_x64( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 , FALSE );
			}
		}
		public static int  DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendStringToHandle_x86( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , FALSE );
			}
			else
			{
				return dx_DrawExtendStringToHandle_x64( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , FALSE );
			}
		}
		public static int  DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendStringToHandle_x86( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , VerticalFlag );
			}
			else
			{
				return dx_DrawExtendStringToHandle_x64( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendVStringToHandle")]
		extern static int  dx_DrawExtendVStringToHandle_x86( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendVStringToHandle")]
		extern static int  dx_DrawExtendVStringToHandle_x64( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawExtendVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendVStringToHandle_x86( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 );
			}
			else
			{
				return dx_DrawExtendVStringToHandle_x64( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 );
			}
		}
		public static int  DrawExtendVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  Color, int  FontHandle, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendVStringToHandle_x86( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor );
			}
			else
			{
				return dx_DrawExtendVStringToHandle_x64( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberToIToHandle")]
		extern static int  dx_DrawNumberToIToHandle_x86( int  x, int  y, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawNumberToIToHandle")]
		extern static int  dx_DrawNumberToIToHandle_x64( int  x, int  y, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawNumberToIToHandle( int  x, int  y, int  Num, int  RisesNum, int  Color, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberToIToHandle_x86( x , y , Num , RisesNum , Color , FontHandle , 0 );
			}
			else
			{
				return dx_DrawNumberToIToHandle_x64( x , y , Num , RisesNum , Color , FontHandle , 0 );
			}
		}
		public static int  DrawNumberToIToHandle( int  x, int  y, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberToIToHandle_x86( x , y , Num , RisesNum , Color , FontHandle , EdgeColor );
			}
			else
			{
				return dx_DrawNumberToIToHandle_x64( x , y , Num , RisesNum , Color , FontHandle , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberToFToHandle")]
		extern static int  dx_DrawNumberToFToHandle_x86( int  x, int  y, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawNumberToFToHandle")]
		extern static int  dx_DrawNumberToFToHandle_x64( int  x, int  y, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawNumberToFToHandle( int  x, int  y, double  Num, int  Length, int  Color, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberToFToHandle_x86( x , y , Num , Length , Color , FontHandle , 0 );
			}
			else
			{
				return dx_DrawNumberToFToHandle_x64( x , y , Num , Length , Color , FontHandle , 0 );
			}
		}
		public static int  DrawNumberToFToHandle( int  x, int  y, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberToFToHandle_x86( x , y , Num , Length , Color , FontHandle , EdgeColor );
			}
			else
			{
				return dx_DrawNumberToFToHandle_x64( x , y , Num , Length , Color , FontHandle , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberPlusToIToHandle")]
		extern static int  dx_DrawNumberPlusToIToHandle_x86( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawNumberPlusToIToHandle")]
		extern static int  dx_DrawNumberPlusToIToHandle_x64( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawNumberPlusToIToHandle( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberPlusToIToHandle_x86( x , y , NoteString , Num , RisesNum , Color , FontHandle , 0 );
			}
			else
			{
				return dx_DrawNumberPlusToIToHandle_x64( x , y , NoteString , Num , RisesNum , Color , FontHandle , 0 );
			}
		}
		public static int  DrawNumberPlusToIToHandle( int  x, int  y, string  NoteString, int  Num, int  RisesNum, int  Color, int  FontHandle, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberPlusToIToHandle_x86( x , y , NoteString , Num , RisesNum , Color , FontHandle , EdgeColor );
			}
			else
			{
				return dx_DrawNumberPlusToIToHandle_x64( x , y , NoteString , Num , RisesNum , Color , FontHandle , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawNumberPlusToFToHandle")]
		extern static int  dx_DrawNumberPlusToFToHandle_x86( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawNumberPlusToFToHandle")]
		extern static int  dx_DrawNumberPlusToFToHandle_x64( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor);
		public static int  DrawNumberPlusToFToHandle( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberPlusToFToHandle_x86( x , y , NoteString , Num , Length , Color , FontHandle , 0 );
			}
			else
			{
				return dx_DrawNumberPlusToFToHandle_x64( x , y , NoteString , Num , Length , Color , FontHandle , 0 );
			}
		}
		public static int  DrawNumberPlusToFToHandle( int  x, int  y, string  NoteString, double  Num, int  Length, int  Color, int  FontHandle, int  EdgeColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawNumberPlusToFToHandle_x86( x , y , NoteString , Num , Length , Color , FontHandle , EdgeColor );
			}
			else
			{
				return dx_DrawNumberPlusToFToHandle_x64( x , y , NoteString , Num , Length , Color , FontHandle , EdgeColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawStringToHandleToZBuffer")]
		extern static int  dx_DrawStringToHandleToZBuffer_x86( int  x, int  y, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawStringToHandleToZBuffer")]
		extern static int  dx_DrawStringToHandleToZBuffer_x64( int  x, int  y, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		public static int  DrawStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawStringToHandleToZBuffer_x86( x , y , String , FontHandle , WriteZMode , FALSE );
			}
			else
			{
				return dx_DrawStringToHandleToZBuffer_x64( x , y , String , FontHandle , WriteZMode , FALSE );
			}
		}
		public static int  DrawStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawStringToHandleToZBuffer_x86( x , y , String , FontHandle , WriteZMode , VerticalFlag );
			}
			else
			{
				return dx_DrawStringToHandleToZBuffer_x64( x , y , String , FontHandle , WriteZMode , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawVStringToHandleToZBuffer")]
		extern static int  dx_DrawVStringToHandleToZBuffer_x86( int  x, int  y, string  String, int  FontHandle, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawVStringToHandleToZBuffer")]
		extern static int  dx_DrawVStringToHandleToZBuffer_x64( int  x, int  y, string  String, int  FontHandle, int  WriteZMode);
		public static int  DrawVStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawVStringToHandleToZBuffer_x86( x , y , String , FontHandle , WriteZMode );
			}
			else
			{
				return dx_DrawVStringToHandleToZBuffer_x64( x , y , String , FontHandle , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendStringToHandleToZBuffer")]
		extern static int  dx_DrawExtendStringToHandleToZBuffer_x86( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendStringToHandleToZBuffer")]
		extern static int  dx_DrawExtendStringToHandleToZBuffer_x64( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		public static int  DrawExtendStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendStringToHandleToZBuffer_x86( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode , FALSE );
			}
			else
			{
				return dx_DrawExtendStringToHandleToZBuffer_x64( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode , FALSE );
			}
		}
		public static int  DrawExtendStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendStringToHandleToZBuffer_x86( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode , VerticalFlag );
			}
			else
			{
				return dx_DrawExtendStringToHandleToZBuffer_x64( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawExtendVStringToHandleToZBuffer")]
		extern static int  dx_DrawExtendVStringToHandleToZBuffer_x86( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawExtendVStringToHandleToZBuffer")]
		extern static int  dx_DrawExtendVStringToHandleToZBuffer_x64( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode);
		public static int  DrawExtendVStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawExtendVStringToHandleToZBuffer_x86( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode );
			}
			else
			{
				return dx_DrawExtendVStringToHandleToZBuffer_x64( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateIdentityMatrix")]
		extern static int  dx_CreateIdentityMatrix_x86( out MATRIX  Out);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateIdentityMatrix")]
		extern static int  dx_CreateIdentityMatrix_x64( out MATRIX  Out);
		public static int  CreateIdentityMatrix( out MATRIX  Out)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateIdentityMatrix_x86( out Out );
			}
			else
			{
				return dx_CreateIdentityMatrix_x64( out Out );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateLookAtMatrix")]
		extern static int  dx_CreateLookAtMatrix_x86( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateLookAtMatrix")]
		extern static int  dx_CreateLookAtMatrix_x64( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up);
		public static int  CreateLookAtMatrix( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateLookAtMatrix_x86( out Out , out Eye , out At , out Up );
			}
			else
			{
				return dx_CreateLookAtMatrix_x64( out Out , out Eye , out At , out Up );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateLookAtMatrix2")]
		extern static int  dx_CreateLookAtMatrix2_x86( out MATRIX  Out, out VECTOR  Eye, double  XZAngle, double  Oira);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateLookAtMatrix2")]
		extern static int  dx_CreateLookAtMatrix2_x64( out MATRIX  Out, out VECTOR  Eye, double  XZAngle, double  Oira);
		public static int  CreateLookAtMatrix2( out MATRIX  Out, out VECTOR  Eye, double  XZAngle, double  Oira)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateLookAtMatrix2_x86( out Out , out Eye , XZAngle , Oira );
			}
			else
			{
				return dx_CreateLookAtMatrix2_x64( out Out , out Eye , XZAngle , Oira );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateLookAtMatrixRH")]
		extern static int  dx_CreateLookAtMatrixRH_x86( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateLookAtMatrixRH")]
		extern static int  dx_CreateLookAtMatrixRH_x64( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up);
		public static int  CreateLookAtMatrixRH( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateLookAtMatrixRH_x86( out Out , out Eye , out At , out Up );
			}
			else
			{
				return dx_CreateLookAtMatrixRH_x64( out Out , out Eye , out At , out Up );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateMultiplyMatrix")]
		extern static int  dx_CreateMultiplyMatrix_x86( out MATRIX  Out, out MATRIX  In1, out MATRIX  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateMultiplyMatrix")]
		extern static int  dx_CreateMultiplyMatrix_x64( out MATRIX  Out, out MATRIX  In1, out MATRIX  In2);
		public static int  CreateMultiplyMatrix( out MATRIX  Out, out MATRIX  In1, out MATRIX  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateMultiplyMatrix_x86( out Out , out In1 , out In2 );
			}
			else
			{
				return dx_CreateMultiplyMatrix_x64( out Out , out In1 , out In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePerspectiveFovMatrix")]
		extern static int  dx_CreatePerspectiveFovMatrix_x86( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreatePerspectiveFovMatrix")]
		extern static int  dx_CreatePerspectiveFovMatrix_x64( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect);
		public static int  CreatePerspectiveFovMatrix( out MATRIX  Out, float  fov, float  zn, float  zf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreatePerspectiveFovMatrix_x86( out Out , fov , zn , zf , -1.0f );
			}
			else
			{
				return dx_CreatePerspectiveFovMatrix_x64( out Out , fov , zn , zf , -1.0f );
			}
		}
		public static int  CreatePerspectiveFovMatrix( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreatePerspectiveFovMatrix_x86( out Out , fov , zn , zf , aspect );
			}
			else
			{
				return dx_CreatePerspectiveFovMatrix_x64( out Out , fov , zn , zf , aspect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePerspectiveFovMatrixRH")]
		extern static int  dx_CreatePerspectiveFovMatrixRH_x86( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreatePerspectiveFovMatrixRH")]
		extern static int  dx_CreatePerspectiveFovMatrixRH_x64( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect);
		public static int  CreatePerspectiveFovMatrixRH( out MATRIX  Out, float  fov, float  zn, float  zf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreatePerspectiveFovMatrixRH_x86( out Out , fov , zn , zf , -1.0f );
			}
			else
			{
				return dx_CreatePerspectiveFovMatrixRH_x64( out Out , fov , zn , zf , -1.0f );
			}
		}
		public static int  CreatePerspectiveFovMatrixRH( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreatePerspectiveFovMatrixRH_x86( out Out , fov , zn , zf , aspect );
			}
			else
			{
				return dx_CreatePerspectiveFovMatrixRH_x64( out Out , fov , zn , zf , aspect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateOrthoMatrix")]
		extern static int  dx_CreateOrthoMatrix_x86( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateOrthoMatrix")]
		extern static int  dx_CreateOrthoMatrix_x64( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect);
		public static int  CreateOrthoMatrix( out MATRIX  Out, float  size, float  zn, float  zf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateOrthoMatrix_x86( out Out , size , zn , zf , -1.0f );
			}
			else
			{
				return dx_CreateOrthoMatrix_x64( out Out , size , zn , zf , -1.0f );
			}
		}
		public static int  CreateOrthoMatrix( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateOrthoMatrix_x86( out Out , size , zn , zf , aspect );
			}
			else
			{
				return dx_CreateOrthoMatrix_x64( out Out , size , zn , zf , aspect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateOrthoMatrixRH")]
		extern static int  dx_CreateOrthoMatrixRH_x86( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateOrthoMatrixRH")]
		extern static int  dx_CreateOrthoMatrixRH_x64( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect);
		public static int  CreateOrthoMatrixRH( out MATRIX  Out, float  size, float  zn, float  zf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateOrthoMatrixRH_x86( out Out , size , zn , zf , -1.0f );
			}
			else
			{
				return dx_CreateOrthoMatrixRH_x64( out Out , size , zn , zf , -1.0f );
			}
		}
		public static int  CreateOrthoMatrixRH( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateOrthoMatrixRH_x86( out Out , size , zn , zf , aspect );
			}
			else
			{
				return dx_CreateOrthoMatrixRH_x64( out Out , size , zn , zf , aspect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateScalingMatrix")]
		extern static int  dx_CreateScalingMatrix_x86( out MATRIX  Out, float  sx, float  sy, float  sz);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateScalingMatrix")]
		extern static int  dx_CreateScalingMatrix_x64( out MATRIX  Out, float  sx, float  sy, float  sz);
		public static int  CreateScalingMatrix( out MATRIX  Out, float  sx, float  sy, float  sz)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateScalingMatrix_x86( out Out , sx , sy , sz );
			}
			else
			{
				return dx_CreateScalingMatrix_x64( out Out , sx , sy , sz );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationXMatrix")]
		extern static int  dx_CreateRotationXMatrix_x86( out MATRIX  Out, float  Angle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateRotationXMatrix")]
		extern static int  dx_CreateRotationXMatrix_x64( out MATRIX  Out, float  Angle);
		public static int  CreateRotationXMatrix( out MATRIX  Out, float  Angle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateRotationXMatrix_x86( out Out , Angle );
			}
			else
			{
				return dx_CreateRotationXMatrix_x64( out Out , Angle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationYMatrix")]
		extern static int  dx_CreateRotationYMatrix_x86( out MATRIX  Out, float  Angle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateRotationYMatrix")]
		extern static int  dx_CreateRotationYMatrix_x64( out MATRIX  Out, float  Angle);
		public static int  CreateRotationYMatrix( out MATRIX  Out, float  Angle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateRotationYMatrix_x86( out Out , Angle );
			}
			else
			{
				return dx_CreateRotationYMatrix_x64( out Out , Angle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationZMatrix")]
		extern static int  dx_CreateRotationZMatrix_x86( out MATRIX  Out, float  Angle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateRotationZMatrix")]
		extern static int  dx_CreateRotationZMatrix_x64( out MATRIX  Out, float  Angle);
		public static int  CreateRotationZMatrix( out MATRIX  Out, float  Angle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateRotationZMatrix_x86( out Out , Angle );
			}
			else
			{
				return dx_CreateRotationZMatrix_x64( out Out , Angle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateTranslationMatrix")]
		extern static int  dx_CreateTranslationMatrix_x86( out MATRIX  Out, float  x, float  y, float  z);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateTranslationMatrix")]
		extern static int  dx_CreateTranslationMatrix_x64( out MATRIX  Out, float  x, float  y, float  z);
		public static int  CreateTranslationMatrix( out MATRIX  Out, float  x, float  y, float  z)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateTranslationMatrix_x86( out Out , x , y , z );
			}
			else
			{
				return dx_CreateTranslationMatrix_x64( out Out , x , y , z );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateTransposeMatrix")]
		extern static int  dx_CreateTransposeMatrix_x86( out MATRIX  Out, out MATRIX  In);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateTransposeMatrix")]
		extern static int  dx_CreateTransposeMatrix_x64( out MATRIX  Out, out MATRIX  In);
		public static int  CreateTransposeMatrix( out MATRIX  Out, out MATRIX  In)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateTransposeMatrix_x86( out Out , out In );
			}
			else
			{
				return dx_CreateTransposeMatrix_x64( out Out , out In );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateInverseMatrix")]
		extern static int  dx_CreateInverseMatrix_x86( out MATRIX  Out, out MATRIX  In);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateInverseMatrix")]
		extern static int  dx_CreateInverseMatrix_x64( out MATRIX  Out, out MATRIX  In);
		public static int  CreateInverseMatrix( out MATRIX  Out, out MATRIX  In)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateInverseMatrix_x86( out Out , out In );
			}
			else
			{
				return dx_CreateInverseMatrix_x64( out Out , out In );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateViewportMatrix")]
		extern static int  dx_CreateViewportMatrix_x86( out MATRIX  Out, float  CenterX, float  CenterY, float  Width, float  Height);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateViewportMatrix")]
		extern static int  dx_CreateViewportMatrix_x64( out MATRIX  Out, float  CenterX, float  CenterY, float  Width, float  Height);
		public static int  CreateViewportMatrix( out MATRIX  Out, float  CenterX, float  CenterY, float  Width, float  Height)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateViewportMatrix_x86( out Out , CenterX , CenterY , Width , Height );
			}
			else
			{
				return dx_CreateViewportMatrix_x64( out Out , CenterX , CenterY , Width , Height );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationXYZMatrix")]
		extern static int  dx_CreateRotationXYZMatrix_x86( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateRotationXYZMatrix")]
		extern static int  dx_CreateRotationXYZMatrix_x64( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationXYZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateRotationXYZMatrix_x86( out Out , XRot , YRot , ZRot );
			}
			else
			{
				return dx_CreateRotationXYZMatrix_x64( out Out , XRot , YRot , ZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationXZYMatrix")]
		extern static int  dx_CreateRotationXZYMatrix_x86( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateRotationXZYMatrix")]
		extern static int  dx_CreateRotationXZYMatrix_x64( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationXZYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateRotationXZYMatrix_x86( out Out , XRot , YRot , ZRot );
			}
			else
			{
				return dx_CreateRotationXZYMatrix_x64( out Out , XRot , YRot , ZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationYXZMatrix")]
		extern static int  dx_CreateRotationYXZMatrix_x86( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateRotationYXZMatrix")]
		extern static int  dx_CreateRotationYXZMatrix_x64( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationYXZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateRotationYXZMatrix_x86( out Out , XRot , YRot , ZRot );
			}
			else
			{
				return dx_CreateRotationYXZMatrix_x64( out Out , XRot , YRot , ZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationYZXMatrix")]
		extern static int  dx_CreateRotationYZXMatrix_x86( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateRotationYZXMatrix")]
		extern static int  dx_CreateRotationYZXMatrix_x64( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationYZXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateRotationYZXMatrix_x86( out Out , XRot , YRot , ZRot );
			}
			else
			{
				return dx_CreateRotationYZXMatrix_x64( out Out , XRot , YRot , ZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationZXYMatrix")]
		extern static int  dx_CreateRotationZXYMatrix_x86( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateRotationZXYMatrix")]
		extern static int  dx_CreateRotationZXYMatrix_x64( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationZXYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateRotationZXYMatrix_x86( out Out , XRot , YRot , ZRot );
			}
			else
			{
				return dx_CreateRotationZXYMatrix_x64( out Out , XRot , YRot , ZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateRotationZYXMatrix")]
		extern static int  dx_CreateRotationZYXMatrix_x86( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateRotationZYXMatrix")]
		extern static int  dx_CreateRotationZYXMatrix_x64( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationZYXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateRotationZYXMatrix_x86( out Out , XRot , YRot , ZRot );
			}
			else
			{
				return dx_CreateRotationZYXMatrix_x64( out Out , XRot , YRot , ZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixXYZRotation")]
		extern static int  dx_GetMatrixXYZRotation_x86( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMatrixXYZRotation")]
		extern static int  dx_GetMatrixXYZRotation_x64( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixXYZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMatrixXYZRotation_x86( out In , out OutXRot , out OutYRot , out OutZRot );
			}
			else
			{
				return dx_GetMatrixXYZRotation_x64( out In , out OutXRot , out OutYRot , out OutZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixXZYRotation")]
		extern static int  dx_GetMatrixXZYRotation_x86( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMatrixXZYRotation")]
		extern static int  dx_GetMatrixXZYRotation_x64( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixXZYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMatrixXZYRotation_x86( out In , out OutXRot , out OutYRot , out OutZRot );
			}
			else
			{
				return dx_GetMatrixXZYRotation_x64( out In , out OutXRot , out OutYRot , out OutZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixYXZRotation")]
		extern static int  dx_GetMatrixYXZRotation_x86( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMatrixYXZRotation")]
		extern static int  dx_GetMatrixYXZRotation_x64( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixYXZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMatrixYXZRotation_x86( out In , out OutXRot , out OutYRot , out OutZRot );
			}
			else
			{
				return dx_GetMatrixYXZRotation_x64( out In , out OutXRot , out OutYRot , out OutZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixYZXRotation")]
		extern static int  dx_GetMatrixYZXRotation_x86( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMatrixYZXRotation")]
		extern static int  dx_GetMatrixYZXRotation_x64( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixYZXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMatrixYZXRotation_x86( out In , out OutXRot , out OutYRot , out OutZRot );
			}
			else
			{
				return dx_GetMatrixYZXRotation_x64( out In , out OutXRot , out OutYRot , out OutZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixZXYRotation")]
		extern static int  dx_GetMatrixZXYRotation_x86( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMatrixZXYRotation")]
		extern static int  dx_GetMatrixZXYRotation_x64( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixZXYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMatrixZXYRotation_x86( out In , out OutXRot , out OutYRot , out OutZRot );
			}
			else
			{
				return dx_GetMatrixZXYRotation_x64( out In , out OutXRot , out OutYRot , out OutZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMatrixZYXRotation")]
		extern static int  dx_GetMatrixZYXRotation_x86( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMatrixZYXRotation")]
		extern static int  dx_GetMatrixZYXRotation_x64( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixZYXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMatrixZYXRotation_x86( out In , out OutXRot , out OutYRot , out OutZRot );
			}
			else
			{
				return dx_GetMatrixZYXRotation_x64( out In , out OutXRot , out OutYRot , out OutZRot );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorNormalize")]
		extern static int  dx_VectorNormalize_x86( out VECTOR  Out, out VECTOR  In);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorNormalize")]
		extern static int  dx_VectorNormalize_x64( out VECTOR  Out, out VECTOR  In);
		public static int  VectorNormalize( out VECTOR  Out, out VECTOR  In)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorNormalize_x86( out Out , out In );
			}
			else
			{
				return dx_VectorNormalize_x64( out Out , out In );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorScale")]
		extern static int  dx_VectorScale_x86( out VECTOR  Out, out VECTOR  In, float  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorScale")]
		extern static int  dx_VectorScale_x64( out VECTOR  Out, out VECTOR  In, float  Scale);
		public static int  VectorScale( out VECTOR  Out, out VECTOR  In, float  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorScale_x86( out Out , out In , Scale );
			}
			else
			{
				return dx_VectorScale_x64( out Out , out In , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorMultiply")]
		extern static int  dx_VectorMultiply_x86( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorMultiply")]
		extern static int  dx_VectorMultiply_x64( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorMultiply( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorMultiply_x86( out Out , out In1 , out In2 );
			}
			else
			{
				return dx_VectorMultiply_x64( out Out , out In1 , out In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorSub")]
		extern static int  dx_VectorSub_x86( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorSub")]
		extern static int  dx_VectorSub_x64( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorSub( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorSub_x86( out Out , out In1 , out In2 );
			}
			else
			{
				return dx_VectorSub_x64( out Out , out In1 , out In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorAdd")]
		extern static int  dx_VectorAdd_x86( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorAdd")]
		extern static int  dx_VectorAdd_x64( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorAdd( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorAdd_x86( out Out , out In1 , out In2 );
			}
			else
			{
				return dx_VectorAdd_x64( out Out , out In1 , out In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorOuterProduct")]
		extern static int  dx_VectorOuterProduct_x86( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorOuterProduct")]
		extern static int  dx_VectorOuterProduct_x64( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorOuterProduct( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorOuterProduct_x86( out Out , out In1 , out In2 );
			}
			else
			{
				return dx_VectorOuterProduct_x64( out Out , out In1 , out In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorInnerProduct")]
		extern static float  dx_VectorInnerProduct_x86( out VECTOR  In1, out VECTOR  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorInnerProduct")]
		extern static float  dx_VectorInnerProduct_x64( out VECTOR  In1, out VECTOR  In2);
		public static float  VectorInnerProduct( out VECTOR  In1, out VECTOR  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorInnerProduct_x86( out In1 , out In2 );
			}
			else
			{
				return dx_VectorInnerProduct_x64( out In1 , out In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorRotationX")]
		extern static int  dx_VectorRotationX_x86( out VECTOR  Out, out VECTOR  In, double  Angle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorRotationX")]
		extern static int  dx_VectorRotationX_x64( out VECTOR  Out, out VECTOR  In, double  Angle);
		public static int  VectorRotationX( out VECTOR  Out, out VECTOR  In, double  Angle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorRotationX_x86( out Out , out In , Angle );
			}
			else
			{
				return dx_VectorRotationX_x64( out Out , out In , Angle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorRotationY")]
		extern static int  dx_VectorRotationY_x86( out VECTOR  Out, out VECTOR  In, double  Angle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorRotationY")]
		extern static int  dx_VectorRotationY_x64( out VECTOR  Out, out VECTOR  In, double  Angle);
		public static int  VectorRotationY( out VECTOR  Out, out VECTOR  In, double  Angle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorRotationY_x86( out Out , out In , Angle );
			}
			else
			{
				return dx_VectorRotationY_x64( out Out , out In , Angle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorRotationZ")]
		extern static int  dx_VectorRotationZ_x86( out VECTOR  Out, out VECTOR  In, double  Angle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorRotationZ")]
		extern static int  dx_VectorRotationZ_x64( out VECTOR  Out, out VECTOR  In, double  Angle);
		public static int  VectorRotationZ( out VECTOR  Out, out VECTOR  In, double  Angle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorRotationZ_x86( out Out , out In , Angle );
			}
			else
			{
				return dx_VectorRotationZ_x64( out Out , out In , Angle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorTransform")]
		extern static int  dx_VectorTransform_x86( out VECTOR  Out, out VECTOR  InVec, out MATRIX  InMatrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorTransform")]
		extern static int  dx_VectorTransform_x64( out VECTOR  Out, out VECTOR  InVec, out MATRIX  InMatrix);
		public static int  VectorTransform( out VECTOR  Out, out VECTOR  InVec, out MATRIX  InMatrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorTransform_x86( out Out , out InVec , out InMatrix );
			}
			else
			{
				return dx_VectorTransform_x64( out Out , out InVec , out InMatrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VectorTransform4")]
		extern static int  dx_VectorTransform4_x86( out VECTOR  Out, out float  V4Out, out VECTOR  InVec, out float  V4In, out MATRIX  InMatrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VectorTransform4")]
		extern static int  dx_VectorTransform4_x64( out VECTOR  Out, out float  V4Out, out VECTOR  InVec, out float  V4In, out MATRIX  InMatrix);
		public static int  VectorTransform4( out VECTOR  Out, out float  V4Out, out VECTOR  InVec, out float  V4In, out MATRIX  InMatrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VectorTransform4_x86( out Out , out V4Out , out InVec , out V4In , out InMatrix );
			}
			else
			{
				return dx_VectorTransform4_x64( out Out , out V4Out , out InVec , out V4In , out InMatrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_TriangleBarycenter")]
		extern static void  dx_TriangleBarycenter_x86( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  Position, out float  u, out float  v, out float  w);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_TriangleBarycenter")]
		extern static void  dx_TriangleBarycenter_x64( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  Position, out float  u, out float  v, out float  w);
		public static void  TriangleBarycenter( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  Position, out float  u, out float  v, out float  w)
		{
			if( System.IntPtr.Size == 4 )
			{
				dx_TriangleBarycenter_x86( TrianglePos1 , TrianglePos2 , TrianglePos3 , Position , out u , out v , out w );
			}
			else
			{
				dx_TriangleBarycenter_x64( TrianglePos1 , TrianglePos2 , TrianglePos3 , Position , out u , out v , out w );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Segment_MinLength")]
		extern static float  dx_Segment_Segment_MinLength_x86( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Segment_Segment_MinLength")]
		extern static float  dx_Segment_Segment_MinLength_x64( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2);
		public static float  Segment_Segment_MinLength( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Segment_Segment_MinLength_x86( SegmentAPos1 , SegmentAPos2 , SegmentBPos1 , SegmentBPos2 );
			}
			else
			{
				return dx_Segment_Segment_MinLength_x64( SegmentAPos1 , SegmentAPos2 , SegmentBPos1 , SegmentBPos2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Segment_MinLength_Square")]
		extern static float  dx_Segment_Segment_MinLength_Square_x86( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Segment_Segment_MinLength_Square")]
		extern static float  dx_Segment_Segment_MinLength_Square_x64( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2);
		public static float  Segment_Segment_MinLength_Square( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Segment_Segment_MinLength_Square_x86( SegmentAPos1 , SegmentAPos2 , SegmentBPos1 , SegmentBPos2 );
			}
			else
			{
				return dx_Segment_Segment_MinLength_Square_x64( SegmentAPos1 , SegmentAPos2 , SegmentBPos1 , SegmentBPos2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Triangle_MinLength")]
		extern static float  dx_Segment_Triangle_MinLength_x86( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Segment_Triangle_MinLength")]
		extern static float  dx_Segment_Triangle_MinLength_x64( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static float  Segment_Triangle_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Segment_Triangle_MinLength_x86( SegmentPos1 , SegmentPos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
			else
			{
				return dx_Segment_Triangle_MinLength_x64( SegmentPos1 , SegmentPos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Triangle_MinLength_Square")]
		extern static float  dx_Segment_Triangle_MinLength_Square_x86( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Segment_Triangle_MinLength_Square")]
		extern static float  dx_Segment_Triangle_MinLength_Square_x64( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static float  Segment_Triangle_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Segment_Triangle_MinLength_Square_x86( SegmentPos1 , SegmentPos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
			else
			{
				return dx_Segment_Triangle_MinLength_Square_x64( SegmentPos1 , SegmentPos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Point_MinLength")]
		extern static float  dx_Segment_Point_MinLength_x86( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Segment_Point_MinLength")]
		extern static float  dx_Segment_Point_MinLength_x64( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos);
		public static float  Segment_Point_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Segment_Point_MinLength_x86( SegmentPos1 , SegmentPos2 , PointPos );
			}
			else
			{
				return dx_Segment_Point_MinLength_x64( SegmentPos1 , SegmentPos2 , PointPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Segment_Point_MinLength_Square")]
		extern static float  dx_Segment_Point_MinLength_Square_x86( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Segment_Point_MinLength_Square")]
		extern static float  dx_Segment_Point_MinLength_Square_x64( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos);
		public static float  Segment_Point_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Segment_Point_MinLength_Square_x86( SegmentPos1 , SegmentPos2 , PointPos );
			}
			else
			{
				return dx_Segment_Point_MinLength_Square_x64( SegmentPos1 , SegmentPos2 , PointPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Triangle_Point_MinLength")]
		extern static float  dx_Triangle_Point_MinLength_x86( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Triangle_Point_MinLength")]
		extern static float  dx_Triangle_Point_MinLength_x64( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos);
		public static float  Triangle_Point_MinLength( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Triangle_Point_MinLength_x86( TrianglePos1 , TrianglePos2 , TrianglePos3 , PointPos );
			}
			else
			{
				return dx_Triangle_Point_MinLength_x64( TrianglePos1 , TrianglePos2 , TrianglePos3 , PointPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Triangle_Point_MinLength_Square")]
		extern static float  dx_Triangle_Point_MinLength_Square_x86( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Triangle_Point_MinLength_Square")]
		extern static float  dx_Triangle_Point_MinLength_Square_x64( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos);
		public static float  Triangle_Point_MinLength_Square( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Triangle_Point_MinLength_Square_x86( TrianglePos1 , TrianglePos2 , TrianglePos3 , PointPos );
			}
			else
			{
				return dx_Triangle_Point_MinLength_Square_x64( TrianglePos1 , TrianglePos2 , TrianglePos3 , PointPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Plane_Point_MinLength_Position")]
		extern static VECTOR  dx_Plane_Point_MinLength_Position_x86( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Plane_Point_MinLength_Position")]
		extern static VECTOR  dx_Plane_Point_MinLength_Position_x64( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos);
		public static VECTOR  Plane_Point_MinLength_Position( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Plane_Point_MinLength_Position_x86( PlanePos , PlaneNormal , PointPos );
			}
			else
			{
				return dx_Plane_Point_MinLength_Position_x64( PlanePos , PlaneNormal , PointPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Plane_Point_MinLength")]
		extern static float  dx_Plane_Point_MinLength_x86( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Plane_Point_MinLength")]
		extern static float  dx_Plane_Point_MinLength_x64( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos);
		public static float  Plane_Point_MinLength( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Plane_Point_MinLength_x86( PlanePos , PlaneNormal , PointPos );
			}
			else
			{
				return dx_Plane_Point_MinLength_x64( PlanePos , PlaneNormal , PointPos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Line_Triangle")]
		extern static HITRESULT_LINE  dx_HitCheck_Line_Triangle_x86( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_HitCheck_Line_Triangle")]
		extern static HITRESULT_LINE  dx_HitCheck_Line_Triangle_x64( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static HITRESULT_LINE  HitCheck_Line_Triangle( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_HitCheck_Line_Triangle_x86( LinePos1 , LinePos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
			else
			{
				return dx_HitCheck_Line_Triangle_x64( LinePos1 , LinePos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Triangle_Triangle")]
		extern static int  dx_HitCheck_Triangle_Triangle_x86( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_HitCheck_Triangle_Triangle")]
		extern static int  dx_HitCheck_Triangle_Triangle_x64( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3);
		public static int  HitCheck_Triangle_Triangle( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_HitCheck_Triangle_Triangle_x86( Triangle1Pos1 , Triangle1Pos2 , Triangle1Pos3 , Triangle2Pos1 , Triangle2Pos2 , Triangle2Pos3 );
			}
			else
			{
				return dx_HitCheck_Triangle_Triangle_x64( Triangle1Pos1 , Triangle1Pos2 , Triangle1Pos3 , Triangle2Pos1 , Triangle2Pos2 , Triangle2Pos3 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Line_Sphere")]
		extern static int  dx_HitCheck_Line_Sphere_x86( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  SphereCenterPos, float  SphereR);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_HitCheck_Line_Sphere")]
		extern static int  dx_HitCheck_Line_Sphere_x64( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  SphereCenterPos, float  SphereR);
		public static int  HitCheck_Line_Sphere( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  SphereCenterPos, float  SphereR)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_HitCheck_Line_Sphere_x86( LinePos1 , LinePos2 , SphereCenterPos , SphereR );
			}
			else
			{
				return dx_HitCheck_Line_Sphere_x64( LinePos1 , LinePos2 , SphereCenterPos , SphereR );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Sphere_Sphere")]
		extern static int  dx_HitCheck_Sphere_Sphere_x86( VECTOR  Sphere1CenterPos, float  Sphere1R, VECTOR  Sphere2CenterPos, float  Sphere2R);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_HitCheck_Sphere_Sphere")]
		extern static int  dx_HitCheck_Sphere_Sphere_x64( VECTOR  Sphere1CenterPos, float  Sphere1R, VECTOR  Sphere2CenterPos, float  Sphere2R);
		public static int  HitCheck_Sphere_Sphere( VECTOR  Sphere1CenterPos, float  Sphere1R, VECTOR  Sphere2CenterPos, float  Sphere2R)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_HitCheck_Sphere_Sphere_x86( Sphere1CenterPos , Sphere1R , Sphere2CenterPos , Sphere2R );
			}
			else
			{
				return dx_HitCheck_Sphere_Sphere_x64( Sphere1CenterPos , Sphere1R , Sphere2CenterPos , Sphere2R );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Sphere_Triangle")]
		extern static int  dx_HitCheck_Sphere_Triangle_x86( VECTOR  SphereCenterPos, float  SphereR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_HitCheck_Sphere_Triangle")]
		extern static int  dx_HitCheck_Sphere_Triangle_x64( VECTOR  SphereCenterPos, float  SphereR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static int  HitCheck_Sphere_Triangle( VECTOR  SphereCenterPos, float  SphereR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_HitCheck_Sphere_Triangle_x86( SphereCenterPos , SphereR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
			else
			{
				return dx_HitCheck_Sphere_Triangle_x64( SphereCenterPos , SphereR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Capsule_Capsule")]
		extern static int  dx_HitCheck_Capsule_Capsule_x86( VECTOR  Cap1Pos1, VECTOR  Cap1Pos2, float  Cap1R, VECTOR  Cap2Pos1, VECTOR  Cap2Pos2, float  Cap2R);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_HitCheck_Capsule_Capsule")]
		extern static int  dx_HitCheck_Capsule_Capsule_x64( VECTOR  Cap1Pos1, VECTOR  Cap1Pos2, float  Cap1R, VECTOR  Cap2Pos1, VECTOR  Cap2Pos2, float  Cap2R);
		public static int  HitCheck_Capsule_Capsule( VECTOR  Cap1Pos1, VECTOR  Cap1Pos2, float  Cap1R, VECTOR  Cap2Pos1, VECTOR  Cap2Pos2, float  Cap2R)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_HitCheck_Capsule_Capsule_x86( Cap1Pos1 , Cap1Pos2 , Cap1R , Cap2Pos1 , Cap2Pos2 , Cap2R );
			}
			else
			{
				return dx_HitCheck_Capsule_Capsule_x64( Cap1Pos1 , Cap1Pos2 , Cap1R , Cap2Pos1 , Cap2Pos2 , Cap2R );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_HitCheck_Capsule_Triangle")]
		extern static int  dx_HitCheck_Capsule_Triangle_x86( VECTOR  CapPos1, VECTOR  CapPos2, float  CapR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_HitCheck_Capsule_Triangle")]
		extern static int  dx_HitCheck_Capsule_Triangle_x64( VECTOR  CapPos1, VECTOR  CapPos2, float  CapR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static int  HitCheck_Capsule_Triangle( VECTOR  CapPos1, VECTOR  CapPos2, float  CapR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_HitCheck_Capsule_Triangle_x86( CapPos1 , CapPos2 , CapR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
			else
			{
				return dx_HitCheck_Capsule_Triangle_x64( CapPos1 , CapPos2 , CapR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RectClipping")]
		extern static int  dx_RectClipping_x86( out RECT  MotoRect, out RECT  ClippuRect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_RectClipping")]
		extern static int  dx_RectClipping_x64( out RECT  MotoRect, out RECT  ClippuRect);
		public static int  RectClipping( out RECT  MotoRect, out RECT  ClippuRect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_RectClipping_x86( out MotoRect , out ClippuRect );
			}
			else
			{
				return dx_RectClipping_x64( out MotoRect , out ClippuRect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_RectAdjust")]
		extern static int  dx_RectAdjust_x86( out RECT  Rect);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_RectAdjust")]
		extern static int  dx_RectAdjust_x64( out RECT  Rect);
		public static int  RectAdjust( out RECT  Rect)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_RectAdjust_x86( out Rect );
			}
			else
			{
				return dx_RectAdjust_x64( out Rect );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetRectSize")]
		extern static int  dx_GetRectSize_x86( out RECT  Rect, out int  Width, out int  Height);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetRectSize")]
		extern static int  dx_GetRectSize_x64( out RECT  Rect, out int  Width, out int  Height);
		public static int  GetRectSize( out RECT  Rect, out int  Width, out int  Height)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetRectSize_x86( out Rect , out Width , out Height );
			}
			else
			{
				return dx_GetRectSize_x64( out Rect , out Width , out Height );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetIdent")]
		extern static MATRIX  dx_MGetIdent_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetIdent")]
		extern static MATRIX  dx_MGetIdent_x64( );
		public static MATRIX  MGetIdent( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetIdent_x86( );
			}
			else
			{
				return dx_MGetIdent_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MMult")]
		extern static MATRIX  dx_MMult_x86( MATRIX  In1, MATRIX  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MMult")]
		extern static MATRIX  dx_MMult_x64( MATRIX  In1, MATRIX  In2);
		public static MATRIX  MMult( MATRIX  In1, MATRIX  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MMult_x86( In1 , In2 );
			}
			else
			{
				return dx_MMult_x64( In1 , In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MScale")]
		extern static MATRIX  dx_MScale_x86( MATRIX  InM, float  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MScale")]
		extern static MATRIX  dx_MScale_x64( MATRIX  InM, float  Scale);
		public static MATRIX  MScale( MATRIX  InM, float  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MScale_x86( InM , Scale );
			}
			else
			{
				return dx_MScale_x64( InM , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MAdd")]
		extern static MATRIX  dx_MAdd_x86( MATRIX  In1, MATRIX  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MAdd")]
		extern static MATRIX  dx_MAdd_x64( MATRIX  In1, MATRIX  In2);
		public static MATRIX  MAdd( MATRIX  In1, MATRIX  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MAdd_x86( In1 , In2 );
			}
			else
			{
				return dx_MAdd_x64( In1 , In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetScale")]
		extern static MATRIX  dx_MGetScale_x86( VECTOR  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetScale")]
		extern static MATRIX  dx_MGetScale_x64( VECTOR  Scale);
		public static MATRIX  MGetScale( VECTOR  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetScale_x86( Scale );
			}
			else
			{
				return dx_MGetScale_x64( Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotX")]
		extern static MATRIX  dx_MGetRotX_x86( float  XAxisRotate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetRotX")]
		extern static MATRIX  dx_MGetRotX_x64( float  XAxisRotate);
		public static MATRIX  MGetRotX( float  XAxisRotate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetRotX_x86( XAxisRotate );
			}
			else
			{
				return dx_MGetRotX_x64( XAxisRotate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotY")]
		extern static MATRIX  dx_MGetRotY_x86( float  YAxisRotate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetRotY")]
		extern static MATRIX  dx_MGetRotY_x64( float  YAxisRotate);
		public static MATRIX  MGetRotY( float  YAxisRotate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetRotY_x86( YAxisRotate );
			}
			else
			{
				return dx_MGetRotY_x64( YAxisRotate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotZ")]
		extern static MATRIX  dx_MGetRotZ_x86( float  ZAxisRotate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetRotZ")]
		extern static MATRIX  dx_MGetRotZ_x64( float  ZAxisRotate);
		public static MATRIX  MGetRotZ( float  ZAxisRotate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetRotZ_x86( ZAxisRotate );
			}
			else
			{
				return dx_MGetRotZ_x64( ZAxisRotate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotAxis")]
		extern static MATRIX  dx_MGetRotAxis_x86( VECTOR  RotateAxis, float  Rotate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetRotAxis")]
		extern static MATRIX  dx_MGetRotAxis_x64( VECTOR  RotateAxis, float  Rotate);
		public static MATRIX  MGetRotAxis( VECTOR  RotateAxis, float  Rotate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetRotAxis_x86( RotateAxis , Rotate );
			}
			else
			{
				return dx_MGetRotAxis_x64( RotateAxis , Rotate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetRotVec2")]
		extern static MATRIX  dx_MGetRotVec2_x86( VECTOR  In1, VECTOR  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetRotVec2")]
		extern static MATRIX  dx_MGetRotVec2_x64( VECTOR  In1, VECTOR  In2);
		public static MATRIX  MGetRotVec2( VECTOR  In1, VECTOR  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetRotVec2_x86( In1 , In2 );
			}
			else
			{
				return dx_MGetRotVec2_x64( In1 , In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetTranslate")]
		extern static MATRIX  dx_MGetTranslate_x86( VECTOR  Trans);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetTranslate")]
		extern static MATRIX  dx_MGetTranslate_x64( VECTOR  Trans);
		public static MATRIX  MGetTranslate( VECTOR  Trans)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetTranslate_x86( Trans );
			}
			else
			{
				return dx_MGetTranslate_x64( Trans );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetAxis1")]
		extern static MATRIX  dx_MGetAxis1_x86( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetAxis1")]
		extern static MATRIX  dx_MGetAxis1_x64( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos);
		public static MATRIX  MGetAxis1( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetAxis1_x86( XAxis , YAxis , ZAxis , Pos );
			}
			else
			{
				return dx_MGetAxis1_x64( XAxis , YAxis , ZAxis , Pos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetAxis2")]
		extern static MATRIX  dx_MGetAxis2_x86( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetAxis2")]
		extern static MATRIX  dx_MGetAxis2_x64( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos);
		public static MATRIX  MGetAxis2( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetAxis2_x86( XAxis , YAxis , ZAxis , Pos );
			}
			else
			{
				return dx_MGetAxis2_x64( XAxis , YAxis , ZAxis , Pos );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MTranspose")]
		extern static MATRIX  dx_MTranspose_x86( MATRIX  InM);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MTranspose")]
		extern static MATRIX  dx_MTranspose_x64( MATRIX  InM);
		public static MATRIX  MTranspose( MATRIX  InM)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MTranspose_x86( InM );
			}
			else
			{
				return dx_MTranspose_x64( InM );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MInverse")]
		extern static MATRIX  dx_MInverse_x86( MATRIX  InM);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MInverse")]
		extern static MATRIX  dx_MInverse_x64( MATRIX  InM);
		public static MATRIX  MInverse( MATRIX  InM)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MInverse_x86( InM );
			}
			else
			{
				return dx_MInverse_x64( InM );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MGetSize")]
		extern static VECTOR  dx_MGetSize_x86( MATRIX  InM);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MGetSize")]
		extern static VECTOR  dx_MGetSize_x64( MATRIX  InM);
		public static VECTOR  MGetSize( MATRIX  InM)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MGetSize_x86( InM );
			}
			else
			{
				return dx_MGetSize_x64( InM );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VNorm")]
		extern static VECTOR  dx_VNorm_x86( VECTOR  In);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VNorm")]
		extern static VECTOR  dx_VNorm_x64( VECTOR  In);
		public static VECTOR  VNorm( VECTOR  In)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VNorm_x86( In );
			}
			else
			{
				return dx_VNorm_x64( In );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VSize")]
		extern static float  dx_VSize_x86( VECTOR  In);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VSize")]
		extern static float  dx_VSize_x64( VECTOR  In);
		public static float  VSize( VECTOR  In)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VSize_x86( In );
			}
			else
			{
				return dx_VSize_x64( In );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VCos")]
		extern static float  dx_VCos_x86( VECTOR  In1, VECTOR  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VCos")]
		extern static float  dx_VCos_x64( VECTOR  In1, VECTOR  In2);
		public static float  VCos( VECTOR  In1, VECTOR  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VCos_x86( In1 , In2 );
			}
			else
			{
				return dx_VCos_x64( In1 , In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_VRad")]
		extern static float  dx_VRad_x86( VECTOR  In1, VECTOR  In2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_VRad")]
		extern static float  dx_VRad_x64( VECTOR  In1, VECTOR  In2);
		public static float  VRad( VECTOR  In1, VECTOR  In2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_VRad_x86( In1 , In2 );
			}
			else
			{
				return dx_VRad_x64( In1 , In2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseFastLoadFlag")]
		extern static int  dx_SetUseFastLoadFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseFastLoadFlag")]
		extern static int  dx_SetUseFastLoadFlag_x64( int  Flag);
		public static int  SetUseFastLoadFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseFastLoadFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseFastLoadFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetGraphDataShavedMode")]
		extern static int  dx_SetGraphDataShavedMode_x86( int  ShavedMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetGraphDataShavedMode")]
		extern static int  dx_SetGraphDataShavedMode_x64( int  ShavedMode);
		public static int  SetGraphDataShavedMode( int  ShavedMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetGraphDataShavedMode_x86( ShavedMode );
			}
			else
			{
				return dx_SetGraphDataShavedMode_x64( ShavedMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetGraphDataShavedMode")]
		extern static int  dx_GetGraphDataShavedMode_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetGraphDataShavedMode")]
		extern static int  dx_GetGraphDataShavedMode_x64( );
		public static int  GetGraphDataShavedMode( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetGraphDataShavedMode_x86( );
			}
			else
			{
				return dx_GetGraphDataShavedMode_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColorF")]
		extern static COLOR_F  dx_GetColorF_x86( float  Red, float  Green, float  Blue, float  Alpha);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetColorF")]
		extern static COLOR_F  dx_GetColorF_x64( float  Red, float  Green, float  Blue, float  Alpha);
		public static COLOR_F  GetColorF( float  Red, float  Green, float  Blue, float  Alpha)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetColorF_x86( Red , Green , Blue , Alpha );
			}
			else
			{
				return dx_GetColorF_x64( Red , Green , Blue , Alpha );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColorU8")]
		extern static COLOR_U8  dx_GetColorU8_x86( int  Red, int  Green, int  Blue, int  Alpha);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetColorU8")]
		extern static COLOR_U8  dx_GetColorU8_x64( int  Red, int  Green, int  Blue, int  Alpha);
		public static COLOR_U8  GetColorU8( int  Red, int  Green, int  Blue, int  Alpha)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetColorU8_x86( Red , Green , Blue , Alpha );
			}
			else
			{
				return dx_GetColorU8_x64( Red , Green , Blue , Alpha );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor")]
		extern static int  dx_GetColor_x86( int  Red, int  Green, int  Blue);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetColor")]
		extern static int  dx_GetColor_x64( int  Red, int  Green, int  Blue);
		public static int  GetColor( int  Red, int  Green, int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetColor_x86( Red , Green , Blue );
			}
			else
			{
				return dx_GetColor_x64( Red , Green , Blue );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor2")]
		extern static int  dx_GetColor2_x86( int  Color, out int  Red, out int  Green, out int  Blue);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetColor2")]
		extern static int  dx_GetColor2_x64( int  Color, out int  Red, out int  Green, out int  Blue);
		public static int  GetColor2( int  Color, out int  Red, out int  Green, out int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetColor2_x86( Color , out Red , out Green , out Blue );
			}
			else
			{
				return dx_GetColor2_x64( Color , out Red , out Green , out Blue );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor3")]
		extern static int  dx_GetColor3_x86( out COLORDATA  ColorData, int  Red, int  Green, int  Blue, int  Alpha);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetColor3")]
		extern static int  dx_GetColor3_x64( out COLORDATA  ColorData, int  Red, int  Green, int  Blue, int  Alpha);
		public static int  GetColor3( out COLORDATA  ColorData, int  Red, int  Green, int  Blue)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetColor3_x86( out ColorData , Red , Green , Blue , 255 );
			}
			else
			{
				return dx_GetColor3_x64( out ColorData , Red , Green , Blue , 255 );
			}
		}
		public static int  GetColor3( out COLORDATA  ColorData, int  Red, int  Green, int  Blue, int  Alpha)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetColor3_x86( out ColorData , Red , Green , Blue , Alpha );
			}
			else
			{
				return dx_GetColor3_x64( out ColorData , Red , Green , Blue , Alpha );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor4")]
		extern static int  dx_GetColor4_x86( out COLORDATA  DestColorData, out COLORDATA  SrcColorData, int  SrcColor);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetColor4")]
		extern static int  dx_GetColor4_x64( out COLORDATA  DestColorData, out COLORDATA  SrcColorData, int  SrcColor);
		public static int  GetColor4( out COLORDATA  DestColorData, out COLORDATA  SrcColorData, int  SrcColor)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetColor4_x86( out DestColorData , out SrcColorData , SrcColor );
			}
			else
			{
				return dx_GetColor4_x64( out DestColorData , out SrcColorData , SrcColor );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetColor5")]
		extern static int  dx_GetColor5_x86( out COLORDATA  ColorData, int  Color, out int  Red, out int  Green, out int  Blue, out int  Alpha);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetColor5")]
		extern static int  dx_GetColor5_x64( out COLORDATA  ColorData, int  Color, out int  Red, out int  Green, out int  Blue, out int  Alpha);
		public static int  GetColor5( out COLORDATA  ColorData, int  Color, out int  Red, out int  Green, out int  Blue, out int  Alpha)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetColor5_x86( out ColorData , Color , out Red , out Green , out Blue , out Alpha );
			}
			else
			{
				return dx_GetColor5_x64( out ColorData , Color , out Red , out Green , out Blue , out Alpha );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePaletteColorData")]
		extern static int  dx_CreatePaletteColorData_x86( out COLORDATA  ColorDataBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreatePaletteColorData")]
		extern static int  dx_CreatePaletteColorData_x64( out COLORDATA  ColorDataBuf);
		public static int  CreatePaletteColorData( out COLORDATA  ColorDataBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreatePaletteColorData_x86( out ColorDataBuf );
			}
			else
			{
				return dx_CreatePaletteColorData_x64( out ColorDataBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateXRGB8ColorData")]
		extern static int  dx_CreateXRGB8ColorData_x86( out COLORDATA  ColorDataBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateXRGB8ColorData")]
		extern static int  dx_CreateXRGB8ColorData_x64( out COLORDATA  ColorDataBuf);
		public static int  CreateXRGB8ColorData( out COLORDATA  ColorDataBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateXRGB8ColorData_x86( out ColorDataBuf );
			}
			else
			{
				return dx_CreateXRGB8ColorData_x64( out ColorDataBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateARGB8ColorData")]
		extern static int  dx_CreateARGB8ColorData_x86( out COLORDATA  ColorDataBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateARGB8ColorData")]
		extern static int  dx_CreateARGB8ColorData_x64( out COLORDATA  ColorDataBuf);
		public static int  CreateARGB8ColorData( out COLORDATA  ColorDataBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateARGB8ColorData_x86( out ColorDataBuf );
			}
			else
			{
				return dx_CreateARGB8ColorData_x64( out ColorDataBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateARGB4ColorData")]
		extern static int  dx_CreateARGB4ColorData_x86( out COLORDATA  ColorDataBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateARGB4ColorData")]
		extern static int  dx_CreateARGB4ColorData_x64( out COLORDATA  ColorDataBuf);
		public static int  CreateARGB4ColorData( out COLORDATA  ColorDataBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateARGB4ColorData_x86( out ColorDataBuf );
			}
			else
			{
				return dx_CreateARGB4ColorData_x64( out ColorDataBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateFullColorData")]
		extern static int  dx_CreateFullColorData_x86( out COLORDATA  ColorDataBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateFullColorData")]
		extern static int  dx_CreateFullColorData_x64( out COLORDATA  ColorDataBuf);
		public static int  CreateFullColorData( out COLORDATA  ColorDataBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateFullColorData_x86( out ColorDataBuf );
			}
			else
			{
				return dx_CreateFullColorData_x64( out ColorDataBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateGrayColorData")]
		extern static int  dx_CreateGrayColorData_x86( out COLORDATA  ColorDataBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateGrayColorData")]
		extern static int  dx_CreateGrayColorData_x64( out COLORDATA  ColorDataBuf);
		public static int  CreateGrayColorData( out COLORDATA  ColorDataBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateGrayColorData_x86( out ColorDataBuf );
			}
			else
			{
				return dx_CreateGrayColorData_x64( out ColorDataBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreatePal8ColorData")]
		extern static int  dx_CreatePal8ColorData_x86( out COLORDATA  ColorDataBuf);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreatePal8ColorData")]
		extern static int  dx_CreatePal8ColorData_x64( out COLORDATA  ColorDataBuf);
		public static int  CreatePal8ColorData( out COLORDATA  ColorDataBuf)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreatePal8ColorData_x86( out ColorDataBuf );
			}
			else
			{
				return dx_CreatePal8ColorData_x64( out ColorDataBuf );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CreateColorData")]
		extern static int  dx_CreateColorData_x86( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask, int  ChannelNum, int  ChannelBitDepth, int  FloatTypeFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CreateColorData")]
		extern static int  dx_CreateColorData_x64( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask, int  ChannelNum, int  ChannelBitDepth, int  FloatTypeFlag);
		public static int  CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateColorData_x86( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , 0 , 0 , FALSE );
			}
			else
			{
				return dx_CreateColorData_x64( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , 0 , 0 , FALSE );
			}
		}
		public static int  CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask, int  ChannelNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateColorData_x86( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , ChannelNum , 0 , FALSE );
			}
			else
			{
				return dx_CreateColorData_x64( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , ChannelNum , 0 , FALSE );
			}
		}
		public static int  CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask, int  ChannelNum, int  ChannelBitDepth)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateColorData_x86( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , ChannelNum , ChannelBitDepth , FALSE );
			}
			else
			{
				return dx_CreateColorData_x64( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , ChannelNum , ChannelBitDepth , FALSE );
			}
		}
		public static int  CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask, int  ChannelNum, int  ChannelBitDepth, int  FloatTypeFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CreateColorData_x86( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , ChannelNum , ChannelBitDepth , FloatTypeFlag );
			}
			else
			{
				return dx_CreateColorData_x64( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , ChannelNum , ChannelBitDepth , FloatTypeFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetColorDataNoneMask")]
		extern static void  dx_SetColorDataNoneMask_x86( out COLORDATA  ColorData);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetColorDataNoneMask")]
		extern static void  dx_SetColorDataNoneMask_x64( out COLORDATA  ColorData);
		public static void  SetColorDataNoneMask( out COLORDATA  ColorData)
		{
			if( System.IntPtr.Size == 4 )
			{
				dx_SetColorDataNoneMask_x86( out ColorData );
			}
			else
			{
				dx_SetColorDataNoneMask_x64( out ColorData );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CmpColorData")]
		extern static int  dx_CmpColorData_x86( out COLORDATA  ColorData1, out COLORDATA  ColorData2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CmpColorData")]
		extern static int  dx_CmpColorData_x64( out COLORDATA  ColorData1, out COLORDATA  ColorData2);
		public static int  CmpColorData( out COLORDATA  ColorData1, out COLORDATA  ColorData2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CmpColorData_x86( out ColorData1 , out ColorData2 );
			}
			else
			{
				return dx_CmpColorData_x64( out ColorData1 , out ColorData2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitSoftImage")]
		extern static int  dx_InitSoftImage_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitSoftImage")]
		extern static int  dx_InitSoftImage_x64( );
		public static int  InitSoftImage( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitSoftImage_x86( );
			}
			else
			{
				return dx_InitSoftImage_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoftImage")]
		extern static int  dx_LoadSoftImage_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoftImage")]
		extern static int  dx_LoadSoftImage_x64( string  FileName);
		public static int  LoadSoftImage( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoftImage_x86( FileName );
			}
			else
			{
				return dx_LoadSoftImage_x64( FileName );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoftImageToMem")]
		extern unsafe static int  dx_LoadSoftImageToMem_x86( void *  FileImage, int  FileImageSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoftImageToMem")]
		extern unsafe static int  dx_LoadSoftImageToMem_x64( void *  FileImage, int  FileImageSize);
		public unsafe static int  LoadSoftImageToMem( void *  FileImage, int  FileImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoftImageToMem_x86( FileImage , FileImageSize );
			}
			else
			{
				return dx_LoadSoftImageToMem_x64( FileImage , FileImageSize );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftImage")]
		extern static int  dx_MakeSoftImage_x86( int  SizeX, int  SizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftImage")]
		extern static int  dx_MakeSoftImage_x64( int  SizeX, int  SizeY);
		public static int  MakeSoftImage( int  SizeX, int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftImage_x86( SizeX , SizeY );
			}
			else
			{
				return dx_MakeSoftImage_x64( SizeX , SizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeARGB8ColorSoftImage")]
		extern static int  dx_MakeARGB8ColorSoftImage_x86( int  SizeX, int  SizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeARGB8ColorSoftImage")]
		extern static int  dx_MakeARGB8ColorSoftImage_x64( int  SizeX, int  SizeY);
		public static int  MakeARGB8ColorSoftImage( int  SizeX, int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeARGB8ColorSoftImage_x86( SizeX , SizeY );
			}
			else
			{
				return dx_MakeARGB8ColorSoftImage_x64( SizeX , SizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeXRGB8ColorSoftImage")]
		extern static int  dx_MakeXRGB8ColorSoftImage_x86( int  SizeX, int  SizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeXRGB8ColorSoftImage")]
		extern static int  dx_MakeXRGB8ColorSoftImage_x64( int  SizeX, int  SizeY);
		public static int  MakeXRGB8ColorSoftImage( int  SizeX, int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeXRGB8ColorSoftImage_x86( SizeX , SizeY );
			}
			else
			{
				return dx_MakeXRGB8ColorSoftImage_x64( SizeX , SizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeARGB4ColorSoftImage")]
		extern static int  dx_MakeARGB4ColorSoftImage_x86( int  SizeX, int  SizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeARGB4ColorSoftImage")]
		extern static int  dx_MakeARGB4ColorSoftImage_x64( int  SizeX, int  SizeY);
		public static int  MakeARGB4ColorSoftImage( int  SizeX, int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeARGB4ColorSoftImage_x86( SizeX , SizeY );
			}
			else
			{
				return dx_MakeARGB4ColorSoftImage_x64( SizeX , SizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeRGB8ColorSoftImage")]
		extern static int  dx_MakeRGB8ColorSoftImage_x86( int  SizeX, int  SizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeRGB8ColorSoftImage")]
		extern static int  dx_MakeRGB8ColorSoftImage_x64( int  SizeX, int  SizeY);
		public static int  MakeRGB8ColorSoftImage( int  SizeX, int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeRGB8ColorSoftImage_x86( SizeX , SizeY );
			}
			else
			{
				return dx_MakeRGB8ColorSoftImage_x64( SizeX , SizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakePAL8ColorSoftImage")]
		extern static int  dx_MakePAL8ColorSoftImage_x86( int  SizeX, int  SizeY);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakePAL8ColorSoftImage")]
		extern static int  dx_MakePAL8ColorSoftImage_x64( int  SizeX, int  SizeY);
		public static int  MakePAL8ColorSoftImage( int  SizeX, int  SizeY)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakePAL8ColorSoftImage_x86( SizeX , SizeY );
			}
			else
			{
				return dx_MakePAL8ColorSoftImage_x64( SizeX , SizeY );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSoftImage")]
		extern static int  dx_DeleteSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteSoftImage")]
		extern static int  dx_DeleteSoftImage_x64( int  SIHandle);
		public static int  DeleteSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_DeleteSoftImage_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftImageSize")]
		extern static int  dx_GetSoftImageSize_x86( int  SIHandle, out int  Width, out int  Height);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetSoftImageSize")]
		extern static int  dx_GetSoftImageSize_x64( int  SIHandle, out int  Width, out int  Height);
		public static int  GetSoftImageSize( int  SIHandle, out int  Width, out int  Height)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetSoftImageSize_x86( SIHandle , out Width , out Height );
			}
			else
			{
				return dx_GetSoftImageSize_x64( SIHandle , out Width , out Height );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckPaletteSoftImage")]
		extern static int  dx_CheckPaletteSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckPaletteSoftImage")]
		extern static int  dx_CheckPaletteSoftImage_x64( int  SIHandle);
		public static int  CheckPaletteSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckPaletteSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_CheckPaletteSoftImage_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckAlphaSoftImage")]
		extern static int  dx_CheckAlphaSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckAlphaSoftImage")]
		extern static int  dx_CheckAlphaSoftImage_x64( int  SIHandle);
		public static int  CheckAlphaSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckAlphaSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_CheckAlphaSoftImage_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckPixelAlphaSoftImage")]
		extern static int  dx_CheckPixelAlphaSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckPixelAlphaSoftImage")]
		extern static int  dx_CheckPixelAlphaSoftImage_x64( int  SIHandle);
		public static int  CheckPixelAlphaSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckPixelAlphaSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_CheckPixelAlphaSoftImage_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDrawScreenSoftImage")]
		extern static int  dx_GetDrawScreenSoftImage_x86( int  x1, int  y1, int  x2, int  y2, int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDrawScreenSoftImage")]
		extern static int  dx_GetDrawScreenSoftImage_x64( int  x1, int  y1, int  x2, int  y2, int  SIHandle);
		public static int  GetDrawScreenSoftImage( int  x1, int  y1, int  x2, int  y2, int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDrawScreenSoftImage_x86( x1 , y1 , x2 , y2 , SIHandle );
			}
			else
			{
				return dx_GetDrawScreenSoftImage_x64( x1 , y1 , x2 , y2 , SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_UpdateLayerdWindowForSoftImage")]
		extern static int  dx_UpdateLayerdWindowForSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_UpdateLayerdWindowForSoftImage")]
		extern static int  dx_UpdateLayerdWindowForSoftImage_x64( int  SIHandle);
		public static int  UpdateLayerdWindowForSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_UpdateLayerdWindowForSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_UpdateLayerdWindowForSoftImage_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_UpdateLayerdWindowForPremultipliedAlphaSoftImage")]
		extern static int  dx_UpdateLayerdWindowForPremultipliedAlphaSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_UpdateLayerdWindowForPremultipliedAlphaSoftImage")]
		extern static int  dx_UpdateLayerdWindowForPremultipliedAlphaSoftImage_x64( int  SIHandle);
		public static int  UpdateLayerdWindowForPremultipliedAlphaSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_UpdateLayerdWindowForPremultipliedAlphaSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_UpdateLayerdWindowForPremultipliedAlphaSoftImage_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_FillSoftImage")]
		extern static int  dx_FillSoftImage_x86( int  SIHandle, int  r, int  g, int  b, int  a);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_FillSoftImage")]
		extern static int  dx_FillSoftImage_x64( int  SIHandle, int  r, int  g, int  b, int  a);
		public static int  FillSoftImage( int  SIHandle, int  r, int  g, int  b, int  a)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_FillSoftImage_x86( SIHandle , r , g , b , a );
			}
			else
			{
				return dx_FillSoftImage_x64( SIHandle , r , g , b , a );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ClearRectSoftImage")]
		extern static int  dx_ClearRectSoftImage_x86( int  SIHandle, int  x, int  y, int  w, int  h);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ClearRectSoftImage")]
		extern static int  dx_ClearRectSoftImage_x64( int  SIHandle, int  x, int  y, int  w, int  h);
		public static int  ClearRectSoftImage( int  SIHandle, int  x, int  y, int  w, int  h)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ClearRectSoftImage_x86( SIHandle , x , y , w , h );
			}
			else
			{
				return dx_ClearRectSoftImage_x64( SIHandle , x , y , w , h );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPaletteSoftImage")]
		extern static int  dx_GetPaletteSoftImage_x86( int  SIHandle, int  PaletteNo, out int  r, out int  g, out int  b, out int  a);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetPaletteSoftImage")]
		extern static int  dx_GetPaletteSoftImage_x64( int  SIHandle, int  PaletteNo, out int  r, out int  g, out int  b, out int  a);
		public static int  GetPaletteSoftImage( int  SIHandle, int  PaletteNo, out int  r, out int  g, out int  b, out int  a)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetPaletteSoftImage_x86( SIHandle , PaletteNo , out r , out g , out b , out a );
			}
			else
			{
				return dx_GetPaletteSoftImage_x64( SIHandle , PaletteNo , out r , out g , out b , out a );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPaletteSoftImage")]
		extern static int  dx_SetPaletteSoftImage_x86( int  SIHandle, int  PaletteNo, int  r, int  g, int  b, int  a);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPaletteSoftImage")]
		extern static int  dx_SetPaletteSoftImage_x64( int  SIHandle, int  PaletteNo, int  r, int  g, int  b, int  a);
		public static int  SetPaletteSoftImage( int  SIHandle, int  PaletteNo, int  r, int  g, int  b, int  a)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPaletteSoftImage_x86( SIHandle , PaletteNo , r , g , b , a );
			}
			else
			{
				return dx_SetPaletteSoftImage_x64( SIHandle , PaletteNo , r , g , b , a );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelPalCodeSoftImage")]
		extern static int  dx_DrawPixelPalCodeSoftImage_x86( int  SIHandle, int  x, int  y, int  palNo);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPixelPalCodeSoftImage")]
		extern static int  dx_DrawPixelPalCodeSoftImage_x64( int  SIHandle, int  x, int  y, int  palNo);
		public static int  DrawPixelPalCodeSoftImage( int  SIHandle, int  x, int  y, int  palNo)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPixelPalCodeSoftImage_x86( SIHandle , x , y , palNo );
			}
			else
			{
				return dx_DrawPixelPalCodeSoftImage_x64( SIHandle , x , y , palNo );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixelPalCodeSoftImage")]
		extern static int  dx_GetPixelPalCodeSoftImage_x86( int  SIHandle, int  x, int  y);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetPixelPalCodeSoftImage")]
		extern static int  dx_GetPixelPalCodeSoftImage_x64( int  SIHandle, int  x, int  y);
		public static int  GetPixelPalCodeSoftImage( int  SIHandle, int  x, int  y)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetPixelPalCodeSoftImage_x86( SIHandle , x , y );
			}
			else
			{
				return dx_GetPixelPalCodeSoftImage_x64( SIHandle , x , y );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetImageAddressSoftImage")]
		extern unsafe static void *  dx_GetImageAddressSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetImageAddressSoftImage")]
		extern unsafe static void *  dx_GetImageAddressSoftImage_x64( int  SIHandle);
		public unsafe static void *  GetImageAddressSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetImageAddressSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_GetImageAddressSoftImage_x64( SIHandle );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelSoftImage")]
		extern static int  dx_DrawPixelSoftImage_x86( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPixelSoftImage")]
		extern static int  dx_DrawPixelSoftImage_x64( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a);
		public static int  DrawPixelSoftImage( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawPixelSoftImage_x86( SIHandle , x , y , r , g , b , a );
			}
			else
			{
				return dx_DrawPixelSoftImage_x64( SIHandle , x , y , r , g , b , a );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelSoftImage_Unsafe_XRGB8")]
		extern static void  dx_DrawPixelSoftImage_Unsafe_XRGB8_x86( int  SIHandle, int  x, int  y, int  r, int  g, int  b);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPixelSoftImage_Unsafe_XRGB8")]
		extern static void  dx_DrawPixelSoftImage_Unsafe_XRGB8_x64( int  SIHandle, int  x, int  y, int  r, int  g, int  b);
		public static void  DrawPixelSoftImage_Unsafe_XRGB8( int  SIHandle, int  x, int  y, int  r, int  g, int  b)
		{
			if( System.IntPtr.Size == 4 )
			{
				dx_DrawPixelSoftImage_Unsafe_XRGB8_x86( SIHandle , x , y , r , g , b );
			}
			else
			{
				dx_DrawPixelSoftImage_Unsafe_XRGB8_x64( SIHandle , x , y , r , g , b );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawPixelSoftImage_Unsafe_ARGB8")]
		extern static void  dx_DrawPixelSoftImage_Unsafe_ARGB8_x86( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawPixelSoftImage_Unsafe_ARGB8")]
		extern static void  dx_DrawPixelSoftImage_Unsafe_ARGB8_x64( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a);
		public static void  DrawPixelSoftImage_Unsafe_ARGB8( int  SIHandle, int  x, int  y, int  r, int  g, int  b, int  a)
		{
			if( System.IntPtr.Size == 4 )
			{
				dx_DrawPixelSoftImage_Unsafe_ARGB8_x86( SIHandle , x , y , r , g , b , a );
			}
			else
			{
				dx_DrawPixelSoftImage_Unsafe_ARGB8_x64( SIHandle , x , y , r , g , b , a );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixelSoftImage")]
		extern static int  dx_GetPixelSoftImage_x86( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetPixelSoftImage")]
		extern static int  dx_GetPixelSoftImage_x64( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a);
		public static int  GetPixelSoftImage( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetPixelSoftImage_x86( SIHandle , x , y , out r , out g , out b , out a );
			}
			else
			{
				return dx_GetPixelSoftImage_x64( SIHandle , x , y , out r , out g , out b , out a );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixelSoftImage_Unsafe_XRGB8")]
		extern static void  dx_GetPixelSoftImage_Unsafe_XRGB8_x86( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetPixelSoftImage_Unsafe_XRGB8")]
		extern static void  dx_GetPixelSoftImage_Unsafe_XRGB8_x64( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b);
		public static void  GetPixelSoftImage_Unsafe_XRGB8( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b)
		{
			if( System.IntPtr.Size == 4 )
			{
				dx_GetPixelSoftImage_Unsafe_XRGB8_x86( SIHandle , x , y , out r , out g , out b );
			}
			else
			{
				dx_GetPixelSoftImage_Unsafe_XRGB8_x64( SIHandle , x , y , out r , out g , out b );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPixelSoftImage_Unsafe_ARGB8")]
		extern static void  dx_GetPixelSoftImage_Unsafe_ARGB8_x86( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetPixelSoftImage_Unsafe_ARGB8")]
		extern static void  dx_GetPixelSoftImage_Unsafe_ARGB8_x64( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a);
		public static void  GetPixelSoftImage_Unsafe_ARGB8( int  SIHandle, int  x, int  y, out int  r, out int  g, out int  b, out int  a)
		{
			if( System.IntPtr.Size == 4 )
			{
				dx_GetPixelSoftImage_Unsafe_ARGB8_x86( SIHandle , x , y , out r , out g , out b , out a );
			}
			else
			{
				dx_GetPixelSoftImage_Unsafe_ARGB8_x64( SIHandle , x , y , out r , out g , out b , out a );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawLineSoftImage")]
		extern static int  dx_DrawLineSoftImage_x86( int  SIHandle, int  x1, int  y1, int  x2, int  y2, int  r, int  g, int  b, int  a);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawLineSoftImage")]
		extern static int  dx_DrawLineSoftImage_x64( int  SIHandle, int  x1, int  y1, int  x2, int  y2, int  r, int  g, int  b, int  a);
		public static int  DrawLineSoftImage( int  SIHandle, int  x1, int  y1, int  x2, int  y2, int  r, int  g, int  b, int  a)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawLineSoftImage_x86( SIHandle , x1 , y1 , x2 , y2 , r , g , b , a );
			}
			else
			{
				return dx_DrawLineSoftImage_x64( SIHandle , x1 , y1 , x2 , y2 , r , g , b , a );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltSoftImage")]
		extern static int  dx_BltSoftImage_x86( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_BltSoftImage")]
		extern static int  dx_BltSoftImage_x64( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle);
		public static int  BltSoftImage( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltSoftImage_x86( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle );
			}
			else
			{
				return dx_BltSoftImage_x64( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltSoftImageWithTransColor")]
		extern static int  dx_BltSoftImageWithTransColor_x86( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Tr, int  Tg, int  Tb, int  Ta);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_BltSoftImageWithTransColor")]
		extern static int  dx_BltSoftImageWithTransColor_x64( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Tr, int  Tg, int  Tb, int  Ta);
		public static int  BltSoftImageWithTransColor( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Tr, int  Tg, int  Tb, int  Ta)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltSoftImageWithTransColor_x86( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle , Tr , Tg , Tb , Ta );
			}
			else
			{
				return dx_BltSoftImageWithTransColor_x64( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle , Tr , Tg , Tb , Ta );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltSoftImageWithAlphaBlend")]
		extern static int  dx_BltSoftImageWithAlphaBlend_x86( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Opacity);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_BltSoftImageWithAlphaBlend")]
		extern static int  dx_BltSoftImageWithAlphaBlend_x64( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Opacity);
		public static int  BltSoftImageWithAlphaBlend( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltSoftImageWithAlphaBlend_x86( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle , 255 );
			}
			else
			{
				return dx_BltSoftImageWithAlphaBlend_x64( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle , 255 );
			}
		}
		public static int  BltSoftImageWithAlphaBlend( int  SrcX, int  SrcY, int  SrcSizeX, int  SrcSizeY, int  SrcSIHandle, int  DestX, int  DestY, int  DestSIHandle, int  Opacity)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltSoftImageWithAlphaBlend_x86( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle , Opacity );
			}
			else
			{
				return dx_BltSoftImageWithAlphaBlend_x64( SrcX , SrcY , SrcSizeX , SrcSizeY , SrcSIHandle , DestX , DestY , DestSIHandle , Opacity );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReverseSoftImageH")]
		extern static int  dx_ReverseSoftImageH_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReverseSoftImageH")]
		extern static int  dx_ReverseSoftImageH_x64( int  SIHandle);
		public static int  ReverseSoftImageH( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReverseSoftImageH_x86( SIHandle );
			}
			else
			{
				return dx_ReverseSoftImageH_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReverseSoftImageV")]
		extern static int  dx_ReverseSoftImageV_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReverseSoftImageV")]
		extern static int  dx_ReverseSoftImageV_x64( int  SIHandle);
		public static int  ReverseSoftImageV( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReverseSoftImageV_x86( SIHandle );
			}
			else
			{
				return dx_ReverseSoftImageV_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReverseSoftImage")]
		extern static int  dx_ReverseSoftImage_x86( int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReverseSoftImage")]
		extern static int  dx_ReverseSoftImage_x64( int  SIHandle);
		public static int  ReverseSoftImage( int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReverseSoftImage_x86( SIHandle );
			}
			else
			{
				return dx_ReverseSoftImage_x64( SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltStringSoftImage")]
		extern static int  dx_BltStringSoftImage_x86( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_BltStringSoftImage")]
		extern static int  dx_BltStringSoftImage_x64( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  VerticalFlag);
		public static int  BltStringSoftImage( int  x, int  y, string  StrData, int  DestSIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltStringSoftImage_x86( x , y , StrData , DestSIHandle , -1 , FALSE );
			}
			else
			{
				return dx_BltStringSoftImage_x64( x , y , StrData , DestSIHandle , -1 , FALSE );
			}
		}
		public static int  BltStringSoftImage( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltStringSoftImage_x86( x , y , StrData , DestSIHandle , DestEdgeSIHandle , FALSE );
			}
			else
			{
				return dx_BltStringSoftImage_x64( x , y , StrData , DestSIHandle , DestEdgeSIHandle , FALSE );
			}
		}
		public static int  BltStringSoftImage( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltStringSoftImage_x86( x , y , StrData , DestSIHandle , DestEdgeSIHandle , VerticalFlag );
			}
			else
			{
				return dx_BltStringSoftImage_x64( x , y , StrData , DestSIHandle , DestEdgeSIHandle , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_BltStringSoftImageToHandle")]
		extern static int  dx_BltStringSoftImageToHandle_x86( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  FontHandle, int  VerticalFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_BltStringSoftImageToHandle")]
		extern static int  dx_BltStringSoftImageToHandle_x64( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  FontHandle, int  VerticalFlag);
		public static int  BltStringSoftImageToHandle( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  FontHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltStringSoftImageToHandle_x86( x , y , StrData , DestSIHandle , DestEdgeSIHandle , FontHandle , FALSE );
			}
			else
			{
				return dx_BltStringSoftImageToHandle_x64( x , y , StrData , DestSIHandle , DestEdgeSIHandle , FontHandle , FALSE );
			}
		}
		public static int  BltStringSoftImageToHandle( int  x, int  y, string  StrData, int  DestSIHandle, int  DestEdgeSIHandle, int  FontHandle, int  VerticalFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_BltStringSoftImageToHandle_x86( x , y , StrData , DestSIHandle , DestEdgeSIHandle , FontHandle , VerticalFlag );
			}
			else
			{
				return dx_BltStringSoftImageToHandle_x64( x , y , StrData , DestSIHandle , DestEdgeSIHandle , FontHandle , VerticalFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DrawSoftImage")]
		extern static int  dx_DrawSoftImage_x86( int  x, int  y, int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DrawSoftImage")]
		extern static int  dx_DrawSoftImage_x64( int  x, int  y, int  SIHandle);
		public static int  DrawSoftImage( int  x, int  y, int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DrawSoftImage_x86( x , y , SIHandle );
			}
			else
			{
				return dx_DrawSoftImage_x64( x , y , SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveSoftImageToBmp")]
		extern static int  dx_SaveSoftImageToBmp_x86( string  FilePath, int  SIHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SaveSoftImageToBmp")]
		extern static int  dx_SaveSoftImageToBmp_x64( string  FilePath, int  SIHandle);
		public static int  SaveSoftImageToBmp( string  FilePath, int  SIHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveSoftImageToBmp_x86( FilePath , SIHandle );
			}
			else
			{
				return dx_SaveSoftImageToBmp_x64( FilePath , SIHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveSoftImageToPng")]
		extern static int  dx_SaveSoftImageToPng_x86( string  FilePath, int  SIHandle, int  CompressionLevel);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SaveSoftImageToPng")]
		extern static int  dx_SaveSoftImageToPng_x64( string  FilePath, int  SIHandle, int  CompressionLevel);
		public static int  SaveSoftImageToPng( string  FilePath, int  SIHandle, int  CompressionLevel)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveSoftImageToPng_x86( FilePath , SIHandle , CompressionLevel );
			}
			else
			{
				return dx_SaveSoftImageToPng_x64( FilePath , SIHandle , CompressionLevel );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveSoftImageToJpeg")]
		extern static int  dx_SaveSoftImageToJpeg_x86( string  FilePath, int  SIHandle, int  Quality, int  Sample2x1);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SaveSoftImageToJpeg")]
		extern static int  dx_SaveSoftImageToJpeg_x64( string  FilePath, int  SIHandle, int  Quality, int  Sample2x1);
		public static int  SaveSoftImageToJpeg( string  FilePath, int  SIHandle, int  Quality, int  Sample2x1)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveSoftImageToJpeg_x86( FilePath , SIHandle , Quality , Sample2x1 );
			}
			else
			{
				return dx_SaveSoftImageToJpeg_x64( FilePath , SIHandle , Quality , Sample2x1 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitSoundMem")]
		extern static int  dx_InitSoundMem_x86( int  LogOutFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitSoundMem")]
		extern static int  dx_InitSoundMem_x64( int  LogOutFlag);
		public static int  InitSoundMem( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitSoundMem_x86( FALSE );
			}
			else
			{
				return dx_InitSoundMem_x64( FALSE );
			}
		}
		public static int  InitSoundMem( int  LogOutFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitSoundMem_x86( LogOutFlag );
			}
			else
			{
				return dx_InitSoundMem_x64( LogOutFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddSoundData")]
		extern static int  dx_AddSoundData_x86( int  Handle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddSoundData")]
		extern static int  dx_AddSoundData_x64( int  Handle);
		public static int  AddSoundData( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddSoundData_x86( -1 );
			}
			else
			{
				return dx_AddSoundData_x64( -1 );
			}
		}
		public static int  AddSoundData( int  Handle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddSoundData_x86( Handle );
			}
			else
			{
				return dx_AddSoundData_x64( Handle );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_AddStreamSoundMemToMem")]
		extern unsafe static int  dx_AddStreamSoundMemToMem_x86( void *  FileImage, int  FileImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddStreamSoundMemToMem")]
		extern unsafe static int  dx_AddStreamSoundMemToMem_x64( void *  FileImage, int  FileImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle);
		public unsafe static int  AddStreamSoundMemToMem( void *  FileImage, int  FileImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddStreamSoundMemToMem_x86( FileImage , FileImageSize , LoopNum , SoundHandle , StreamDataType , -1 );
			}
			else
			{
				return dx_AddStreamSoundMemToMem_x64( FileImage , FileImageSize , LoopNum , SoundHandle , StreamDataType , -1 );
			}
		}
		public unsafe static int  AddStreamSoundMemToMem( void *  FileImage, int  FileImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddStreamSoundMemToMem_x86( FileImage , FileImageSize , LoopNum , SoundHandle , StreamDataType , UnionHandle );
			}
			else
			{
				return dx_AddStreamSoundMemToMem_x64( FileImage , FileImageSize , LoopNum , SoundHandle , StreamDataType , UnionHandle );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_AddStreamSoundMemToFile")]
		extern static int  dx_AddStreamSoundMemToFile_x86( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddStreamSoundMemToFile")]
		extern static int  dx_AddStreamSoundMemToFile_x64( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle);
		public static int  AddStreamSoundMemToFile( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddStreamSoundMemToFile_x86( WaveFile , LoopNum , SoundHandle , StreamDataType , -1 );
			}
			else
			{
				return dx_AddStreamSoundMemToFile_x64( WaveFile , LoopNum , SoundHandle , StreamDataType , -1 );
			}
		}
		public static int  AddStreamSoundMemToFile( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddStreamSoundMemToFile_x86( WaveFile , LoopNum , SoundHandle , StreamDataType , UnionHandle );
			}
			else
			{
				return dx_AddStreamSoundMemToFile_x64( WaveFile , LoopNum , SoundHandle , StreamDataType , UnionHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetupStreamSoundMem")]
		extern static int  dx_SetupStreamSoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetupStreamSoundMem")]
		extern static int  dx_SetupStreamSoundMem_x64( int  SoundHandle);
		public static int  SetupStreamSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetupStreamSoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_SetupStreamSoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayStreamSoundMem")]
		extern static int  dx_PlayStreamSoundMem_x86( int  SoundHandle, int  PlayType, int  TopPositionFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlayStreamSoundMem")]
		extern static int  dx_PlayStreamSoundMem_x64( int  SoundHandle, int  PlayType, int  TopPositionFlag);
		public static int  PlayStreamSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayStreamSoundMem_x86( SoundHandle , DX_PLAYTYPE_LOOP , TRUE );
			}
			else
			{
				return dx_PlayStreamSoundMem_x64( SoundHandle , DX_PLAYTYPE_LOOP , TRUE );
			}
		}
		public static int  PlayStreamSoundMem( int  SoundHandle, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayStreamSoundMem_x86( SoundHandle , PlayType , TRUE );
			}
			else
			{
				return dx_PlayStreamSoundMem_x64( SoundHandle , PlayType , TRUE );
			}
		}
		public static int  PlayStreamSoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayStreamSoundMem_x86( SoundHandle , PlayType , TopPositionFlag );
			}
			else
			{
				return dx_PlayStreamSoundMem_x64( SoundHandle , PlayType , TopPositionFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckStreamSoundMem")]
		extern static int  dx_CheckStreamSoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckStreamSoundMem")]
		extern static int  dx_CheckStreamSoundMem_x64( int  SoundHandle);
		public static int  CheckStreamSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckStreamSoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_CheckStreamSoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopStreamSoundMem")]
		extern static int  dx_StopStreamSoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StopStreamSoundMem")]
		extern static int  dx_StopStreamSoundMem_x64( int  SoundHandle);
		public static int  StopStreamSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StopStreamSoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_StopStreamSoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetStreamSoundCurrentPosition")]
		extern static int  dx_SetStreamSoundCurrentPosition_x86( int  Byte, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetStreamSoundCurrentPosition")]
		extern static int  dx_SetStreamSoundCurrentPosition_x64( int  Byte, int  SoundHandle);
		public static int  SetStreamSoundCurrentPosition( int  Byte, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetStreamSoundCurrentPosition_x86( Byte , SoundHandle );
			}
			else
			{
				return dx_SetStreamSoundCurrentPosition_x64( Byte , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStreamSoundCurrentPosition")]
		extern static int  dx_GetStreamSoundCurrentPosition_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetStreamSoundCurrentPosition")]
		extern static int  dx_GetStreamSoundCurrentPosition_x64( int  SoundHandle);
		public static int  GetStreamSoundCurrentPosition( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetStreamSoundCurrentPosition_x86( SoundHandle );
			}
			else
			{
				return dx_GetStreamSoundCurrentPosition_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetStreamSoundCurrentTime")]
		extern static int  dx_SetStreamSoundCurrentTime_x86( int  Time, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetStreamSoundCurrentTime")]
		extern static int  dx_SetStreamSoundCurrentTime_x64( int  Time, int  SoundHandle);
		public static int  SetStreamSoundCurrentTime( int  Time, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetStreamSoundCurrentTime_x86( Time , SoundHandle );
			}
			else
			{
				return dx_SetStreamSoundCurrentTime_x64( Time , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStreamSoundCurrentTime")]
		extern static int  dx_GetStreamSoundCurrentTime_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetStreamSoundCurrentTime")]
		extern static int  dx_GetStreamSoundCurrentTime_x64( int  SoundHandle);
		public static int  GetStreamSoundCurrentTime( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetStreamSoundCurrentTime_x86( SoundHandle );
			}
			else
			{
				return dx_GetStreamSoundCurrentTime_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessStreamSoundMem")]
		extern static int  dx_ProcessStreamSoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ProcessStreamSoundMem")]
		extern static int  dx_ProcessStreamSoundMem_x64( int  SoundHandle);
		public static int  ProcessStreamSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ProcessStreamSoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_ProcessStreamSoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessStreamSoundMemAll")]
		extern static int  dx_ProcessStreamSoundMemAll_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ProcessStreamSoundMemAll")]
		extern static int  dx_ProcessStreamSoundMemAll_x64( );
		public static int  ProcessStreamSoundMemAll( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ProcessStreamSoundMemAll_x86( );
			}
			else
			{
				return dx_ProcessStreamSoundMemAll_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMem2")]
		extern static int  dx_LoadSoundMem2_x86( string  FileName1, string  FileName2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMem2")]
		extern static int  dx_LoadSoundMem2_x64( string  FileName1, string  FileName2);
		public static int  LoadSoundMem2( string  FileName1, string  FileName2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMem2_x86( FileName1 , FileName2 );
			}
			else
			{
				return dx_LoadSoundMem2_x64( FileName1 , FileName2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadBGM")]
		extern static int  dx_LoadBGM_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadBGM")]
		extern static int  dx_LoadBGM_x64( string  FileName);
		public static int  LoadBGM( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadBGM_x86( FileName );
			}
			else
			{
				return dx_LoadBGM_x64( FileName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemBase")]
		extern static int  dx_LoadSoundMemBase_x86( string  FileName, int  BufferNum, int  UnionHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMemBase")]
		extern static int  dx_LoadSoundMemBase_x64( string  FileName, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMemBase( string  FileName, int  BufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemBase_x86( FileName , BufferNum , -1 );
			}
			else
			{
				return dx_LoadSoundMemBase_x64( FileName , BufferNum , -1 );
			}
		}
		public static int  LoadSoundMemBase( string  FileName, int  BufferNum, int  UnionHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemBase_x86( FileName , BufferNum , UnionHandle );
			}
			else
			{
				return dx_LoadSoundMemBase_x64( FileName , BufferNum , UnionHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMem")]
		extern static int  dx_LoadSoundMem_x86( string  FileName, int  BufferNum, int  UnionHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMem")]
		extern static int  dx_LoadSoundMem_x64( string  FileName, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMem( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMem_x86( FileName , 3 , -1 );
			}
			else
			{
				return dx_LoadSoundMem_x64( FileName , 3 , -1 );
			}
		}
		public static int  LoadSoundMem( string  FileName, int  BufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMem_x86( FileName , BufferNum , -1 );
			}
			else
			{
				return dx_LoadSoundMem_x64( FileName , BufferNum , -1 );
			}
		}
		public static int  LoadSoundMem( string  FileName, int  BufferNum, int  UnionHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMem_x86( FileName , BufferNum , UnionHandle );
			}
			else
			{
				return dx_LoadSoundMem_x64( FileName , BufferNum , UnionHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemToBufNumSitei")]
		extern static int  dx_LoadSoundMemToBufNumSitei_x86( string  FileName, int  BufferNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMemToBufNumSitei")]
		extern static int  dx_LoadSoundMemToBufNumSitei_x64( string  FileName, int  BufferNum);
		public static int  LoadSoundMemToBufNumSitei( string  FileName, int  BufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemToBufNumSitei_x86( FileName , BufferNum );
			}
			else
			{
				return dx_LoadSoundMemToBufNumSitei_x64( FileName , BufferNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemByResource")]
		extern static int  dx_LoadSoundMemByResource_x86( string  ResourceName, string  ResourceType, int  BufferNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMemByResource")]
		extern static int  dx_LoadSoundMemByResource_x64( string  ResourceName, string  ResourceType, int  BufferNum);
		public static int  LoadSoundMemByResource( string  ResourceName, string  ResourceType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemByResource_x86( ResourceName , ResourceType , 1 );
			}
			else
			{
				return dx_LoadSoundMemByResource_x64( ResourceName , ResourceType , 1 );
			}
		}
		public static int  LoadSoundMemByResource( string  ResourceName, string  ResourceType, int  BufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemByResource_x86( ResourceName , ResourceType , BufferNum );
			}
			else
			{
				return dx_LoadSoundMemByResource_x64( ResourceName , ResourceType , BufferNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DuplicateSoundMem")]
		extern static int  dx_DuplicateSoundMem_x86( int  SrcSoundHandle, int  BufferNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DuplicateSoundMem")]
		extern static int  dx_DuplicateSoundMem_x64( int  SrcSoundHandle, int  BufferNum);
		public static int  DuplicateSoundMem( int  SrcSoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DuplicateSoundMem_x86( SrcSoundHandle , 3 );
			}
			else
			{
				return dx_DuplicateSoundMem_x64( SrcSoundHandle , 3 );
			}
		}
		public static int  DuplicateSoundMem( int  SrcSoundHandle, int  BufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DuplicateSoundMem_x86( SrcSoundHandle , BufferNum );
			}
			else
			{
				return dx_DuplicateSoundMem_x64( SrcSoundHandle , BufferNum );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemByMemImageBase")]
		extern unsafe static int  dx_LoadSoundMemByMemImageBase_x86( void *  FileImage, int  FileImageSize, int  BufferNum, int  UnionHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMemByMemImageBase")]
		extern unsafe static int  dx_LoadSoundMemByMemImageBase_x64( void *  FileImage, int  FileImageSize, int  BufferNum, int  UnionHandle);
		public unsafe static int  LoadSoundMemByMemImageBase( void *  FileImage, int  FileImageSize, int  BufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemByMemImageBase_x86( FileImage , FileImageSize , BufferNum , -1 );
			}
			else
			{
				return dx_LoadSoundMemByMemImageBase_x64( FileImage , FileImageSize , BufferNum , -1 );
			}
		}
		public unsafe static int  LoadSoundMemByMemImageBase( void *  FileImage, int  FileImageSize, int  BufferNum, int  UnionHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemByMemImageBase_x86( FileImage , FileImageSize , BufferNum , UnionHandle );
			}
			else
			{
				return dx_LoadSoundMemByMemImageBase_x64( FileImage , FileImageSize , BufferNum , UnionHandle );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemByMemImage")]
		extern unsafe static int  dx_LoadSoundMemByMemImage_x86( void *  FileImage, int  FileImageSize, int  UnionHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMemByMemImage")]
		extern unsafe static int  dx_LoadSoundMemByMemImage_x64( void *  FileImage, int  FileImageSize, int  UnionHandle);
		public unsafe static int  LoadSoundMemByMemImage( void *  FileImage, int  FileImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemByMemImage_x86( FileImage , FileImageSize , -1 );
			}
			else
			{
				return dx_LoadSoundMemByMemImage_x64( FileImage , FileImageSize , -1 );
			}
		}
		public unsafe static int  LoadSoundMemByMemImage( void *  FileImage, int  FileImageSize, int  UnionHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemByMemImage_x86( FileImage , FileImageSize , UnionHandle );
			}
			else
			{
				return dx_LoadSoundMemByMemImage_x64( FileImage , FileImageSize , UnionHandle );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemByMemImageToBufNumSitei")]
		extern unsafe static int  dx_LoadSoundMemByMemImageToBufNumSitei_x86( void *  FileImage, int  FileImageSize, int  BufferNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMemByMemImageToBufNumSitei")]
		extern unsafe static int  dx_LoadSoundMemByMemImageToBufNumSitei_x64( void *  FileImage, int  FileImageSize, int  BufferNum);
		public unsafe static int  LoadSoundMemByMemImageToBufNumSitei( void *  FileImage, int  FileImageSize, int  BufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemByMemImageToBufNumSitei_x86( FileImage , FileImageSize , BufferNum );
			}
			else
			{
				return dx_LoadSoundMemByMemImageToBufNumSitei_x64( FileImage , FileImageSize , BufferNum );
			}
		}
#endif

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMem2ByMemImage")]
		extern unsafe static int  dx_LoadSoundMem2ByMemImage_x86( void *  FileImage1, int  FileImageSize1, void *  FileImage2, int  FileImageSize2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMem2ByMemImage")]
		extern unsafe static int  dx_LoadSoundMem2ByMemImage_x64( void *  FileImage1, int  FileImageSize1, void *  FileImage2, int  FileImageSize2);
		public unsafe static int  LoadSoundMem2ByMemImage( void *  FileImage1, int  FileImageSize1, void *  FileImage2, int  FileImageSize2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMem2ByMemImage_x86( FileImage1 , FileImageSize1 , FileImage2 , FileImageSize2 );
			}
			else
			{
				return dx_LoadSoundMem2ByMemImage_x64( FileImage1 , FileImageSize1 , FileImage2 , FileImageSize2 );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoundMemFromSoftSound")]
		extern static int  dx_LoadSoundMemFromSoftSound_x86( int  SoftSoundHandle, int  BufferNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoundMemFromSoftSound")]
		extern static int  dx_LoadSoundMemFromSoftSound_x64( int  SoftSoundHandle, int  BufferNum);
		public static int  LoadSoundMemFromSoftSound( int  SoftSoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemFromSoftSound_x86( SoftSoundHandle , 3 );
			}
			else
			{
				return dx_LoadSoundMemFromSoftSound_x64( SoftSoundHandle , 3 );
			}
		}
		public static int  LoadSoundMemFromSoftSound( int  SoftSoundHandle, int  BufferNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoundMemFromSoftSound_x86( SoftSoundHandle , BufferNum );
			}
			else
			{
				return dx_LoadSoundMemFromSoftSound_x64( SoftSoundHandle , BufferNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSoundMem")]
		extern static int  dx_DeleteSoundMem_x86( int  SoundHandle, int  LogOutFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteSoundMem")]
		extern static int  dx_DeleteSoundMem_x64( int  SoundHandle, int  LogOutFlag);
		public static int  DeleteSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteSoundMem_x86( SoundHandle , FALSE );
			}
			else
			{
				return dx_DeleteSoundMem_x64( SoundHandle , FALSE );
			}
		}
		public static int  DeleteSoundMem( int  SoundHandle, int  LogOutFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteSoundMem_x86( SoundHandle , LogOutFlag );
			}
			else
			{
				return dx_DeleteSoundMem_x64( SoundHandle , LogOutFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlaySoundMem")]
		extern static int  dx_PlaySoundMem_x86( int  SoundHandle, int  PlayType, int  TopPositionFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlaySoundMem")]
		extern static int  dx_PlaySoundMem_x64( int  SoundHandle, int  PlayType, int  TopPositionFlag);
		public static int  PlaySoundMem( int  SoundHandle, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlaySoundMem_x86( SoundHandle , PlayType , TRUE );
			}
			else
			{
				return dx_PlaySoundMem_x64( SoundHandle , PlayType , TRUE );
			}
		}
		public static int  PlaySoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlaySoundMem_x86( SoundHandle , PlayType , TopPositionFlag );
			}
			else
			{
				return dx_PlaySoundMem_x64( SoundHandle , PlayType , TopPositionFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopSoundMem")]
		extern static int  dx_StopSoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StopSoundMem")]
		extern static int  dx_StopSoundMem_x64( int  SoundHandle);
		public static int  StopSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StopSoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_StopSoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckSoundMem")]
		extern static int  dx_CheckSoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckSoundMem")]
		extern static int  dx_CheckSoundMem_x64( int  SoundHandle);
		public static int  CheckSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckSoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_CheckSoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetPanSoundMem")]
		extern static int  dx_SetPanSoundMem_x86( int  PanPal, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetPanSoundMem")]
		extern static int  dx_SetPanSoundMem_x64( int  PanPal, int  SoundHandle);
		public static int  SetPanSoundMem( int  PanPal, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetPanSoundMem_x86( PanPal , SoundHandle );
			}
			else
			{
				return dx_SetPanSoundMem_x64( PanPal , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetPanSoundMem")]
		extern static int  dx_GetPanSoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetPanSoundMem")]
		extern static int  dx_GetPanSoundMem_x64( int  SoundHandle);
		public static int  GetPanSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetPanSoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_GetPanSoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVolumeSoundMem")]
		extern static int  dx_SetVolumeSoundMem_x86( int  VolumePal, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVolumeSoundMem")]
		extern static int  dx_SetVolumeSoundMem_x64( int  VolumePal, int  SoundHandle);
		public static int  SetVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVolumeSoundMem_x86( VolumePal , SoundHandle );
			}
			else
			{
				return dx_SetVolumeSoundMem_x64( VolumePal , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeVolumeSoundMem")]
		extern static int  dx_ChangeVolumeSoundMem_x86( int  VolumePal, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ChangeVolumeSoundMem")]
		extern static int  dx_ChangeVolumeSoundMem_x64( int  VolumePal, int  SoundHandle);
		public static int  ChangeVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeVolumeSoundMem_x86( VolumePal , SoundHandle );
			}
			else
			{
				return dx_ChangeVolumeSoundMem_x64( VolumePal , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetVolumeSoundMem")]
		extern static int  dx_GetVolumeSoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetVolumeSoundMem")]
		extern static int  dx_GetVolumeSoundMem_x64( int  SoundHandle);
		public static int  GetVolumeSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetVolumeSoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_GetVolumeSoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetFrequencySoundMem")]
		extern static int  dx_SetFrequencySoundMem_x86( int  FrequencyPal, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetFrequencySoundMem")]
		extern static int  dx_SetFrequencySoundMem_x64( int  FrequencyPal, int  SoundHandle);
		public static int  SetFrequencySoundMem( int  FrequencyPal, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetFrequencySoundMem_x86( FrequencyPal , SoundHandle );
			}
			else
			{
				return dx_SetFrequencySoundMem_x64( FrequencyPal , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetFrequencySoundMem")]
		extern static int  dx_GetFrequencySoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetFrequencySoundMem")]
		extern static int  dx_GetFrequencySoundMem_x64( int  SoundHandle);
		public static int  GetFrequencySoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetFrequencySoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_GetFrequencySoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetFrequencySoundMem")]
		extern static int  dx_ResetFrequencySoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetFrequencySoundMem")]
		extern static int  dx_ResetFrequencySoundMem_x64( int  SoundHandle);
		public static int  ResetFrequencySoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetFrequencySoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_ResetFrequencySoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNextPlayPanSoundMem")]
		extern static int  dx_SetNextPlayPanSoundMem_x86( int  PanPal, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetNextPlayPanSoundMem")]
		extern static int  dx_SetNextPlayPanSoundMem_x64( int  PanPal, int  SoundHandle);
		public static int  SetNextPlayPanSoundMem( int  PanPal, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetNextPlayPanSoundMem_x86( PanPal , SoundHandle );
			}
			else
			{
				return dx_SetNextPlayPanSoundMem_x64( PanPal , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNextPlayVolumeSoundMem")]
		extern static int  dx_SetNextPlayVolumeSoundMem_x86( int  VolumePal, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetNextPlayVolumeSoundMem")]
		extern static int  dx_SetNextPlayVolumeSoundMem_x64( int  VolumePal, int  SoundHandle);
		public static int  SetNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetNextPlayVolumeSoundMem_x86( VolumePal , SoundHandle );
			}
			else
			{
				return dx_SetNextPlayVolumeSoundMem_x64( VolumePal , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ChangeNextPlayVolumeSoundMem")]
		extern static int  dx_ChangeNextPlayVolumeSoundMem_x86( int  VolumePal, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ChangeNextPlayVolumeSoundMem")]
		extern static int  dx_ChangeNextPlayVolumeSoundMem_x64( int  VolumePal, int  SoundHandle);
		public static int  ChangeNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ChangeNextPlayVolumeSoundMem_x86( VolumePal , SoundHandle );
			}
			else
			{
				return dx_ChangeNextPlayVolumeSoundMem_x64( VolumePal , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetNextPlayFrequencySoundMem")]
		extern static int  dx_SetNextPlayFrequencySoundMem_x86( int  FrequencyPal, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetNextPlayFrequencySoundMem")]
		extern static int  dx_SetNextPlayFrequencySoundMem_x64( int  FrequencyPal, int  SoundHandle);
		public static int  SetNextPlayFrequencySoundMem( int  FrequencyPal, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetNextPlayFrequencySoundMem_x86( FrequencyPal , SoundHandle );
			}
			else
			{
				return dx_SetNextPlayFrequencySoundMem_x64( FrequencyPal , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCurrentPositionSoundMem")]
		extern static int  dx_SetCurrentPositionSoundMem_x86( int  SamplePosition, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCurrentPositionSoundMem")]
		extern static int  dx_SetCurrentPositionSoundMem_x64( int  SamplePosition, int  SoundHandle);
		public static int  SetCurrentPositionSoundMem( int  SamplePosition, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCurrentPositionSoundMem_x86( SamplePosition , SoundHandle );
			}
			else
			{
				return dx_SetCurrentPositionSoundMem_x64( SamplePosition , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCurrentPositionSoundMem")]
		extern static int  dx_GetCurrentPositionSoundMem_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCurrentPositionSoundMem")]
		extern static int  dx_GetCurrentPositionSoundMem_x64( int  SoundHandle);
		public static int  GetCurrentPositionSoundMem( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCurrentPositionSoundMem_x86( SoundHandle );
			}
			else
			{
				return dx_GetCurrentPositionSoundMem_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetSoundCurrentPosition")]
		extern static int  dx_SetSoundCurrentPosition_x86( int  Byte, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetSoundCurrentPosition")]
		extern static int  dx_SetSoundCurrentPosition_x64( int  Byte, int  SoundHandle);
		public static int  SetSoundCurrentPosition( int  Byte, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetSoundCurrentPosition_x86( Byte , SoundHandle );
			}
			else
			{
				return dx_SetSoundCurrentPosition_x64( Byte , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoundCurrentPosition")]
		extern static int  dx_GetSoundCurrentPosition_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetSoundCurrentPosition")]
		extern static int  dx_GetSoundCurrentPosition_x64( int  SoundHandle);
		public static int  GetSoundCurrentPosition( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetSoundCurrentPosition_x86( SoundHandle );
			}
			else
			{
				return dx_GetSoundCurrentPosition_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetSoundCurrentTime")]
		extern static int  dx_SetSoundCurrentTime_x86( int  Time, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetSoundCurrentTime")]
		extern static int  dx_SetSoundCurrentTime_x64( int  Time, int  SoundHandle);
		public static int  SetSoundCurrentTime( int  Time, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetSoundCurrentTime_x86( Time , SoundHandle );
			}
			else
			{
				return dx_SetSoundCurrentTime_x64( Time , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoundCurrentTime")]
		extern static int  dx_GetSoundCurrentTime_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetSoundCurrentTime")]
		extern static int  dx_GetSoundCurrentTime_x64( int  SoundHandle);
		public static int  GetSoundCurrentTime( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetSoundCurrentTime_x86( SoundHandle );
			}
			else
			{
				return dx_GetSoundCurrentTime_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoundTotalSample")]
		extern static int  dx_GetSoundTotalSample_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetSoundTotalSample")]
		extern static int  dx_GetSoundTotalSample_x64( int  SoundHandle);
		public static int  GetSoundTotalSample( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetSoundTotalSample_x86( SoundHandle );
			}
			else
			{
				return dx_GetSoundTotalSample_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoundTotalTime")]
		extern static int  dx_GetSoundTotalTime_x86( int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetSoundTotalTime")]
		extern static int  dx_GetSoundTotalTime_x64( int  SoundHandle);
		public static int  GetSoundTotalTime( int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetSoundTotalTime_x86( SoundHandle );
			}
			else
			{
				return dx_GetSoundTotalTime_x64( SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopPosSoundMem")]
		extern static int  dx_SetLoopPosSoundMem_x86( int  LoopTime, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLoopPosSoundMem")]
		extern static int  dx_SetLoopPosSoundMem_x64( int  LoopTime, int  SoundHandle);
		public static int  SetLoopPosSoundMem( int  LoopTime, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLoopPosSoundMem_x86( LoopTime , SoundHandle );
			}
			else
			{
				return dx_SetLoopPosSoundMem_x64( LoopTime , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopTimePosSoundMem")]
		extern static int  dx_SetLoopTimePosSoundMem_x86( int  LoopTime, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLoopTimePosSoundMem")]
		extern static int  dx_SetLoopTimePosSoundMem_x64( int  LoopTime, int  SoundHandle);
		public static int  SetLoopTimePosSoundMem( int  LoopTime, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLoopTimePosSoundMem_x86( LoopTime , SoundHandle );
			}
			else
			{
				return dx_SetLoopTimePosSoundMem_x64( LoopTime , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopSamplePosSoundMem")]
		extern static int  dx_SetLoopSamplePosSoundMem_x86( int  LoopSamplePosition, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLoopSamplePosSoundMem")]
		extern static int  dx_SetLoopSamplePosSoundMem_x64( int  LoopSamplePosition, int  SoundHandle);
		public static int  SetLoopSamplePosSoundMem( int  LoopSamplePosition, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLoopSamplePosSoundMem_x86( LoopSamplePosition , SoundHandle );
			}
			else
			{
				return dx_SetLoopSamplePosSoundMem_x64( LoopSamplePosition , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopStartTimePosSoundMem")]
		extern static int  dx_SetLoopStartTimePosSoundMem_x86( int  LoopStartTime, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLoopStartTimePosSoundMem")]
		extern static int  dx_SetLoopStartTimePosSoundMem_x64( int  LoopStartTime, int  SoundHandle);
		public static int  SetLoopStartTimePosSoundMem( int  LoopStartTime, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLoopStartTimePosSoundMem_x86( LoopStartTime , SoundHandle );
			}
			else
			{
				return dx_SetLoopStartTimePosSoundMem_x64( LoopStartTime , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetLoopStartSamplePosSoundMem")]
		extern static int  dx_SetLoopStartSamplePosSoundMem_x86( int  LoopStartSamplePosition, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetLoopStartSamplePosSoundMem")]
		extern static int  dx_SetLoopStartSamplePosSoundMem_x64( int  LoopStartSamplePosition, int  SoundHandle);
		public static int  SetLoopStartSamplePosSoundMem( int  LoopStartSamplePosition, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetLoopStartSamplePosSoundMem_x86( LoopStartSamplePosition , SoundHandle );
			}
			else
			{
				return dx_SetLoopStartSamplePosSoundMem_x64( LoopStartSamplePosition , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set3DPositionSoundMem")]
		extern static int  dx_Set3DPositionSoundMem_x86( VECTOR  Position, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Set3DPositionSoundMem")]
		extern static int  dx_Set3DPositionSoundMem_x64( VECTOR  Position, int  SoundHandle);
		public static int  Set3DPositionSoundMem( VECTOR  Position, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Set3DPositionSoundMem_x86( Position , SoundHandle );
			}
			else
			{
				return dx_Set3DPositionSoundMem_x64( Position , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set3DRadiusSoundMem")]
		extern static int  dx_Set3DRadiusSoundMem_x86( float  Radius, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Set3DRadiusSoundMem")]
		extern static int  dx_Set3DRadiusSoundMem_x64( float  Radius, int  SoundHandle);
		public static int  Set3DRadiusSoundMem( float  Radius, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Set3DRadiusSoundMem_x86( Radius , SoundHandle );
			}
			else
			{
				return dx_Set3DRadiusSoundMem_x64( Radius , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set3DVelocitySoundMem")]
		extern static int  dx_Set3DVelocitySoundMem_x86( VECTOR  Velocity, int  SoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Set3DVelocitySoundMem")]
		extern static int  dx_Set3DVelocitySoundMem_x64( VECTOR  Velocity, int  SoundHandle);
		public static int  Set3DVelocitySoundMem( VECTOR  Velocity, int  SoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Set3DVelocitySoundMem_x86( Velocity , SoundHandle );
			}
			else
			{
				return dx_Set3DVelocitySoundMem_x64( Velocity , SoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCreateSoundDataType")]
		extern static int  dx_SetCreateSoundDataType_x86( int  SoundDataType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCreateSoundDataType")]
		extern static int  dx_SetCreateSoundDataType_x64( int  SoundDataType);
		public static int  SetCreateSoundDataType( int  SoundDataType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCreateSoundDataType_x86( SoundDataType );
			}
			else
			{
				return dx_SetCreateSoundDataType_x64( SoundDataType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetCreateSoundDataType")]
		extern static int  dx_GetCreateSoundDataType_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetCreateSoundDataType")]
		extern static int  dx_GetCreateSoundDataType_x64( );
		public static int  GetCreateSoundDataType( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetCreateSoundDataType_x86( );
			}
			else
			{
				return dx_GetCreateSoundDataType_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDisableReadSoundFunctionMask")]
		extern static int  dx_SetDisableReadSoundFunctionMask_x86( int  Mask);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDisableReadSoundFunctionMask")]
		extern static int  dx_SetDisableReadSoundFunctionMask_x64( int  Mask);
		public static int  SetDisableReadSoundFunctionMask( int  Mask)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDisableReadSoundFunctionMask_x86( Mask );
			}
			else
			{
				return dx_SetDisableReadSoundFunctionMask_x64( Mask );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetDisableReadSoundFunctionMask")]
		extern static int  dx_GetDisableReadSoundFunctionMask_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDisableReadSoundFunctionMask")]
		extern static int  dx_GetDisableReadSoundFunctionMask_x64( );
		public static int  GetDisableReadSoundFunctionMask( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDisableReadSoundFunctionMask_x86( );
			}
			else
			{
				return dx_GetDisableReadSoundFunctionMask_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetEnableSoundCaptureFlag")]
		extern static int  dx_SetEnableSoundCaptureFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetEnableSoundCaptureFlag")]
		extern static int  dx_SetEnableSoundCaptureFlag_x64( int  Flag);
		public static int  SetEnableSoundCaptureFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetEnableSoundCaptureFlag_x86( Flag );
			}
			else
			{
				return dx_SetEnableSoundCaptureFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseSoftwareMixingSoundFlag")]
		extern static int  dx_SetUseSoftwareMixingSoundFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseSoftwareMixingSoundFlag")]
		extern static int  dx_SetUseSoftwareMixingSoundFlag_x64( int  Flag);
		public static int  SetUseSoftwareMixingSoundFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseSoftwareMixingSoundFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseSoftwareMixingSoundFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetEnableXAudioFlag")]
		extern static int  dx_SetEnableXAudioFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetEnableXAudioFlag")]
		extern static int  dx_SetEnableXAudioFlag_x64( int  Flag);
		public static int  SetEnableXAudioFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetEnableXAudioFlag_x86( Flag );
			}
			else
			{
				return dx_SetEnableXAudioFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetCreate3DSoundFlag")]
		extern static int  dx_SetCreate3DSoundFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetCreate3DSoundFlag")]
		extern static int  dx_SetCreate3DSoundFlag_x64( int  Flag);
		public static int  SetCreate3DSoundFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetCreate3DSoundFlag_x86( Flag );
			}
			else
			{
				return dx_SetCreate3DSoundFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set3DSoundOneMetre")]
		extern static int  dx_Set3DSoundOneMetre_x86( float  Distance);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Set3DSoundOneMetre")]
		extern static int  dx_Set3DSoundOneMetre_x64( float  Distance);
		public static int  Set3DSoundOneMetre( float  Distance)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Set3DSoundOneMetre_x86( Distance );
			}
			else
			{
				return dx_Set3DSoundOneMetre_x64( Distance );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set3DSoundListenerPosAndFrontPos_UpVecY")]
		extern static int  dx_Set3DSoundListenerPosAndFrontPos_UpVecY_x86( VECTOR  Position, VECTOR  FrontPosition);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Set3DSoundListenerPosAndFrontPos_UpVecY")]
		extern static int  dx_Set3DSoundListenerPosAndFrontPos_UpVecY_x64( VECTOR  Position, VECTOR  FrontPosition);
		public static int  Set3DSoundListenerPosAndFrontPos_UpVecY( VECTOR  Position, VECTOR  FrontPosition)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Set3DSoundListenerPosAndFrontPos_UpVecY_x86( Position , FrontPosition );
			}
			else
			{
				return dx_Set3DSoundListenerPosAndFrontPos_UpVecY_x64( Position , FrontPosition );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set3DSoundListenerPosAndFrontPos")]
		extern static int  dx_Set3DSoundListenerPosAndFrontPos_x86( VECTOR  Position, VECTOR  FrontPosition, VECTOR  UpVector);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Set3DSoundListenerPosAndFrontPos")]
		extern static int  dx_Set3DSoundListenerPosAndFrontPos_x64( VECTOR  Position, VECTOR  FrontPosition, VECTOR  UpVector);
		public static int  Set3DSoundListenerPosAndFrontPos( VECTOR  Position, VECTOR  FrontPosition, VECTOR  UpVector)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Set3DSoundListenerPosAndFrontPos_x86( Position , FrontPosition , UpVector );
			}
			else
			{
				return dx_Set3DSoundListenerPosAndFrontPos_x64( Position , FrontPosition , UpVector );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set3DSoundListenerVelocity")]
		extern static int  dx_Set3DSoundListenerVelocity_x86( VECTOR  Velocity);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Set3DSoundListenerVelocity")]
		extern static int  dx_Set3DSoundListenerVelocity_x64( VECTOR  Velocity);
		public static int  Set3DSoundListenerVelocity( VECTOR  Velocity)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Set3DSoundListenerVelocity_x86( Velocity );
			}
			else
			{
				return dx_Set3DSoundListenerVelocity_x64( Velocity );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set3DSoundListenerConeAngle")]
		extern static int  dx_Set3DSoundListenerConeAngle_x86( float  InnerAngle, float  OuterAngle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Set3DSoundListenerConeAngle")]
		extern static int  dx_Set3DSoundListenerConeAngle_x64( float  InnerAngle, float  OuterAngle);
		public static int  Set3DSoundListenerConeAngle( float  InnerAngle, float  OuterAngle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Set3DSoundListenerConeAngle_x86( InnerAngle , OuterAngle );
			}
			else
			{
				return dx_Set3DSoundListenerConeAngle_x64( InnerAngle , OuterAngle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_Set3DSoundListenerConeVolume")]
		extern static int  dx_Set3DSoundListenerConeVolume_x86( float  InnerAngleVolume, float  OuterAngleVolume);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_Set3DSoundListenerConeVolume")]
		extern static int  dx_Set3DSoundListenerConeVolume_x64( float  InnerAngleVolume, float  OuterAngleVolume);
		public static int  Set3DSoundListenerConeVolume( float  InnerAngleVolume, float  OuterAngleVolume)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_Set3DSoundListenerConeVolume_x86( InnerAngleVolume , OuterAngleVolume );
			}
			else
			{
				return dx_Set3DSoundListenerConeVolume_x64( InnerAngleVolume , OuterAngleVolume );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetDSoundObj")]
		extern unsafe static void *  dx_GetDSoundObj_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetDSoundObj")]
		extern unsafe static void *  dx_GetDSoundObj_x64( );
		public unsafe static void *  GetDSoundObj( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetDSoundObj_x86( );
			}
			else
			{
				return dx_GetDSoundObj_x64( );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_PlaySoundFile")]
		extern static int  dx_PlaySoundFile_x86( string  FileName, int  PlayType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlaySoundFile")]
		extern static int  dx_PlaySoundFile_x64( string  FileName, int  PlayType);
		public static int  PlaySoundFile( string  FileName, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlaySoundFile_x86( FileName , PlayType );
			}
			else
			{
				return dx_PlaySoundFile_x64( FileName , PlayType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlaySound")]
		extern static int  dx_PlaySound_x86( string  FileName, int  PlayType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlaySound")]
		extern static int  dx_PlaySound_x64( string  FileName, int  PlayType);
		public static int  PlaySound( string  FileName, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlaySound_x86( FileName , PlayType );
			}
			else
			{
				return dx_PlaySound_x64( FileName , PlayType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckSoundFile")]
		extern static int  dx_CheckSoundFile_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckSoundFile")]
		extern static int  dx_CheckSoundFile_x64( );
		public static int  CheckSoundFile( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckSoundFile_x86( );
			}
			else
			{
				return dx_CheckSoundFile_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckSound")]
		extern static int  dx_CheckSound_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckSound")]
		extern static int  dx_CheckSound_x64( );
		public static int  CheckSound( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckSound_x86( );
			}
			else
			{
				return dx_CheckSound_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopSoundFile")]
		extern static int  dx_StopSoundFile_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StopSoundFile")]
		extern static int  dx_StopSoundFile_x64( );
		public static int  StopSoundFile( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StopSoundFile_x86( );
			}
			else
			{
				return dx_StopSoundFile_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopSound")]
		extern static int  dx_StopSound_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StopSound")]
		extern static int  dx_StopSound_x64( );
		public static int  StopSound( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StopSound_x86( );
			}
			else
			{
				return dx_StopSound_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVolumeSoundFile")]
		extern static int  dx_SetVolumeSoundFile_x86( int  VolumePal);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVolumeSoundFile")]
		extern static int  dx_SetVolumeSoundFile_x64( int  VolumePal);
		public static int  SetVolumeSoundFile( int  VolumePal)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVolumeSoundFile_x86( VolumePal );
			}
			else
			{
				return dx_SetVolumeSoundFile_x64( VolumePal );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVolumeSound")]
		extern static int  dx_SetVolumeSound_x86( int  VolumePal);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVolumeSound")]
		extern static int  dx_SetVolumeSound_x64( int  VolumePal);
		public static int  SetVolumeSound( int  VolumePal)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVolumeSound_x86( VolumePal );
			}
			else
			{
				return dx_SetVolumeSound_x64( VolumePal );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitSoftSound")]
		extern static int  dx_InitSoftSound_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitSoftSound")]
		extern static int  dx_InitSoftSound_x64( );
		public static int  InitSoftSound( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitSoftSound_x86( );
			}
			else
			{
				return dx_InitSoftSound_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoftSound")]
		extern static int  dx_LoadSoftSound_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoftSound")]
		extern static int  dx_LoadSoftSound_x64( string  FileName);
		public static int  LoadSoftSound( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoftSound_x86( FileName );
			}
			else
			{
				return dx_LoadSoftSound_x64( FileName );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadSoftSoundFromMemImage")]
		extern unsafe static int  dx_LoadSoftSoundFromMemImage_x86( void *  FileImage, int  FileImageSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadSoftSoundFromMemImage")]
		extern unsafe static int  dx_LoadSoftSoundFromMemImage_x64( void *  FileImage, int  FileImageSize);
		public unsafe static int  LoadSoftSoundFromMemImage( void *  FileImage, int  FileImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadSoftSoundFromMemImage_x86( FileImage , FileImageSize );
			}
			else
			{
				return dx_LoadSoftSoundFromMemImage_x64( FileImage , FileImageSize );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound")]
		extern static int  dx_MakeSoftSound_x86( int  UseFormat_SoftSoundHandle, int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSound")]
		extern static int  dx_MakeSoftSound_x64( int  UseFormat_SoftSoundHandle, int  SampleNum);
		public static int  MakeSoftSound( int  UseFormat_SoftSoundHandle, int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSound_x86( UseFormat_SoftSoundHandle , SampleNum );
			}
			else
			{
				return dx_MakeSoftSound_x64( UseFormat_SoftSoundHandle , SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound2Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSound2Ch16Bit44KHz_x86( int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSound2Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSound2Ch16Bit44KHz_x64( int  SampleNum);
		public static int  MakeSoftSound2Ch16Bit44KHz( int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSound2Ch16Bit44KHz_x86( SampleNum );
			}
			else
			{
				return dx_MakeSoftSound2Ch16Bit44KHz_x64( SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound2Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSound2Ch16Bit22KHz_x86( int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSound2Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSound2Ch16Bit22KHz_x64( int  SampleNum);
		public static int  MakeSoftSound2Ch16Bit22KHz( int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSound2Ch16Bit22KHz_x86( SampleNum );
			}
			else
			{
				return dx_MakeSoftSound2Ch16Bit22KHz_x64( SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound2Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSound2Ch8Bit44KHz_x86( int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSound2Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSound2Ch8Bit44KHz_x64( int  SampleNum);
		public static int  MakeSoftSound2Ch8Bit44KHz( int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSound2Ch8Bit44KHz_x86( SampleNum );
			}
			else
			{
				return dx_MakeSoftSound2Ch8Bit44KHz_x64( SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound2Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSound2Ch8Bit22KHz_x86( int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSound2Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSound2Ch8Bit22KHz_x64( int  SampleNum);
		public static int  MakeSoftSound2Ch8Bit22KHz( int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSound2Ch8Bit22KHz_x86( SampleNum );
			}
			else
			{
				return dx_MakeSoftSound2Ch8Bit22KHz_x64( SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound1Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSound1Ch16Bit44KHz_x86( int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSound1Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSound1Ch16Bit44KHz_x64( int  SampleNum);
		public static int  MakeSoftSound1Ch16Bit44KHz( int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSound1Ch16Bit44KHz_x86( SampleNum );
			}
			else
			{
				return dx_MakeSoftSound1Ch16Bit44KHz_x64( SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound1Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSound1Ch16Bit22KHz_x86( int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSound1Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSound1Ch16Bit22KHz_x64( int  SampleNum);
		public static int  MakeSoftSound1Ch16Bit22KHz( int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSound1Ch16Bit22KHz_x86( SampleNum );
			}
			else
			{
				return dx_MakeSoftSound1Ch16Bit22KHz_x64( SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound1Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSound1Ch8Bit44KHz_x86( int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSound1Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSound1Ch8Bit44KHz_x64( int  SampleNum);
		public static int  MakeSoftSound1Ch8Bit44KHz( int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSound1Ch8Bit44KHz_x86( SampleNum );
			}
			else
			{
				return dx_MakeSoftSound1Ch8Bit44KHz_x64( SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSound1Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSound1Ch8Bit22KHz_x86( int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSound1Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSound1Ch8Bit22KHz_x64( int  SampleNum);
		public static int  MakeSoftSound1Ch8Bit22KHz( int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSound1Ch8Bit22KHz_x86( SampleNum );
			}
			else
			{
				return dx_MakeSoftSound1Ch8Bit22KHz_x64( SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundCustom")]
		extern static int  dx_MakeSoftSoundCustom_x86( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec, int  SampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundCustom")]
		extern static int  dx_MakeSoftSoundCustom_x64( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec, int  SampleNum);
		public static int  MakeSoftSoundCustom( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec, int  SampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundCustom_x86( ChannelNum , BitsPerSample , SamplesPerSec , SampleNum );
			}
			else
			{
				return dx_MakeSoftSoundCustom_x64( ChannelNum , BitsPerSample , SamplesPerSec , SampleNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSoftSound")]
		extern static int  dx_DeleteSoftSound_x86( int  SoftSoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteSoftSound")]
		extern static int  dx_DeleteSoftSound_x64( int  SoftSoundHandle);
		public static int  DeleteSoftSound( int  SoftSoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteSoftSound_x86( SoftSoundHandle );
			}
			else
			{
				return dx_DeleteSoftSound_x64( SoftSoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SaveSoftSound")]
		extern static int  dx_SaveSoftSound_x86( int  SoftSoundHandle, string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SaveSoftSound")]
		extern static int  dx_SaveSoftSound_x64( int  SoftSoundHandle, string  FileName);
		public static int  SaveSoftSound( int  SoftSoundHandle, string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SaveSoftSound_x86( SoftSoundHandle , FileName );
			}
			else
			{
				return dx_SaveSoftSound_x64( SoftSoundHandle , FileName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftSoundSampleNum")]
		extern static int  dx_GetSoftSoundSampleNum_x86( int  SoftSoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetSoftSoundSampleNum")]
		extern static int  dx_GetSoftSoundSampleNum_x64( int  SoftSoundHandle);
		public static int  GetSoftSoundSampleNum( int  SoftSoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetSoftSoundSampleNum_x86( SoftSoundHandle );
			}
			else
			{
				return dx_GetSoftSoundSampleNum_x64( SoftSoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftSoundFormat")]
		extern static int  dx_GetSoftSoundFormat_x86( int  SoftSoundHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetSoftSoundFormat")]
		extern static int  dx_GetSoftSoundFormat_x64( int  SoftSoundHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec);
		public static int  GetSoftSoundFormat( int  SoftSoundHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetSoftSoundFormat_x86( SoftSoundHandle , out Channels , out BitsPerSample , out SamplesPerSec );
			}
			else
			{
				return dx_GetSoftSoundFormat_x64( SoftSoundHandle , out Channels , out BitsPerSample , out SamplesPerSec );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ReadSoftSoundData")]
		extern static int  dx_ReadSoftSoundData_x86( int  SoftSoundHandle, int  SamplePosition, out int  Channel1, out int  Channel2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ReadSoftSoundData")]
		extern static int  dx_ReadSoftSoundData_x64( int  SoftSoundHandle, int  SamplePosition, out int  Channel1, out int  Channel2);
		public static int  ReadSoftSoundData( int  SoftSoundHandle, int  SamplePosition, out int  Channel1, out int  Channel2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ReadSoftSoundData_x86( SoftSoundHandle , SamplePosition , out Channel1 , out Channel2 );
			}
			else
			{
				return dx_ReadSoftSoundData_x64( SoftSoundHandle , SamplePosition , out Channel1 , out Channel2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_WriteSoftSoundData")]
		extern static int  dx_WriteSoftSoundData_x86( int  SoftSoundHandle, int  SamplePosition, int  Channel1, int  Channel2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_WriteSoftSoundData")]
		extern static int  dx_WriteSoftSoundData_x64( int  SoftSoundHandle, int  SamplePosition, int  Channel1, int  Channel2);
		public static int  WriteSoftSoundData( int  SoftSoundHandle, int  SamplePosition, int  Channel1, int  Channel2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_WriteSoftSoundData_x86( SoftSoundHandle , SamplePosition , Channel1 , Channel2 );
			}
			else
			{
				return dx_WriteSoftSoundData_x64( SoftSoundHandle , SamplePosition , Channel1 , Channel2 );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftSoundDataImage")]
		extern unsafe static void *  dx_GetSoftSoundDataImage_x86( int  SoftSoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetSoftSoundDataImage")]
		extern unsafe static void *  dx_GetSoftSoundDataImage_x64( int  SoftSoundHandle);
		public unsafe static void *  GetSoftSoundDataImage( int  SoftSoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetSoftSoundDataImage_x86( SoftSoundHandle );
			}
			else
			{
				return dx_GetSoftSoundDataImage_x64( SoftSoundHandle );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_InitSoftSoundPlayer")]
		extern static int  dx_InitSoftSoundPlayer_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitSoftSoundPlayer")]
		extern static int  dx_InitSoftSoundPlayer_x64( );
		public static int  InitSoftSoundPlayer( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitSoftSoundPlayer_x86( );
			}
			else
			{
				return dx_InitSoftSoundPlayer_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer")]
		extern static int  dx_MakeSoftSoundPlayer_x86( int  UseFormat_SoftSoundHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayer")]
		extern static int  dx_MakeSoftSoundPlayer_x64( int  UseFormat_SoftSoundHandle);
		public static int  MakeSoftSoundPlayer( int  UseFormat_SoftSoundHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayer_x86( UseFormat_SoftSoundHandle );
			}
			else
			{
				return dx_MakeSoftSoundPlayer_x64( UseFormat_SoftSoundHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch16Bit44KHz_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch16Bit44KHz_x64( );
		public static int  MakeSoftSoundPlayer2Ch16Bit44KHz( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayer2Ch16Bit44KHz_x86( );
			}
			else
			{
				return dx_MakeSoftSoundPlayer2Ch16Bit44KHz_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch16Bit22KHz_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch16Bit22KHz_x64( );
		public static int  MakeSoftSoundPlayer2Ch16Bit22KHz( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayer2Ch16Bit22KHz_x86( );
			}
			else
			{
				return dx_MakeSoftSoundPlayer2Ch16Bit22KHz_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch8Bit44KHz_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch8Bit44KHz_x64( );
		public static int  MakeSoftSoundPlayer2Ch8Bit44KHz( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayer2Ch8Bit44KHz_x86( );
			}
			else
			{
				return dx_MakeSoftSoundPlayer2Ch8Bit44KHz_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch8Bit22KHz_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayer2Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer2Ch8Bit22KHz_x64( );
		public static int  MakeSoftSoundPlayer2Ch8Bit22KHz( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayer2Ch8Bit22KHz_x86( );
			}
			else
			{
				return dx_MakeSoftSoundPlayer2Ch8Bit22KHz_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch16Bit44KHz_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch16Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch16Bit44KHz_x64( );
		public static int  MakeSoftSoundPlayer1Ch16Bit44KHz( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayer1Ch16Bit44KHz_x86( );
			}
			else
			{
				return dx_MakeSoftSoundPlayer1Ch16Bit44KHz_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch16Bit22KHz_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch16Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch16Bit22KHz_x64( );
		public static int  MakeSoftSoundPlayer1Ch16Bit22KHz( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayer1Ch16Bit22KHz_x86( );
			}
			else
			{
				return dx_MakeSoftSoundPlayer1Ch16Bit22KHz_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch8Bit44KHz_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch8Bit44KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch8Bit44KHz_x64( );
		public static int  MakeSoftSoundPlayer1Ch8Bit44KHz( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayer1Ch8Bit44KHz_x86( );
			}
			else
			{
				return dx_MakeSoftSoundPlayer1Ch8Bit44KHz_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch8Bit22KHz_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayer1Ch8Bit22KHz")]
		extern static int  dx_MakeSoftSoundPlayer1Ch8Bit22KHz_x64( );
		public static int  MakeSoftSoundPlayer1Ch8Bit22KHz( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayer1Ch8Bit22KHz_x86( );
			}
			else
			{
				return dx_MakeSoftSoundPlayer1Ch8Bit22KHz_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MakeSoftSoundPlayerCustom")]
		extern static int  dx_MakeSoftSoundPlayerCustom_x86( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MakeSoftSoundPlayerCustom")]
		extern static int  dx_MakeSoftSoundPlayerCustom_x64( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec);
		public static int  MakeSoftSoundPlayerCustom( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MakeSoftSoundPlayerCustom_x86( ChannelNum , BitsPerSample , SamplesPerSec );
			}
			else
			{
				return dx_MakeSoftSoundPlayerCustom_x64( ChannelNum , BitsPerSample , SamplesPerSec );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteSoftSoundPlayer")]
		extern static int  dx_DeleteSoftSoundPlayer_x86( int  SSoundPlayerHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteSoftSoundPlayer")]
		extern static int  dx_DeleteSoftSoundPlayer_x64( int  SSoundPlayerHandle);
		public static int  DeleteSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteSoftSoundPlayer_x86( SSoundPlayerHandle );
			}
			else
			{
				return dx_DeleteSoftSoundPlayer_x64( SSoundPlayerHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_AddDataSoftSoundPlayer")]
		extern static int  dx_AddDataSoftSoundPlayer_x86( int  SSoundPlayerHandle, int  SoftSoundHandle, int  AddSamplePosition, int  AddSampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddDataSoftSoundPlayer")]
		extern static int  dx_AddDataSoftSoundPlayer_x64( int  SSoundPlayerHandle, int  SoftSoundHandle, int  AddSamplePosition, int  AddSampleNum);
		public static int  AddDataSoftSoundPlayer( int  SSoundPlayerHandle, int  SoftSoundHandle, int  AddSamplePosition, int  AddSampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddDataSoftSoundPlayer_x86( SSoundPlayerHandle , SoftSoundHandle , AddSamplePosition , AddSampleNum );
			}
			else
			{
				return dx_AddDataSoftSoundPlayer_x64( SSoundPlayerHandle , SoftSoundHandle , AddSamplePosition , AddSampleNum );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_AddDirectDataSoftSoundPlayer")]
		extern unsafe static int  dx_AddDirectDataSoftSoundPlayer_x86( int  SSoundPlayerHandle, void *  SoundData, int  AddSampleNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddDirectDataSoftSoundPlayer")]
		extern unsafe static int  dx_AddDirectDataSoftSoundPlayer_x64( int  SSoundPlayerHandle, void *  SoundData, int  AddSampleNum);
		public unsafe static int  AddDirectDataSoftSoundPlayer( int  SSoundPlayerHandle, void *  SoundData, int  AddSampleNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddDirectDataSoftSoundPlayer_x86( SSoundPlayerHandle , SoundData , AddSampleNum );
			}
			else
			{
				return dx_AddDirectDataSoftSoundPlayer_x64( SSoundPlayerHandle , SoundData , AddSampleNum );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_AddOneDataSoftSoundPlayer")]
		extern static int  dx_AddOneDataSoftSoundPlayer_x86( int  SSoundPlayerHandle, int  Channel1, int  Channel2);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_AddOneDataSoftSoundPlayer")]
		extern static int  dx_AddOneDataSoftSoundPlayer_x64( int  SSoundPlayerHandle, int  Channel1, int  Channel2);
		public static int  AddOneDataSoftSoundPlayer( int  SSoundPlayerHandle, int  Channel1, int  Channel2)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_AddOneDataSoftSoundPlayer_x86( SSoundPlayerHandle , Channel1 , Channel2 );
			}
			else
			{
				return dx_AddOneDataSoftSoundPlayer_x64( SSoundPlayerHandle , Channel1 , Channel2 );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetSoftSoundPlayerFormat")]
		extern static int  dx_GetSoftSoundPlayerFormat_x86( int  SSoundPlayerHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetSoftSoundPlayerFormat")]
		extern static int  dx_GetSoftSoundPlayerFormat_x64( int  SSoundPlayerHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec);
		public static int  GetSoftSoundPlayerFormat( int  SSoundPlayerHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetSoftSoundPlayerFormat_x86( SSoundPlayerHandle , out Channels , out BitsPerSample , out SamplesPerSec );
			}
			else
			{
				return dx_GetSoftSoundPlayerFormat_x64( SSoundPlayerHandle , out Channels , out BitsPerSample , out SamplesPerSec );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StartSoftSoundPlayer")]
		extern static int  dx_StartSoftSoundPlayer_x86( int  SSoundPlayerHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StartSoftSoundPlayer")]
		extern static int  dx_StartSoftSoundPlayer_x64( int  SSoundPlayerHandle);
		public static int  StartSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StartSoftSoundPlayer_x86( SSoundPlayerHandle );
			}
			else
			{
				return dx_StartSoftSoundPlayer_x64( SSoundPlayerHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckStartSoftSoundPlayer")]
		extern static int  dx_CheckStartSoftSoundPlayer_x86( int  SSoundPlayerHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckStartSoftSoundPlayer")]
		extern static int  dx_CheckStartSoftSoundPlayer_x64( int  SSoundPlayerHandle);
		public static int  CheckStartSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckStartSoftSoundPlayer_x86( SSoundPlayerHandle );
			}
			else
			{
				return dx_CheckStartSoftSoundPlayer_x64( SSoundPlayerHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopSoftSoundPlayer")]
		extern static int  dx_StopSoftSoundPlayer_x86( int  SSoundPlayerHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StopSoftSoundPlayer")]
		extern static int  dx_StopSoftSoundPlayer_x64( int  SSoundPlayerHandle);
		public static int  StopSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StopSoftSoundPlayer_x86( SSoundPlayerHandle );
			}
			else
			{
				return dx_StopSoftSoundPlayer_x64( SSoundPlayerHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ResetSoftSoundPlayer")]
		extern static int  dx_ResetSoftSoundPlayer_x86( int  SSoundPlayerHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ResetSoftSoundPlayer")]
		extern static int  dx_ResetSoftSoundPlayer_x64( int  SSoundPlayerHandle);
		public static int  ResetSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ResetSoftSoundPlayer_x86( SSoundPlayerHandle );
			}
			else
			{
				return dx_ResetSoftSoundPlayer_x64( SSoundPlayerHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetStockDataLengthSoftSoundPlayer")]
		extern static int  dx_GetStockDataLengthSoftSoundPlayer_x86( int  SSoundPlayerHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetStockDataLengthSoftSoundPlayer")]
		extern static int  dx_GetStockDataLengthSoftSoundPlayer_x64( int  SSoundPlayerHandle);
		public static int  GetStockDataLengthSoftSoundPlayer( int  SSoundPlayerHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetStockDataLengthSoftSoundPlayer_x86( SSoundPlayerHandle );
			}
			else
			{
				return dx_GetStockDataLengthSoftSoundPlayer_x64( SSoundPlayerHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckSoftSoundPlayerNoneData")]
		extern static int  dx_CheckSoftSoundPlayerNoneData_x86( int  SSoundPlayerHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckSoftSoundPlayerNoneData")]
		extern static int  dx_CheckSoftSoundPlayerNoneData_x64( int  SSoundPlayerHandle);
		public static int  CheckSoftSoundPlayerNoneData( int  SSoundPlayerHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckSoftSoundPlayerNoneData_x86( SSoundPlayerHandle );
			}
			else
			{
				return dx_CheckSoftSoundPlayerNoneData_x64( SSoundPlayerHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DeleteMusicMem")]
		extern static int  dx_DeleteMusicMem_x86( int  MusicHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DeleteMusicMem")]
		extern static int  dx_DeleteMusicMem_x64( int  MusicHandle);
		public static int  DeleteMusicMem( int  MusicHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DeleteMusicMem_x86( MusicHandle );
			}
			else
			{
				return dx_DeleteMusicMem_x64( MusicHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_LoadMusicMem")]
		extern static int  dx_LoadMusicMem_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadMusicMem")]
		extern static int  dx_LoadMusicMem_x64( string  FileName);
		public static int  LoadMusicMem( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadMusicMem_x86( FileName );
			}
			else
			{
				return dx_LoadMusicMem_x64( FileName );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_LoadMusicMemByMemImage")]
		extern unsafe static int  dx_LoadMusicMemByMemImage_x86( void *  FileImage, int  FileImageSize);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadMusicMemByMemImage")]
		extern unsafe static int  dx_LoadMusicMemByMemImage_x64( void *  FileImage, int  FileImageSize);
		public unsafe static int  LoadMusicMemByMemImage( void *  FileImage, int  FileImageSize)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadMusicMemByMemImage_x86( FileImage , FileImageSize );
			}
			else
			{
				return dx_LoadMusicMemByMemImage_x64( FileImage , FileImageSize );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_LoadMusicMemByResource")]
		extern static int  dx_LoadMusicMemByResource_x86( string  ResourceName, string  ResourceType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_LoadMusicMemByResource")]
		extern static int  dx_LoadMusicMemByResource_x64( string  ResourceName, string  ResourceType);
		public static int  LoadMusicMemByResource( string  ResourceName, string  ResourceType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_LoadMusicMemByResource_x86( ResourceName , ResourceType );
			}
			else
			{
				return dx_LoadMusicMemByResource_x64( ResourceName , ResourceType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMusicMem")]
		extern static int  dx_PlayMusicMem_x86( int  MusicHandle, int  PlayType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlayMusicMem")]
		extern static int  dx_PlayMusicMem_x64( int  MusicHandle, int  PlayType);
		public static int  PlayMusicMem( int  MusicHandle, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayMusicMem_x86( MusicHandle , PlayType );
			}
			else
			{
				return dx_PlayMusicMem_x64( MusicHandle , PlayType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopMusicMem")]
		extern static int  dx_StopMusicMem_x86( int  MusicHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StopMusicMem")]
		extern static int  dx_StopMusicMem_x64( int  MusicHandle);
		public static int  StopMusicMem( int  MusicHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StopMusicMem_x86( MusicHandle );
			}
			else
			{
				return dx_StopMusicMem_x64( MusicHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMusicMem")]
		extern static int  dx_CheckMusicMem_x86( int  MusicHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckMusicMem")]
		extern static int  dx_CheckMusicMem_x64( int  MusicHandle);
		public static int  CheckMusicMem( int  MusicHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckMusicMem_x86( MusicHandle );
			}
			else
			{
				return dx_CheckMusicMem_x64( MusicHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVolumeMusicMem")]
		extern static int  dx_SetVolumeMusicMem_x86( int  Volume, int  MusicHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVolumeMusicMem")]
		extern static int  dx_SetVolumeMusicMem_x64( int  Volume, int  MusicHandle);
		public static int  SetVolumeMusicMem( int  Volume, int  MusicHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVolumeMusicMem_x86( Volume , MusicHandle );
			}
			else
			{
				return dx_SetVolumeMusicMem_x64( Volume , MusicHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMusicMemPosition")]
		extern static int  dx_GetMusicMemPosition_x86( int  MusicHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMusicMemPosition")]
		extern static int  dx_GetMusicMemPosition_x64( int  MusicHandle);
		public static int  GetMusicMemPosition( int  MusicHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMusicMemPosition_x86( MusicHandle );
			}
			else
			{
				return dx_GetMusicMemPosition_x64( MusicHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_InitMusicMem")]
		extern static int  dx_InitMusicMem_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_InitMusicMem")]
		extern static int  dx_InitMusicMem_x64( );
		public static int  InitMusicMem( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_InitMusicMem_x86( );
			}
			else
			{
				return dx_InitMusicMem_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_ProcessMusicMem")]
		extern static int  dx_ProcessMusicMem_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_ProcessMusicMem")]
		extern static int  dx_ProcessMusicMem_x64( );
		public static int  ProcessMusicMem( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_ProcessMusicMem_x86( );
			}
			else
			{
				return dx_ProcessMusicMem_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMusic")]
		extern static int  dx_PlayMusic_x86( string  FileName, int  PlayType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlayMusic")]
		extern static int  dx_PlayMusic_x64( string  FileName, int  PlayType);
		public static int  PlayMusic( string  FileName, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayMusic_x86( FileName , PlayType );
			}
			else
			{
				return dx_PlayMusic_x64( FileName , PlayType );
			}
		}

#if DX_USE_UNSAFE
		[DllImport("DxLib.dll", EntryPoint="dx_PlayMusicByMemImage")]
		extern unsafe static int  dx_PlayMusicByMemImage_x86( void *  FileImage, int  FileImageSize, int  PlayType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlayMusicByMemImage")]
		extern unsafe static int  dx_PlayMusicByMemImage_x64( void *  FileImage, int  FileImageSize, int  PlayType);
		public unsafe static int  PlayMusicByMemImage( void *  FileImage, int  FileImageSize, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayMusicByMemImage_x86( FileImage , FileImageSize , PlayType );
			}
			else
			{
				return dx_PlayMusicByMemImage_x64( FileImage , FileImageSize , PlayType );
			}
		}
#endif

		[DllImport("DxLib.dll", EntryPoint="dx_PlayMusicByResource")]
		extern static int  dx_PlayMusicByResource_x86( string  ResourceName, string  ResourceType, int  PlayType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_PlayMusicByResource")]
		extern static int  dx_PlayMusicByResource_x64( string  ResourceName, string  ResourceType, int  PlayType);
		public static int  PlayMusicByResource( string  ResourceName, string  ResourceType, int  PlayType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_PlayMusicByResource_x86( ResourceName , ResourceType , PlayType );
			}
			else
			{
				return dx_PlayMusicByResource_x64( ResourceName , ResourceType , PlayType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetVolumeMusic")]
		extern static int  dx_SetVolumeMusic_x86( int  Volume);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetVolumeMusic")]
		extern static int  dx_SetVolumeMusic_x64( int  Volume);
		public static int  SetVolumeMusic( int  Volume)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetVolumeMusic_x86( Volume );
			}
			else
			{
				return dx_SetVolumeMusic_x64( Volume );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_StopMusic")]
		extern static int  dx_StopMusic_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_StopMusic")]
		extern static int  dx_StopMusic_x64( );
		public static int  StopMusic( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_StopMusic_x86( );
			}
			else
			{
				return dx_StopMusic_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_CheckMusic")]
		extern static int  dx_CheckMusic_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_CheckMusic")]
		extern static int  dx_CheckMusic_x64( );
		public static int  CheckMusic( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_CheckMusic_x86( );
			}
			else
			{
				return dx_CheckMusic_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_GetMusicPosition")]
		extern static int  dx_GetMusicPosition_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_GetMusicPosition")]
		extern static int  dx_GetMusicPosition_x64( );
		public static int  GetMusicPosition( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_GetMusicPosition_x86( );
			}
			else
			{
				return dx_GetMusicPosition_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SelectMidiMode")]
		extern static int  dx_SelectMidiMode_x86( int  Mode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SelectMidiMode")]
		extern static int  dx_SelectMidiMode_x64( int  Mode);
		public static int  SelectMidiMode( int  Mode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SelectMidiMode_x86( Mode );
			}
			else
			{
				return dx_SelectMidiMode_x64( Mode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetUseDXArchiveFlag")]
		extern static int  dx_SetUseDXArchiveFlag_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetUseDXArchiveFlag")]
		extern static int  dx_SetUseDXArchiveFlag_x64( int  Flag);
		public static int  SetUseDXArchiveFlag( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetUseDXArchiveFlag_x86( Flag );
			}
			else
			{
				return dx_SetUseDXArchiveFlag_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDXArchivePriority")]
		extern static int  dx_SetDXArchivePriority_x86( int  Priority);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDXArchivePriority")]
		extern static int  dx_SetDXArchivePriority_x64( int  Priority);
		public static int  SetDXArchivePriority( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDXArchivePriority_x86( 0 );
			}
			else
			{
				return dx_SetDXArchivePriority_x64( 0 );
			}
		}
		public static int  SetDXArchivePriority( int  Priority)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDXArchivePriority_x86( Priority );
			}
			else
			{
				return dx_SetDXArchivePriority_x64( Priority );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDXArchiveExtension")]
		extern static int  dx_SetDXArchiveExtension_x86( string  Extension);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDXArchiveExtension")]
		extern static int  dx_SetDXArchiveExtension_x64( string  Extension);
		public static int  SetDXArchiveExtension( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDXArchiveExtension_x86( null );
			}
			else
			{
				return dx_SetDXArchiveExtension_x64( null );
			}
		}
		public static int  SetDXArchiveExtension( string  Extension)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDXArchiveExtension_x86( Extension );
			}
			else
			{
				return dx_SetDXArchiveExtension_x64( Extension );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_SetDXArchiveKeyString")]
		extern static int  dx_SetDXArchiveKeyString_x86( string  KeyString);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_SetDXArchiveKeyString")]
		extern static int  dx_SetDXArchiveKeyString_x64( string  KeyString);
		public static int  SetDXArchiveKeyString( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDXArchiveKeyString_x86( null );
			}
			else
			{
				return dx_SetDXArchiveKeyString_x64( null );
			}
		}
		public static int  SetDXArchiveKeyString( string  KeyString)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_SetDXArchiveKeyString_x86( KeyString );
			}
			else
			{
				return dx_SetDXArchiveKeyString_x64( KeyString );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DXArchivePreLoad")]
		extern static int  dx_DXArchivePreLoad_x86( string  FilePath, int  ASync);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DXArchivePreLoad")]
		extern static int  dx_DXArchivePreLoad_x64( string  FilePath, int  ASync);
		public static int  DXArchivePreLoad( string  FilePath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DXArchivePreLoad_x86( FilePath , FALSE );
			}
			else
			{
				return dx_DXArchivePreLoad_x64( FilePath , FALSE );
			}
		}
		public static int  DXArchivePreLoad( string  FilePath, int  ASync)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DXArchivePreLoad_x86( FilePath , ASync );
			}
			else
			{
				return dx_DXArchivePreLoad_x64( FilePath , ASync );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DXArchiveCheckIdle")]
		extern static int  dx_DXArchiveCheckIdle_x86( string  FilePath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DXArchiveCheckIdle")]
		extern static int  dx_DXArchiveCheckIdle_x64( string  FilePath);
		public static int  DXArchiveCheckIdle( string  FilePath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DXArchiveCheckIdle_x86( FilePath );
			}
			else
			{
				return dx_DXArchiveCheckIdle_x64( FilePath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DXArchiveRelease")]
		extern static int  dx_DXArchiveRelease_x86( string  FilePath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DXArchiveRelease")]
		extern static int  dx_DXArchiveRelease_x64( string  FilePath);
		public static int  DXArchiveRelease( string  FilePath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DXArchiveRelease_x86( FilePath );
			}
			else
			{
				return dx_DXArchiveRelease_x64( FilePath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_DXArchiveCheckFile")]
		extern static int  dx_DXArchiveCheckFile_x86( string  FilePath, string  TargetFilePath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_DXArchiveCheckFile")]
		extern static int  dx_DXArchiveCheckFile_x64( string  FilePath, string  TargetFilePath);
		public static int  DXArchiveCheckFile( string  FilePath, string  TargetFilePath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_DXArchiveCheckFile_x86( FilePath , TargetFilePath );
			}
			else
			{
				return dx_DXArchiveCheckFile_x64( FilePath , TargetFilePath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1LoadModel")]
		extern static int  dx_MV1LoadModel_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1LoadModel")]
		extern static int  dx_MV1LoadModel_x64( string  FileName);
		public static int  MV1LoadModel( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1LoadModel_x86( FileName );
			}
			else
			{
				return dx_MV1LoadModel_x64( FileName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DuplicateModel")]
		extern static int  dx_MV1DuplicateModel_x86( int  SrcMHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1DuplicateModel")]
		extern static int  dx_MV1DuplicateModel_x64( int  SrcMHandle);
		public static int  MV1DuplicateModel( int  SrcMHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1DuplicateModel_x86( SrcMHandle );
			}
			else
			{
				return dx_MV1DuplicateModel_x64( SrcMHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CreateCloneModel")]
		extern static int  dx_MV1CreateCloneModel_x86( int  SrcMHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1CreateCloneModel")]
		extern static int  dx_MV1CreateCloneModel_x64( int  SrcMHandle);
		public static int  MV1CreateCloneModel( int  SrcMHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1CreateCloneModel_x86( SrcMHandle );
			}
			else
			{
				return dx_MV1CreateCloneModel_x64( SrcMHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DeleteModel")]
		extern static int  dx_MV1DeleteModel_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1DeleteModel")]
		extern static int  dx_MV1DeleteModel_x64( int  MHandle);
		public static int  MV1DeleteModel( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1DeleteModel_x86( MHandle );
			}
			else
			{
				return dx_MV1DeleteModel_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1InitModel")]
		extern static int  dx_MV1InitModel_x86( );
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1InitModel")]
		extern static int  dx_MV1InitModel_x64( );
		public static int  MV1InitModel( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1InitModel_x86( );
			}
			else
			{
				return dx_MV1InitModel_x64( );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelReMakeNormal")]
		extern static int  dx_MV1SetLoadModelReMakeNormal_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetLoadModelReMakeNormal")]
		extern static int  dx_MV1SetLoadModelReMakeNormal_x64( int  Flag);
		public static int  MV1SetLoadModelReMakeNormal( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetLoadModelReMakeNormal_x86( Flag );
			}
			else
			{
				return dx_MV1SetLoadModelReMakeNormal_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelReMakeNormalSmoothingAngle")]
		extern static int  dx_MV1SetLoadModelReMakeNormalSmoothingAngle_x86( float  SmoothingAngle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetLoadModelReMakeNormalSmoothingAngle")]
		extern static int  dx_MV1SetLoadModelReMakeNormalSmoothingAngle_x64( float  SmoothingAngle);
		public static int  MV1SetLoadModelReMakeNormalSmoothingAngle( )
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetLoadModelReMakeNormalSmoothingAngle_x86( 1.562069f );
			}
			else
			{
				return dx_MV1SetLoadModelReMakeNormalSmoothingAngle_x64( 1.562069f );
			}
		}
		public static int  MV1SetLoadModelReMakeNormalSmoothingAngle( float  SmoothingAngle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetLoadModelReMakeNormalSmoothingAngle_x86( SmoothingAngle );
			}
			else
			{
				return dx_MV1SetLoadModelReMakeNormalSmoothingAngle_x64( SmoothingAngle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelPositionOptimize")]
		extern static int  dx_MV1SetLoadModelPositionOptimize_x86( int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetLoadModelPositionOptimize")]
		extern static int  dx_MV1SetLoadModelPositionOptimize_x64( int  Flag);
		public static int  MV1SetLoadModelPositionOptimize( int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetLoadModelPositionOptimize_x86( Flag );
			}
			else
			{
				return dx_MV1SetLoadModelPositionOptimize_x64( Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelUsePhysicsMode")]
		extern static int  dx_MV1SetLoadModelUsePhysicsMode_x86( int  PhysicsMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetLoadModelUsePhysicsMode")]
		extern static int  dx_MV1SetLoadModelUsePhysicsMode_x64( int  PhysicsMode);
		public static int  MV1SetLoadModelUsePhysicsMode( int  PhysicsMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetLoadModelUsePhysicsMode_x86( PhysicsMode );
			}
			else
			{
				return dx_MV1SetLoadModelUsePhysicsMode_x64( PhysicsMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelPhysicsWorldGravity")]
		extern static int  dx_MV1SetLoadModelPhysicsWorldGravity_x86( float  Gravity);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetLoadModelPhysicsWorldGravity")]
		extern static int  dx_MV1SetLoadModelPhysicsWorldGravity_x64( float  Gravity);
		public static int  MV1SetLoadModelPhysicsWorldGravity( float  Gravity)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetLoadModelPhysicsWorldGravity_x86( Gravity );
			}
			else
			{
				return dx_MV1SetLoadModelPhysicsWorldGravity_x64( Gravity );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadCalcPhysicsWorldGravity")]
		extern static int  dx_MV1SetLoadCalcPhysicsWorldGravity_x86( int  GravityNo, VECTOR  Gravity);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetLoadCalcPhysicsWorldGravity")]
		extern static int  dx_MV1SetLoadCalcPhysicsWorldGravity_x64( int  GravityNo, VECTOR  Gravity);
		public static int  MV1SetLoadCalcPhysicsWorldGravity( int  GravityNo, VECTOR  Gravity)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetLoadCalcPhysicsWorldGravity_x86( GravityNo , Gravity );
			}
			else
			{
				return dx_MV1SetLoadCalcPhysicsWorldGravity_x64( GravityNo , Gravity );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetLoadModelAnimFilePath")]
		extern static int  dx_MV1SetLoadModelAnimFilePath_x86( string  FileName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetLoadModelAnimFilePath")]
		extern static int  dx_MV1SetLoadModelAnimFilePath_x64( string  FileName);
		public static int  MV1SetLoadModelAnimFilePath( string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetLoadModelAnimFilePath_x86( FileName );
			}
			else
			{
				return dx_MV1SetLoadModelAnimFilePath_x64( FileName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SaveModelToMV1File")]
		extern static int  dx_MV1SaveModelToMV1File_x86( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag, int  Anim16BitFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SaveModelToMV1File")]
		extern static int  dx_MV1SaveModelToMV1File_x64( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag, int  Anim16BitFlag);
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToMV1File_x86( MHandle , FileName , MV1_SAVETYPE_NORMAL , -1 , TRUE , 1 , 1 , 0 , 1 );
			}
			else
			{
				return dx_MV1SaveModelToMV1File_x64( MHandle , FileName , MV1_SAVETYPE_NORMAL , -1 , TRUE , 1 , 1 , 0 , 1 );
			}
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToMV1File_x86( MHandle , FileName , SaveType , -1 , TRUE , 1 , 1 , 0 , 1 );
			}
			else
			{
				return dx_MV1SaveModelToMV1File_x64( MHandle , FileName , SaveType , -1 , TRUE , 1 , 1 , 0 , 1 );
			}
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToMV1File_x86( MHandle , FileName , SaveType , AnimMHandle , TRUE , 1 , 1 , 0 , 1 );
			}
			else
			{
				return dx_MV1SaveModelToMV1File_x64( MHandle , FileName , SaveType , AnimMHandle , TRUE , 1 , 1 , 0 , 1 );
			}
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToMV1File_x86( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , 1 , 1 , 0 , 1 );
			}
			else
			{
				return dx_MV1SaveModelToMV1File_x64( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , 1 , 1 , 0 , 1 );
			}
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToMV1File_x86( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , 1 , 0 , 1 );
			}
			else
			{
				return dx_MV1SaveModelToMV1File_x64( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , 1 , 0 , 1 );
			}
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToMV1File_x86( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , 0 , 1 );
			}
			else
			{
				return dx_MV1SaveModelToMV1File_x64( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , 0 , 1 );
			}
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToMV1File_x86( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , Weight8BitFlag , 1 );
			}
			else
			{
				return dx_MV1SaveModelToMV1File_x64( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , Weight8BitFlag , 1 );
			}
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag, int  Anim16BitFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToMV1File_x86( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , Weight8BitFlag , Anim16BitFlag );
			}
			else
			{
				return dx_MV1SaveModelToMV1File_x64( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , Weight8BitFlag , Anim16BitFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SaveModelToXFile")]
		extern static int  dx_MV1SaveModelToXFile_x86( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SaveModelToXFile")]
		extern static int  dx_MV1SaveModelToXFile_x64( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck);
		public static int  MV1SaveModelToXFile( int  MHandle, string  FileName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToXFile_x86( MHandle , FileName , MV1_SAVETYPE_NORMAL , -1 , TRUE );
			}
			else
			{
				return dx_MV1SaveModelToXFile_x64( MHandle , FileName , MV1_SAVETYPE_NORMAL , -1 , TRUE );
			}
		}
		public static int  MV1SaveModelToXFile( int  MHandle, string  FileName, int  SaveType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToXFile_x86( MHandle , FileName , SaveType , -1 , TRUE );
			}
			else
			{
				return dx_MV1SaveModelToXFile_x64( MHandle , FileName , SaveType , -1 , TRUE );
			}
		}
		public static int  MV1SaveModelToXFile( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToXFile_x86( MHandle , FileName , SaveType , AnimMHandle , TRUE );
			}
			else
			{
				return dx_MV1SaveModelToXFile_x64( MHandle , FileName , SaveType , AnimMHandle , TRUE );
			}
		}
		public static int  MV1SaveModelToXFile( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SaveModelToXFile_x86( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck );
			}
			else
			{
				return dx_MV1SaveModelToXFile_x64( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DrawModel")]
		extern static int  dx_MV1DrawModel_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1DrawModel")]
		extern static int  dx_MV1DrawModel_x64( int  MHandle);
		public static int  MV1DrawModel( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1DrawModel_x86( MHandle );
			}
			else
			{
				return dx_MV1DrawModel_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DrawFrame")]
		extern static int  dx_MV1DrawFrame_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1DrawFrame")]
		extern static int  dx_MV1DrawFrame_x64( int  MHandle, int  FrameIndex);
		public static int  MV1DrawFrame( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1DrawFrame_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1DrawFrame_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DrawMesh")]
		extern static int  dx_MV1DrawMesh_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1DrawMesh")]
		extern static int  dx_MV1DrawMesh_x64( int  MHandle, int  MeshIndex);
		public static int  MV1DrawMesh( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1DrawMesh_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1DrawMesh_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DrawTriangleList")]
		extern static int  dx_MV1DrawTriangleList_x86( int  MHandle, int  TriangleListIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1DrawTriangleList")]
		extern static int  dx_MV1DrawTriangleList_x64( int  MHandle, int  TriangleListIndex);
		public static int  MV1DrawTriangleList( int  MHandle, int  TriangleListIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1DrawTriangleList_x86( MHandle , TriangleListIndex );
			}
			else
			{
				return dx_MV1DrawTriangleList_x64( MHandle , TriangleListIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DrawModelDebug")]
		extern static int  dx_MV1DrawModelDebug_x86( int  MHandle, int  Color, int  IsNormalLine, float  NormalLineLength, int  IsPolyLine, int  IsCollisionBox);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1DrawModelDebug")]
		extern static int  dx_MV1DrawModelDebug_x64( int  MHandle, int  Color, int  IsNormalLine, float  NormalLineLength, int  IsPolyLine, int  IsCollisionBox);
		public static int  MV1DrawModelDebug( int  MHandle, int  Color, int  IsNormalLine, float  NormalLineLength, int  IsPolyLine, int  IsCollisionBox)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1DrawModelDebug_x86( MHandle , Color , IsNormalLine , NormalLineLength , IsPolyLine , IsCollisionBox );
			}
			else
			{
				return dx_MV1DrawModelDebug_x64( MHandle , Color , IsNormalLine , NormalLineLength , IsPolyLine , IsCollisionBox );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetUseOrigShader")]
		extern static int  dx_MV1SetUseOrigShader_x86( int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetUseOrigShader")]
		extern static int  dx_MV1SetUseOrigShader_x64( int  UseFlag);
		public static int  MV1SetUseOrigShader( int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetUseOrigShader_x86( UseFlag );
			}
			else
			{
				return dx_MV1SetUseOrigShader_x64( UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetLocalWorldMatrix")]
		extern static MATRIX  dx_MV1GetLocalWorldMatrix_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetLocalWorldMatrix")]
		extern static MATRIX  dx_MV1GetLocalWorldMatrix_x64( int  MHandle);
		public static MATRIX  MV1GetLocalWorldMatrix( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetLocalWorldMatrix_x86( MHandle );
			}
			else
			{
				return dx_MV1GetLocalWorldMatrix_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetPosition")]
		extern static int  dx_MV1SetPosition_x86( int  MHandle, VECTOR  Position);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetPosition")]
		extern static int  dx_MV1SetPosition_x64( int  MHandle, VECTOR  Position);
		public static int  MV1SetPosition( int  MHandle, VECTOR  Position)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetPosition_x86( MHandle , Position );
			}
			else
			{
				return dx_MV1SetPosition_x64( MHandle , Position );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetPosition")]
		extern static VECTOR  dx_MV1GetPosition_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetPosition")]
		extern static VECTOR  dx_MV1GetPosition_x64( int  MHandle);
		public static VECTOR  MV1GetPosition( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetPosition_x86( MHandle );
			}
			else
			{
				return dx_MV1GetPosition_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetScale")]
		extern static int  dx_MV1SetScale_x86( int  MHandle, VECTOR  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetScale")]
		extern static int  dx_MV1SetScale_x64( int  MHandle, VECTOR  Scale);
		public static int  MV1SetScale( int  MHandle, VECTOR  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetScale_x86( MHandle , Scale );
			}
			else
			{
				return dx_MV1SetScale_x64( MHandle , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetScale")]
		extern static VECTOR  dx_MV1GetScale_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetScale")]
		extern static VECTOR  dx_MV1GetScale_x64( int  MHandle);
		public static VECTOR  MV1GetScale( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetScale_x86( MHandle );
			}
			else
			{
				return dx_MV1GetScale_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetRotationXYZ")]
		extern static int  dx_MV1SetRotationXYZ_x86( int  MHandle, VECTOR  Rotate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetRotationXYZ")]
		extern static int  dx_MV1SetRotationXYZ_x64( int  MHandle, VECTOR  Rotate);
		public static int  MV1SetRotationXYZ( int  MHandle, VECTOR  Rotate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetRotationXYZ_x86( MHandle , Rotate );
			}
			else
			{
				return dx_MV1SetRotationXYZ_x64( MHandle , Rotate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetRotationXYZ")]
		extern static VECTOR  dx_MV1GetRotationXYZ_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetRotationXYZ")]
		extern static VECTOR  dx_MV1GetRotationXYZ_x64( int  MHandle);
		public static VECTOR  MV1GetRotationXYZ( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetRotationXYZ_x86( MHandle );
			}
			else
			{
				return dx_MV1GetRotationXYZ_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetRotationZYAxis")]
		extern static int  dx_MV1SetRotationZYAxis_x86( int  MHandle, VECTOR  ZAxisDirection, VECTOR  YAxisDirection, float  ZAxisTwistRotate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetRotationZYAxis")]
		extern static int  dx_MV1SetRotationZYAxis_x64( int  MHandle, VECTOR  ZAxisDirection, VECTOR  YAxisDirection, float  ZAxisTwistRotate);
		public static int  MV1SetRotationZYAxis( int  MHandle, VECTOR  ZAxisDirection, VECTOR  YAxisDirection, float  ZAxisTwistRotate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetRotationZYAxis_x86( MHandle , ZAxisDirection , YAxisDirection , ZAxisTwistRotate );
			}
			else
			{
				return dx_MV1SetRotationZYAxis_x64( MHandle , ZAxisDirection , YAxisDirection , ZAxisTwistRotate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetRotationMatrix")]
		extern static int  dx_MV1SetRotationMatrix_x86( int  MHandle, MATRIX  Matrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetRotationMatrix")]
		extern static int  dx_MV1SetRotationMatrix_x64( int  MHandle, MATRIX  Matrix);
		public static int  MV1SetRotationMatrix( int  MHandle, MATRIX  Matrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetRotationMatrix_x86( MHandle , Matrix );
			}
			else
			{
				return dx_MV1SetRotationMatrix_x64( MHandle , Matrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetRotationMatrix")]
		extern static MATRIX  dx_MV1GetRotationMatrix_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetRotationMatrix")]
		extern static MATRIX  dx_MV1GetRotationMatrix_x64( int  MHandle);
		public static MATRIX  MV1GetRotationMatrix( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetRotationMatrix_x86( MHandle );
			}
			else
			{
				return dx_MV1GetRotationMatrix_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMatrix")]
		extern static int  dx_MV1SetMatrix_x86( int  MHandle, MATRIX  Matrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMatrix")]
		extern static int  dx_MV1SetMatrix_x64( int  MHandle, MATRIX  Matrix);
		public static int  MV1SetMatrix( int  MHandle, MATRIX  Matrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMatrix_x86( MHandle , Matrix );
			}
			else
			{
				return dx_MV1SetMatrix_x64( MHandle , Matrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMatrix")]
		extern static MATRIX  dx_MV1GetMatrix_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMatrix")]
		extern static MATRIX  dx_MV1GetMatrix_x64( int  MHandle);
		public static MATRIX  MV1GetMatrix( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMatrix_x86( MHandle );
			}
			else
			{
				return dx_MV1GetMatrix_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetVisible")]
		extern static int  dx_MV1SetVisible_x86( int  MHandle, int  VisibleFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetVisible")]
		extern static int  dx_MV1SetVisible_x64( int  MHandle, int  VisibleFlag);
		public static int  MV1SetVisible( int  MHandle, int  VisibleFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetVisible_x86( MHandle , VisibleFlag );
			}
			else
			{
				return dx_MV1SetVisible_x64( MHandle , VisibleFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetVisible")]
		extern static int  dx_MV1GetVisible_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetVisible")]
		extern static int  dx_MV1GetVisible_x64( int  MHandle);
		public static int  MV1GetVisible( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetVisible_x86( MHandle );
			}
			else
			{
				return dx_MV1GetVisible_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshCategoryVisible")]
		extern static int  dx_MV1SetMeshCategoryVisible_x86( int  MHandle, int  MeshCategory, int  VisibleFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshCategoryVisible")]
		extern static int  dx_MV1SetMeshCategoryVisible_x64( int  MHandle, int  MeshCategory, int  VisibleFlag);
		public static int  MV1SetMeshCategoryVisible( int  MHandle, int  MeshCategory, int  VisibleFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshCategoryVisible_x86( MHandle , MeshCategory , VisibleFlag );
			}
			else
			{
				return dx_MV1SetMeshCategoryVisible_x64( MHandle , MeshCategory , VisibleFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshCategoryVisible")]
		extern static int  dx_MV1GetMeshCategoryVisible_x86( int  MHandle, int  MeshCategory);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshCategoryVisible")]
		extern static int  dx_MV1GetMeshCategoryVisible_x64( int  MHandle, int  MeshCategory);
		public static int  MV1GetMeshCategoryVisible( int  MHandle, int  MeshCategory)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshCategoryVisible_x86( MHandle , MeshCategory );
			}
			else
			{
				return dx_MV1GetMeshCategoryVisible_x64( MHandle , MeshCategory );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetDifColorScale")]
		extern static int  dx_MV1SetDifColorScale_x86( int  MHandle, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetDifColorScale")]
		extern static int  dx_MV1SetDifColorScale_x64( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetDifColorScale( int  MHandle, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetDifColorScale_x86( MHandle , Scale );
			}
			else
			{
				return dx_MV1SetDifColorScale_x64( MHandle , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetDifColorScale")]
		extern static COLOR_F  dx_MV1GetDifColorScale_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetDifColorScale")]
		extern static COLOR_F  dx_MV1GetDifColorScale_x64( int  MHandle);
		public static COLOR_F  MV1GetDifColorScale( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetDifColorScale_x86( MHandle );
			}
			else
			{
				return dx_MV1GetDifColorScale_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetSpcColorScale")]
		extern static int  dx_MV1SetSpcColorScale_x86( int  MHandle, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetSpcColorScale")]
		extern static int  dx_MV1SetSpcColorScale_x64( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetSpcColorScale( int  MHandle, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetSpcColorScale_x86( MHandle , Scale );
			}
			else
			{
				return dx_MV1SetSpcColorScale_x64( MHandle , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetSpcColorScale")]
		extern static COLOR_F  dx_MV1GetSpcColorScale_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetSpcColorScale")]
		extern static COLOR_F  dx_MV1GetSpcColorScale_x64( int  MHandle);
		public static COLOR_F  MV1GetSpcColorScale( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetSpcColorScale_x86( MHandle );
			}
			else
			{
				return dx_MV1GetSpcColorScale_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetEmiColorScale")]
		extern static int  dx_MV1SetEmiColorScale_x86( int  MHandle, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetEmiColorScale")]
		extern static int  dx_MV1SetEmiColorScale_x64( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetEmiColorScale( int  MHandle, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetEmiColorScale_x86( MHandle , Scale );
			}
			else
			{
				return dx_MV1SetEmiColorScale_x64( MHandle , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetEmiColorScale")]
		extern static COLOR_F  dx_MV1GetEmiColorScale_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetEmiColorScale")]
		extern static COLOR_F  dx_MV1GetEmiColorScale_x64( int  MHandle);
		public static COLOR_F  MV1GetEmiColorScale( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetEmiColorScale_x86( MHandle );
			}
			else
			{
				return dx_MV1GetEmiColorScale_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAmbColorScale")]
		extern static int  dx_MV1SetAmbColorScale_x86( int  MHandle, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetAmbColorScale")]
		extern static int  dx_MV1SetAmbColorScale_x64( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetAmbColorScale( int  MHandle, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetAmbColorScale_x86( MHandle , Scale );
			}
			else
			{
				return dx_MV1SetAmbColorScale_x64( MHandle , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAmbColorScale")]
		extern static COLOR_F  dx_MV1GetAmbColorScale_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAmbColorScale")]
		extern static COLOR_F  dx_MV1GetAmbColorScale_x64( int  MHandle);
		public static COLOR_F  MV1GetAmbColorScale( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAmbColorScale_x86( MHandle );
			}
			else
			{
				return dx_MV1GetAmbColorScale_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetSemiTransState")]
		extern static int  dx_MV1GetSemiTransState_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetSemiTransState")]
		extern static int  dx_MV1GetSemiTransState_x64( int  MHandle);
		public static int  MV1GetSemiTransState( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetSemiTransState_x86( MHandle );
			}
			else
			{
				return dx_MV1GetSemiTransState_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetOpacityRate")]
		extern static int  dx_MV1SetOpacityRate_x86( int  MHandle, float  Rate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetOpacityRate")]
		extern static int  dx_MV1SetOpacityRate_x64( int  MHandle, float  Rate);
		public static int  MV1SetOpacityRate( int  MHandle, float  Rate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetOpacityRate_x86( MHandle , Rate );
			}
			else
			{
				return dx_MV1SetOpacityRate_x64( MHandle , Rate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetOpacityRate")]
		extern static float  dx_MV1GetOpacityRate_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetOpacityRate")]
		extern static float  dx_MV1GetOpacityRate_x64( int  MHandle);
		public static float  MV1GetOpacityRate( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetOpacityRate_x86( MHandle );
			}
			else
			{
				return dx_MV1GetOpacityRate_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetUseZBuffer")]
		extern static int  dx_MV1SetUseZBuffer_x86( int  MHandle, int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetUseZBuffer")]
		extern static int  dx_MV1SetUseZBuffer_x64( int  MHandle, int  Flag);
		public static int  MV1SetUseZBuffer( int  MHandle, int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetUseZBuffer_x86( MHandle , Flag );
			}
			else
			{
				return dx_MV1SetUseZBuffer_x64( MHandle , Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetWriteZBuffer")]
		extern static int  dx_MV1SetWriteZBuffer_x86( int  MHandle, int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetWriteZBuffer")]
		extern static int  dx_MV1SetWriteZBuffer_x64( int  MHandle, int  Flag);
		public static int  MV1SetWriteZBuffer( int  MHandle, int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetWriteZBuffer_x86( MHandle , Flag );
			}
			else
			{
				return dx_MV1SetWriteZBuffer_x64( MHandle , Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetZBufferCmpType")]
		extern static int  dx_MV1SetZBufferCmpType_x86( int  MHandle, int  CmpType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetZBufferCmpType")]
		extern static int  dx_MV1SetZBufferCmpType_x64( int  MHandle, int  CmpType);
		public static int  MV1SetZBufferCmpType( int  MHandle, int  CmpType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetZBufferCmpType_x86( MHandle , CmpType );
			}
			else
			{
				return dx_MV1SetZBufferCmpType_x64( MHandle , CmpType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetZBias")]
		extern static int  dx_MV1SetZBias_x86( int  MHandle, int  Bias);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetZBias")]
		extern static int  dx_MV1SetZBias_x64( int  MHandle, int  Bias);
		public static int  MV1SetZBias( int  MHandle, int  Bias)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetZBias_x86( MHandle , Bias );
			}
			else
			{
				return dx_MV1SetZBias_x64( MHandle , Bias );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetUseVertDifColor")]
		extern static int  dx_MV1SetUseVertDifColor_x86( int  MHandle, int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetUseVertDifColor")]
		extern static int  dx_MV1SetUseVertDifColor_x64( int  MHandle, int  UseFlag);
		public static int  MV1SetUseVertDifColor( int  MHandle, int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetUseVertDifColor_x86( MHandle , UseFlag );
			}
			else
			{
				return dx_MV1SetUseVertDifColor_x64( MHandle , UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetUseVertSpcColor")]
		extern static int  dx_MV1SetUseVertSpcColor_x86( int  MHandle, int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetUseVertSpcColor")]
		extern static int  dx_MV1SetUseVertSpcColor_x64( int  MHandle, int  UseFlag);
		public static int  MV1SetUseVertSpcColor( int  MHandle, int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetUseVertSpcColor_x86( MHandle , UseFlag );
			}
			else
			{
				return dx_MV1SetUseVertSpcColor_x64( MHandle , UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetSampleFilterMode")]
		extern static int  dx_MV1SetSampleFilterMode_x86( int  MHandle, int  FilterMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetSampleFilterMode")]
		extern static int  dx_MV1SetSampleFilterMode_x64( int  MHandle, int  FilterMode);
		public static int  MV1SetSampleFilterMode( int  MHandle, int  FilterMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetSampleFilterMode_x86( MHandle , FilterMode );
			}
			else
			{
				return dx_MV1SetSampleFilterMode_x64( MHandle , FilterMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaxAnisotropy")]
		extern static int  dx_MV1SetMaxAnisotropy_x86( int  MHandle, int  MaxAnisotropy);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaxAnisotropy")]
		extern static int  dx_MV1SetMaxAnisotropy_x64( int  MHandle, int  MaxAnisotropy);
		public static int  MV1SetMaxAnisotropy( int  MHandle, int  MaxAnisotropy)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaxAnisotropy_x86( MHandle , MaxAnisotropy );
			}
			else
			{
				return dx_MV1SetMaxAnisotropy_x64( MHandle , MaxAnisotropy );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetWireFrameDrawFlag")]
		extern static int  dx_MV1SetWireFrameDrawFlag_x86( int  MHandle, int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetWireFrameDrawFlag")]
		extern static int  dx_MV1SetWireFrameDrawFlag_x64( int  MHandle, int  Flag);
		public static int  MV1SetWireFrameDrawFlag( int  MHandle, int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetWireFrameDrawFlag_x86( MHandle , Flag );
			}
			else
			{
				return dx_MV1SetWireFrameDrawFlag_x64( MHandle , Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1RefreshVertColorFromMaterial")]
		extern static int  dx_MV1RefreshVertColorFromMaterial_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1RefreshVertColorFromMaterial")]
		extern static int  dx_MV1RefreshVertColorFromMaterial_x64( int  MHandle);
		public static int  MV1RefreshVertColorFromMaterial( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1RefreshVertColorFromMaterial_x86( MHandle );
			}
			else
			{
				return dx_MV1RefreshVertColorFromMaterial_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1PhysicsCalculation")]
		extern static int  dx_MV1PhysicsCalculation_x86( int  MHandle, float  MillisecondTime);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1PhysicsCalculation")]
		extern static int  dx_MV1PhysicsCalculation_x64( int  MHandle, float  MillisecondTime);
		public static int  MV1PhysicsCalculation( int  MHandle, float  MillisecondTime)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1PhysicsCalculation_x86( MHandle , MillisecondTime );
			}
			else
			{
				return dx_MV1PhysicsCalculation_x64( MHandle , MillisecondTime );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1PhysicsResetState")]
		extern static int  dx_MV1PhysicsResetState_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1PhysicsResetState")]
		extern static int  dx_MV1PhysicsResetState_x64( int  MHandle);
		public static int  MV1PhysicsResetState( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1PhysicsResetState_x86( MHandle );
			}
			else
			{
				return dx_MV1PhysicsResetState_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetUseShapeFlag")]
		extern static int  dx_MV1SetUseShapeFlag_x86( int  MHandle, int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetUseShapeFlag")]
		extern static int  dx_MV1SetUseShapeFlag_x64( int  MHandle, int  UseFlag);
		public static int  MV1SetUseShapeFlag( int  MHandle, int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetUseShapeFlag_x86( MHandle , UseFlag );
			}
			else
			{
				return dx_MV1SetUseShapeFlag_x64( MHandle , UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1AttachAnim")]
		extern static int  dx_MV1AttachAnim_x86( int  MHandle, int  AnimIndex, int  AnimSrcMHandle, int  NameCheck);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1AttachAnim")]
		extern static int  dx_MV1AttachAnim_x64( int  MHandle, int  AnimIndex, int  AnimSrcMHandle, int  NameCheck);
		public static int  MV1AttachAnim( int  MHandle, int  AnimIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1AttachAnim_x86( MHandle , AnimIndex , -1 , TRUE );
			}
			else
			{
				return dx_MV1AttachAnim_x64( MHandle , AnimIndex , -1 , TRUE );
			}
		}
		public static int  MV1AttachAnim( int  MHandle, int  AnimIndex, int  AnimSrcMHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1AttachAnim_x86( MHandle , AnimIndex , AnimSrcMHandle , TRUE );
			}
			else
			{
				return dx_MV1AttachAnim_x64( MHandle , AnimIndex , AnimSrcMHandle , TRUE );
			}
		}
		public static int  MV1AttachAnim( int  MHandle, int  AnimIndex, int  AnimSrcMHandle, int  NameCheck)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1AttachAnim_x86( MHandle , AnimIndex , AnimSrcMHandle , NameCheck );
			}
			else
			{
				return dx_MV1AttachAnim_x64( MHandle , AnimIndex , AnimSrcMHandle , NameCheck );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1DetachAnim")]
		extern static int  dx_MV1DetachAnim_x86( int  MHandle, int  AttachIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1DetachAnim")]
		extern static int  dx_MV1DetachAnim_x64( int  MHandle, int  AttachIndex);
		public static int  MV1DetachAnim( int  MHandle, int  AttachIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1DetachAnim_x86( MHandle , AttachIndex );
			}
			else
			{
				return dx_MV1DetachAnim_x64( MHandle , AttachIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAttachAnimTime")]
		extern static int  dx_MV1SetAttachAnimTime_x86( int  MHandle, int  AttachIndex, float  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetAttachAnimTime")]
		extern static int  dx_MV1SetAttachAnimTime_x64( int  MHandle, int  AttachIndex, float  Time);
		public static int  MV1SetAttachAnimTime( int  MHandle, int  AttachIndex, float  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetAttachAnimTime_x86( MHandle , AttachIndex , Time );
			}
			else
			{
				return dx_MV1SetAttachAnimTime_x64( MHandle , AttachIndex , Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnimTime")]
		extern static float  dx_MV1GetAttachAnimTime_x86( int  MHandle, int  AttachIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAttachAnimTime")]
		extern static float  dx_MV1GetAttachAnimTime_x64( int  MHandle, int  AttachIndex);
		public static float  MV1GetAttachAnimTime( int  MHandle, int  AttachIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAttachAnimTime_x86( MHandle , AttachIndex );
			}
			else
			{
				return dx_MV1GetAttachAnimTime_x64( MHandle , AttachIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnimTotalTime")]
		extern static float  dx_MV1GetAttachAnimTotalTime_x86( int  MHandle, int  AttachIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAttachAnimTotalTime")]
		extern static float  dx_MV1GetAttachAnimTotalTime_x64( int  MHandle, int  AttachIndex);
		public static float  MV1GetAttachAnimTotalTime( int  MHandle, int  AttachIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAttachAnimTotalTime_x86( MHandle , AttachIndex );
			}
			else
			{
				return dx_MV1GetAttachAnimTotalTime_x64( MHandle , AttachIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAttachAnimBlendRate")]
		extern static int  dx_MV1SetAttachAnimBlendRate_x86( int  MHandle, int  AttachIndex, float  Rate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetAttachAnimBlendRate")]
		extern static int  dx_MV1SetAttachAnimBlendRate_x64( int  MHandle, int  AttachIndex, float  Rate);
		public static int  MV1SetAttachAnimBlendRate( int  MHandle, int  AttachIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetAttachAnimBlendRate_x86( MHandle , AttachIndex , 1.0f );
			}
			else
			{
				return dx_MV1SetAttachAnimBlendRate_x64( MHandle , AttachIndex , 1.0f );
			}
		}
		public static int  MV1SetAttachAnimBlendRate( int  MHandle, int  AttachIndex, float  Rate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetAttachAnimBlendRate_x86( MHandle , AttachIndex , Rate );
			}
			else
			{
				return dx_MV1SetAttachAnimBlendRate_x64( MHandle , AttachIndex , Rate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnimBlendRate")]
		extern static float  dx_MV1GetAttachAnimBlendRate_x86( int  MHandle, int  AttachIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAttachAnimBlendRate")]
		extern static float  dx_MV1GetAttachAnimBlendRate_x64( int  MHandle, int  AttachIndex);
		public static float  MV1GetAttachAnimBlendRate( int  MHandle, int  AttachIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAttachAnimBlendRate_x86( MHandle , AttachIndex );
			}
			else
			{
				return dx_MV1GetAttachAnimBlendRate_x64( MHandle , AttachIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAttachAnimBlendRateToFrame")]
		extern static int  dx_MV1SetAttachAnimBlendRateToFrame_x86( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate, int  SetChild);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetAttachAnimBlendRateToFrame")]
		extern static int  dx_MV1SetAttachAnimBlendRateToFrame_x64( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate, int  SetChild);
		public static int  MV1SetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetAttachAnimBlendRateToFrame_x86( MHandle , AttachIndex , FrameIndex , Rate , TRUE );
			}
			else
			{
				return dx_MV1SetAttachAnimBlendRateToFrame_x64( MHandle , AttachIndex , FrameIndex , Rate , TRUE );
			}
		}
		public static int  MV1SetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate, int  SetChild)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetAttachAnimBlendRateToFrame_x86( MHandle , AttachIndex , FrameIndex , Rate , SetChild );
			}
			else
			{
				return dx_MV1SetAttachAnimBlendRateToFrame_x64( MHandle , AttachIndex , FrameIndex , Rate , SetChild );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnimBlendRateToFrame")]
		extern static float  dx_MV1GetAttachAnimBlendRateToFrame_x86( int  MHandle, int  AttachIndex, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAttachAnimBlendRateToFrame")]
		extern static float  dx_MV1GetAttachAnimBlendRateToFrame_x64( int  MHandle, int  AttachIndex, int  FrameIndex);
		public static float  MV1GetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAttachAnimBlendRateToFrame_x86( MHandle , AttachIndex , FrameIndex );
			}
			else
			{
				return dx_MV1GetAttachAnimBlendRateToFrame_x64( MHandle , AttachIndex , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnim")]
		extern static int  dx_MV1GetAttachAnim_x86( int  MHandle, int  AttachIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAttachAnim")]
		extern static int  dx_MV1GetAttachAnim_x64( int  MHandle, int  AttachIndex);
		public static int  MV1GetAttachAnim( int  MHandle, int  AttachIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAttachAnim_x86( MHandle , AttachIndex );
			}
			else
			{
				return dx_MV1GetAttachAnim_x64( MHandle , AttachIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAttachAnimUseShapeFlag")]
		extern static int  dx_MV1SetAttachAnimUseShapeFlag_x86( int  MHandle, int  AttachIndex, int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetAttachAnimUseShapeFlag")]
		extern static int  dx_MV1SetAttachAnimUseShapeFlag_x64( int  MHandle, int  AttachIndex, int  UseFlag);
		public static int  MV1SetAttachAnimUseShapeFlag( int  MHandle, int  AttachIndex, int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetAttachAnimUseShapeFlag_x86( MHandle , AttachIndex , UseFlag );
			}
			else
			{
				return dx_MV1SetAttachAnimUseShapeFlag_x64( MHandle , AttachIndex , UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAttachAnimUseShapeFlag")]
		extern static int  dx_MV1GetAttachAnimUseShapeFlag_x86( int  MHandle, int  AttachIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAttachAnimUseShapeFlag")]
		extern static int  dx_MV1GetAttachAnimUseShapeFlag_x64( int  MHandle, int  AttachIndex);
		public static int  MV1GetAttachAnimUseShapeFlag( int  MHandle, int  AttachIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAttachAnimUseShapeFlag_x86( MHandle , AttachIndex );
			}
			else
			{
				return dx_MV1GetAttachAnimUseShapeFlag_x64( MHandle , AttachIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimNum")]
		extern static int  dx_MV1GetAnimNum_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimNum")]
		extern static int  dx_MV1GetAnimNum_x64( int  MHandle);
		public static int  MV1GetAnimNum( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimNum_x86( MHandle );
			}
			else
			{
				return dx_MV1GetAnimNum_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetAnimName")]
		extern static int  dx_MV1SetAnimName_x86( int  MHandle, int  AnimIndex, string  AnimName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetAnimName")]
		extern static int  dx_MV1SetAnimName_x64( int  MHandle, int  AnimIndex, string  AnimName);
		public static int  MV1SetAnimName( int  MHandle, int  AnimIndex, string  AnimName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetAnimName_x86( MHandle , AnimIndex , AnimName );
			}
			else
			{
				return dx_MV1SetAnimName_x64( MHandle , AnimIndex , AnimName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimIndex")]
		extern static int  dx_MV1GetAnimIndex_x86( int  MHandle, string  AnimName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimIndex")]
		extern static int  dx_MV1GetAnimIndex_x64( int  MHandle, string  AnimName);
		public static int  MV1GetAnimIndex( int  MHandle, string  AnimName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimIndex_x86( MHandle , AnimName );
			}
			else
			{
				return dx_MV1GetAnimIndex_x64( MHandle , AnimName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTotalTime")]
		extern static float  dx_MV1GetAnimTotalTime_x86( int  MHandle, int  AnimIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimTotalTime")]
		extern static float  dx_MV1GetAnimTotalTime_x64( int  MHandle, int  AnimIndex);
		public static float  MV1GetAnimTotalTime( int  MHandle, int  AnimIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimTotalTime_x86( MHandle , AnimIndex );
			}
			else
			{
				return dx_MV1GetAnimTotalTime_x64( MHandle , AnimIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTargetFrameNum")]
		extern static int  dx_MV1GetAnimTargetFrameNum_x86( int  MHandle, int  AnimIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimTargetFrameNum")]
		extern static int  dx_MV1GetAnimTargetFrameNum_x64( int  MHandle, int  AnimIndex);
		public static int  MV1GetAnimTargetFrameNum( int  MHandle, int  AnimIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimTargetFrameNum_x86( MHandle , AnimIndex );
			}
			else
			{
				return dx_MV1GetAnimTargetFrameNum_x64( MHandle , AnimIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTargetFrame")]
		extern static int  dx_MV1GetAnimTargetFrame_x86( int  MHandle, int  AnimIndex, int  AnimFrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimTargetFrame")]
		extern static int  dx_MV1GetAnimTargetFrame_x64( int  MHandle, int  AnimIndex, int  AnimFrameIndex);
		public static int  MV1GetAnimTargetFrame( int  MHandle, int  AnimIndex, int  AnimFrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimTargetFrame_x86( MHandle , AnimIndex , AnimFrameIndex );
			}
			else
			{
				return dx_MV1GetAnimTargetFrame_x64( MHandle , AnimIndex , AnimFrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTargetFrameKeySetNum")]
		extern static int  dx_MV1GetAnimTargetFrameKeySetNum_x86( int  MHandle, int  AnimIndex, int  AnimFrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimTargetFrameKeySetNum")]
		extern static int  dx_MV1GetAnimTargetFrameKeySetNum_x64( int  MHandle, int  AnimIndex, int  AnimFrameIndex);
		public static int  MV1GetAnimTargetFrameKeySetNum( int  MHandle, int  AnimIndex, int  AnimFrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimTargetFrameKeySetNum_x86( MHandle , AnimIndex , AnimFrameIndex );
			}
			else
			{
				return dx_MV1GetAnimTargetFrameKeySetNum_x64( MHandle , AnimIndex , AnimFrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimTargetFrameKeySet")]
		extern static int  dx_MV1GetAnimTargetFrameKeySet_x86( int  MHandle, int  AnimIndex, int  AnimFrameIndex, int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimTargetFrameKeySet")]
		extern static int  dx_MV1GetAnimTargetFrameKeySet_x64( int  MHandle, int  AnimIndex, int  AnimFrameIndex, int  Index);
		public static int  MV1GetAnimTargetFrameKeySet( int  MHandle, int  AnimIndex, int  AnimFrameIndex, int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimTargetFrameKeySet_x86( MHandle , AnimIndex , AnimFrameIndex , Index );
			}
			else
			{
				return dx_MV1GetAnimTargetFrameKeySet_x64( MHandle , AnimIndex , AnimFrameIndex , Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetNum")]
		extern static int  dx_MV1GetAnimKeySetNum_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeySetNum")]
		extern static int  dx_MV1GetAnimKeySetNum_x64( int  MHandle);
		public static int  MV1GetAnimKeySetNum( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeySetNum_x86( MHandle );
			}
			else
			{
				return dx_MV1GetAnimKeySetNum_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetType")]
		extern static int  dx_MV1GetAnimKeySetType_x86( int  MHandle, int  AnimKeySetIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeySetType")]
		extern static int  dx_MV1GetAnimKeySetType_x64( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetType( int  MHandle, int  AnimKeySetIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeySetType_x86( MHandle , AnimKeySetIndex );
			}
			else
			{
				return dx_MV1GetAnimKeySetType_x64( MHandle , AnimKeySetIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetDataType")]
		extern static int  dx_MV1GetAnimKeySetDataType_x86( int  MHandle, int  AnimKeySetIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeySetDataType")]
		extern static int  dx_MV1GetAnimKeySetDataType_x64( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetDataType( int  MHandle, int  AnimKeySetIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeySetDataType_x86( MHandle , AnimKeySetIndex );
			}
			else
			{
				return dx_MV1GetAnimKeySetDataType_x64( MHandle , AnimKeySetIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetTimeType")]
		extern static int  dx_MV1GetAnimKeySetTimeType_x86( int  MHandle, int  AnimKeySetIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeySetTimeType")]
		extern static int  dx_MV1GetAnimKeySetTimeType_x64( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetTimeType( int  MHandle, int  AnimKeySetIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeySetTimeType_x86( MHandle , AnimKeySetIndex );
			}
			else
			{
				return dx_MV1GetAnimKeySetTimeType_x64( MHandle , AnimKeySetIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeySetDataNum")]
		extern static int  dx_MV1GetAnimKeySetDataNum_x86( int  MHandle, int  AnimKeySetIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeySetDataNum")]
		extern static int  dx_MV1GetAnimKeySetDataNum_x64( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetDataNum( int  MHandle, int  AnimKeySetIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeySetDataNum_x86( MHandle , AnimKeySetIndex );
			}
			else
			{
				return dx_MV1GetAnimKeySetDataNum_x64( MHandle , AnimKeySetIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataTime")]
		extern static float  dx_MV1GetAnimKeyDataTime_x86( int  MHandle, int  AnimKeySetIndex, int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataTime")]
		extern static float  dx_MV1GetAnimKeyDataTime_x64( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static float  MV1GetAnimKeyDataTime( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataTime_x86( MHandle , AnimKeySetIndex , Index );
			}
			else
			{
				return dx_MV1GetAnimKeyDataTime_x64( MHandle , AnimKeySetIndex , Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToQuaternion")]
		extern static FLOAT4  dx_MV1GetAnimKeyDataToQuaternion_x86( int  MHandle, int  AnimKeySetIndex, int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToQuaternion")]
		extern static FLOAT4  dx_MV1GetAnimKeyDataToQuaternion_x64( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static FLOAT4  MV1GetAnimKeyDataToQuaternion( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToQuaternion_x86( MHandle , AnimKeySetIndex , Index );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToQuaternion_x64( MHandle , AnimKeySetIndex , Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToQuaternionFromTime")]
		extern static FLOAT4  dx_MV1GetAnimKeyDataToQuaternionFromTime_x86( int  MHandle, int  AnimKeySetIndex, float  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToQuaternionFromTime")]
		extern static FLOAT4  dx_MV1GetAnimKeyDataToQuaternionFromTime_x64( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static FLOAT4  MV1GetAnimKeyDataToQuaternionFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToQuaternionFromTime_x86( MHandle , AnimKeySetIndex , Time );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToQuaternionFromTime_x64( MHandle , AnimKeySetIndex , Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToVector")]
		extern static VECTOR  dx_MV1GetAnimKeyDataToVector_x86( int  MHandle, int  AnimKeySetIndex, int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToVector")]
		extern static VECTOR  dx_MV1GetAnimKeyDataToVector_x64( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static VECTOR  MV1GetAnimKeyDataToVector( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToVector_x86( MHandle , AnimKeySetIndex , Index );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToVector_x64( MHandle , AnimKeySetIndex , Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToVectorFromTime")]
		extern static VECTOR  dx_MV1GetAnimKeyDataToVectorFromTime_x86( int  MHandle, int  AnimKeySetIndex, float  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToVectorFromTime")]
		extern static VECTOR  dx_MV1GetAnimKeyDataToVectorFromTime_x64( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static VECTOR  MV1GetAnimKeyDataToVectorFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToVectorFromTime_x86( MHandle , AnimKeySetIndex , Time );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToVectorFromTime_x64( MHandle , AnimKeySetIndex , Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToMatrix")]
		extern static MATRIX  dx_MV1GetAnimKeyDataToMatrix_x86( int  MHandle, int  AnimKeySetIndex, int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToMatrix")]
		extern static MATRIX  dx_MV1GetAnimKeyDataToMatrix_x64( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static MATRIX  MV1GetAnimKeyDataToMatrix( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToMatrix_x86( MHandle , AnimKeySetIndex , Index );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToMatrix_x64( MHandle , AnimKeySetIndex , Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToMatrixFromTime")]
		extern static MATRIX  dx_MV1GetAnimKeyDataToMatrixFromTime_x86( int  MHandle, int  AnimKeySetIndex, float  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToMatrixFromTime")]
		extern static MATRIX  dx_MV1GetAnimKeyDataToMatrixFromTime_x64( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static MATRIX  MV1GetAnimKeyDataToMatrixFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToMatrixFromTime_x86( MHandle , AnimKeySetIndex , Time );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToMatrixFromTime_x64( MHandle , AnimKeySetIndex , Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToFlat")]
		extern static float  dx_MV1GetAnimKeyDataToFlat_x86( int  MHandle, int  AnimKeySetIndex, int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToFlat")]
		extern static float  dx_MV1GetAnimKeyDataToFlat_x64( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static float  MV1GetAnimKeyDataToFlat( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToFlat_x86( MHandle , AnimKeySetIndex , Index );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToFlat_x64( MHandle , AnimKeySetIndex , Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToFlatFromTime")]
		extern static float  dx_MV1GetAnimKeyDataToFlatFromTime_x86( int  MHandle, int  AnimKeySetIndex, float  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToFlatFromTime")]
		extern static float  dx_MV1GetAnimKeyDataToFlatFromTime_x64( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static float  MV1GetAnimKeyDataToFlatFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToFlatFromTime_x86( MHandle , AnimKeySetIndex , Time );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToFlatFromTime_x64( MHandle , AnimKeySetIndex , Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToLinear")]
		extern static float  dx_MV1GetAnimKeyDataToLinear_x86( int  MHandle, int  AnimKeySetIndex, int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToLinear")]
		extern static float  dx_MV1GetAnimKeyDataToLinear_x64( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static float  MV1GetAnimKeyDataToLinear( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToLinear_x86( MHandle , AnimKeySetIndex , Index );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToLinear_x64( MHandle , AnimKeySetIndex , Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetAnimKeyDataToLinearFromTime")]
		extern static float  dx_MV1GetAnimKeyDataToLinearFromTime_x86( int  MHandle, int  AnimKeySetIndex, float  Time);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetAnimKeyDataToLinearFromTime")]
		extern static float  dx_MV1GetAnimKeyDataToLinearFromTime_x64( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static float  MV1GetAnimKeyDataToLinearFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetAnimKeyDataToLinearFromTime_x86( MHandle , AnimKeySetIndex , Time );
			}
			else
			{
				return dx_MV1GetAnimKeyDataToLinearFromTime_x64( MHandle , AnimKeySetIndex , Time );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialNum")]
		extern static int  dx_MV1GetMaterialNum_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialNum")]
		extern static int  dx_MV1GetMaterialNum_x64( int  MHandle);
		public static int  MV1GetMaterialNum( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialNum_x86( MHandle );
			}
			else
			{
				return dx_MV1GetMaterialNum_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialType")]
		extern static int  dx_MV1SetMaterialType_x86( int  MHandle, int  MaterialIndex, int  Type);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialType")]
		extern static int  dx_MV1SetMaterialType_x64( int  MHandle, int  MaterialIndex, int  Type);
		public static int  MV1SetMaterialType( int  MHandle, int  MaterialIndex, int  Type)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialType_x86( MHandle , MaterialIndex , Type );
			}
			else
			{
				return dx_MV1SetMaterialType_x64( MHandle , MaterialIndex , Type );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialType")]
		extern static int  dx_MV1GetMaterialType_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialType")]
		extern static int  dx_MV1GetMaterialType_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialType( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialType_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialType_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDifColor")]
		extern static int  dx_MV1SetMaterialDifColor_x86( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialDifColor")]
		extern static int  dx_MV1SetMaterialDifColor_x64( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialDifColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialDifColor_x86( MHandle , MaterialIndex , Color );
			}
			else
			{
				return dx_MV1SetMaterialDifColor_x64( MHandle , MaterialIndex , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDifColor")]
		extern static COLOR_F  dx_MV1GetMaterialDifColor_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialDifColor")]
		extern static COLOR_F  dx_MV1GetMaterialDifColor_x64( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialDifColor( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialDifColor_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialDifColor_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcColor")]
		extern static int  dx_MV1SetMaterialSpcColor_x86( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialSpcColor")]
		extern static int  dx_MV1SetMaterialSpcColor_x64( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialSpcColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialSpcColor_x86( MHandle , MaterialIndex , Color );
			}
			else
			{
				return dx_MV1SetMaterialSpcColor_x64( MHandle , MaterialIndex , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcColor")]
		extern static COLOR_F  dx_MV1GetMaterialSpcColor_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialSpcColor")]
		extern static COLOR_F  dx_MV1GetMaterialSpcColor_x64( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialSpcColor( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialSpcColor_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialSpcColor_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialEmiColor")]
		extern static int  dx_MV1SetMaterialEmiColor_x86( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialEmiColor")]
		extern static int  dx_MV1SetMaterialEmiColor_x64( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialEmiColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialEmiColor_x86( MHandle , MaterialIndex , Color );
			}
			else
			{
				return dx_MV1SetMaterialEmiColor_x64( MHandle , MaterialIndex , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialEmiColor")]
		extern static COLOR_F  dx_MV1GetMaterialEmiColor_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialEmiColor")]
		extern static COLOR_F  dx_MV1GetMaterialEmiColor_x64( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialEmiColor( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialEmiColor_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialEmiColor_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialAmbColor")]
		extern static int  dx_MV1SetMaterialAmbColor_x86( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialAmbColor")]
		extern static int  dx_MV1SetMaterialAmbColor_x64( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialAmbColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialAmbColor_x86( MHandle , MaterialIndex , Color );
			}
			else
			{
				return dx_MV1SetMaterialAmbColor_x64( MHandle , MaterialIndex , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialAmbColor")]
		extern static COLOR_F  dx_MV1GetMaterialAmbColor_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialAmbColor")]
		extern static COLOR_F  dx_MV1GetMaterialAmbColor_x64( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialAmbColor( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialAmbColor_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialAmbColor_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcPower")]
		extern static int  dx_MV1SetMaterialSpcPower_x86( int  MHandle, int  MaterialIndex, float  Power);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialSpcPower")]
		extern static int  dx_MV1SetMaterialSpcPower_x64( int  MHandle, int  MaterialIndex, float  Power);
		public static int  MV1SetMaterialSpcPower( int  MHandle, int  MaterialIndex, float  Power)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialSpcPower_x86( MHandle , MaterialIndex , Power );
			}
			else
			{
				return dx_MV1SetMaterialSpcPower_x64( MHandle , MaterialIndex , Power );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcPower")]
		extern static float  dx_MV1GetMaterialSpcPower_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialSpcPower")]
		extern static float  dx_MV1GetMaterialSpcPower_x64( int  MHandle, int  MaterialIndex);
		public static float  MV1GetMaterialSpcPower( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialSpcPower_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialSpcPower_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDifMapTexture")]
		extern static int  dx_MV1SetMaterialDifMapTexture_x86( int  MHandle, int  MaterialIndex, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialDifMapTexture")]
		extern static int  dx_MV1SetMaterialDifMapTexture_x64( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialDifMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialDifMapTexture_x86( MHandle , MaterialIndex , TexIndex );
			}
			else
			{
				return dx_MV1SetMaterialDifMapTexture_x64( MHandle , MaterialIndex , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDifMapTexture")]
		extern static int  dx_MV1GetMaterialDifMapTexture_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialDifMapTexture")]
		extern static int  dx_MV1GetMaterialDifMapTexture_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDifMapTexture( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialDifMapTexture_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialDifMapTexture_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcMapTexture")]
		extern static int  dx_MV1SetMaterialSpcMapTexture_x86( int  MHandle, int  MaterialIndex, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialSpcMapTexture")]
		extern static int  dx_MV1SetMaterialSpcMapTexture_x64( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialSpcMapTexture_x86( MHandle , MaterialIndex , TexIndex );
			}
			else
			{
				return dx_MV1SetMaterialSpcMapTexture_x64( MHandle , MaterialIndex , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcMapTexture")]
		extern static int  dx_MV1GetMaterialSpcMapTexture_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialSpcMapTexture")]
		extern static int  dx_MV1GetMaterialSpcMapTexture_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialSpcMapTexture_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialSpcMapTexture_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialNormalMapTexture")]
		extern static int  dx_MV1GetMaterialNormalMapTexture_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialNormalMapTexture")]
		extern static int  dx_MV1GetMaterialNormalMapTexture_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialNormalMapTexture( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialNormalMapTexture_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialNormalMapTexture_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDifGradTexture")]
		extern static int  dx_MV1SetMaterialDifGradTexture_x86( int  MHandle, int  MaterialIndex, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialDifGradTexture")]
		extern static int  dx_MV1SetMaterialDifGradTexture_x64( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialDifGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialDifGradTexture_x86( MHandle , MaterialIndex , TexIndex );
			}
			else
			{
				return dx_MV1SetMaterialDifGradTexture_x64( MHandle , MaterialIndex , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDifGradTexture")]
		extern static int  dx_MV1GetMaterialDifGradTexture_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialDifGradTexture")]
		extern static int  dx_MV1GetMaterialDifGradTexture_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDifGradTexture( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialDifGradTexture_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialDifGradTexture_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcGradTexture")]
		extern static int  dx_MV1SetMaterialSpcGradTexture_x86( int  MHandle, int  MaterialIndex, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialSpcGradTexture")]
		extern static int  dx_MV1SetMaterialSpcGradTexture_x64( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialSpcGradTexture_x86( MHandle , MaterialIndex , TexIndex );
			}
			else
			{
				return dx_MV1SetMaterialSpcGradTexture_x64( MHandle , MaterialIndex , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcGradTexture")]
		extern static int  dx_MV1GetMaterialSpcGradTexture_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialSpcGradTexture")]
		extern static int  dx_MV1GetMaterialSpcGradTexture_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialSpcGradTexture_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialSpcGradTexture_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSphereMapTexture")]
		extern static int  dx_MV1SetMaterialSphereMapTexture_x86( int  MHandle, int  MaterialIndex, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialSphereMapTexture")]
		extern static int  dx_MV1SetMaterialSphereMapTexture_x64( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialSphereMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialSphereMapTexture_x86( MHandle , MaterialIndex , TexIndex );
			}
			else
			{
				return dx_MV1SetMaterialSphereMapTexture_x64( MHandle , MaterialIndex , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSphereMapTexture")]
		extern static int  dx_MV1GetMaterialSphereMapTexture_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialSphereMapTexture")]
		extern static int  dx_MV1GetMaterialSphereMapTexture_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSphereMapTexture( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialSphereMapTexture_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialSphereMapTexture_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDifGradBlendType")]
		extern static int  dx_MV1SetMaterialDifGradBlendType_x86( int  MHandle, int  MaterialIndex, int  BlendType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialDifGradBlendType")]
		extern static int  dx_MV1SetMaterialDifGradBlendType_x64( int  MHandle, int  MaterialIndex, int  BlendType);
		public static int  MV1SetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialDifGradBlendType_x86( MHandle , MaterialIndex , BlendType );
			}
			else
			{
				return dx_MV1SetMaterialDifGradBlendType_x64( MHandle , MaterialIndex , BlendType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDifGradBlendType")]
		extern static int  dx_MV1GetMaterialDifGradBlendType_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialDifGradBlendType")]
		extern static int  dx_MV1GetMaterialDifGradBlendType_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialDifGradBlendType_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialDifGradBlendType_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSpcGradBlendType")]
		extern static int  dx_MV1SetMaterialSpcGradBlendType_x86( int  MHandle, int  MaterialIndex, int  BlendType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialSpcGradBlendType")]
		extern static int  dx_MV1SetMaterialSpcGradBlendType_x64( int  MHandle, int  MaterialIndex, int  BlendType);
		public static int  MV1SetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialSpcGradBlendType_x86( MHandle , MaterialIndex , BlendType );
			}
			else
			{
				return dx_MV1SetMaterialSpcGradBlendType_x64( MHandle , MaterialIndex , BlendType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSpcGradBlendType")]
		extern static int  dx_MV1GetMaterialSpcGradBlendType_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialSpcGradBlendType")]
		extern static int  dx_MV1GetMaterialSpcGradBlendType_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialSpcGradBlendType_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialSpcGradBlendType_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialSphereMapBlendType")]
		extern static int  dx_MV1SetMaterialSphereMapBlendType_x86( int  MHandle, int  MaterialIndex, int  BlendType);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialSphereMapBlendType")]
		extern static int  dx_MV1SetMaterialSphereMapBlendType_x64( int  MHandle, int  MaterialIndex, int  BlendType);
		public static int  MV1SetMaterialSphereMapBlendType( int  MHandle, int  MaterialIndex, int  BlendType)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialSphereMapBlendType_x86( MHandle , MaterialIndex , BlendType );
			}
			else
			{
				return dx_MV1SetMaterialSphereMapBlendType_x64( MHandle , MaterialIndex , BlendType );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialSphereMapBlendType")]
		extern static int  dx_MV1GetMaterialSphereMapBlendType_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialSphereMapBlendType")]
		extern static int  dx_MV1GetMaterialSphereMapBlendType_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSphereMapBlendType( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialSphereMapBlendType_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialSphereMapBlendType_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialOutLineWidth")]
		extern static int  dx_MV1SetMaterialOutLineWidth_x86( int  MHandle, int  MaterialIndex, float  Width);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialOutLineWidth")]
		extern static int  dx_MV1SetMaterialOutLineWidth_x64( int  MHandle, int  MaterialIndex, float  Width);
		public static int  MV1SetMaterialOutLineWidth( int  MHandle, int  MaterialIndex, float  Width)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialOutLineWidth_x86( MHandle , MaterialIndex , Width );
			}
			else
			{
				return dx_MV1SetMaterialOutLineWidth_x64( MHandle , MaterialIndex , Width );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialOutLineWidth")]
		extern static float  dx_MV1GetMaterialOutLineWidth_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialOutLineWidth")]
		extern static float  dx_MV1GetMaterialOutLineWidth_x64( int  MHandle, int  MaterialIndex);
		public static float  MV1GetMaterialOutLineWidth( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialOutLineWidth_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialOutLineWidth_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialOutLineDotWidth")]
		extern static int  dx_MV1SetMaterialOutLineDotWidth_x86( int  MHandle, int  MaterialIndex, float  Width);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialOutLineDotWidth")]
		extern static int  dx_MV1SetMaterialOutLineDotWidth_x64( int  MHandle, int  MaterialIndex, float  Width);
		public static int  MV1SetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex, float  Width)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialOutLineDotWidth_x86( MHandle , MaterialIndex , Width );
			}
			else
			{
				return dx_MV1SetMaterialOutLineDotWidth_x64( MHandle , MaterialIndex , Width );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialOutLineDotWidth")]
		extern static float  dx_MV1GetMaterialOutLineDotWidth_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialOutLineDotWidth")]
		extern static float  dx_MV1GetMaterialOutLineDotWidth_x64( int  MHandle, int  MaterialIndex);
		public static float  MV1GetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialOutLineDotWidth_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialOutLineDotWidth_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialOutLineColor")]
		extern static int  dx_MV1SetMaterialOutLineColor_x86( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialOutLineColor")]
		extern static int  dx_MV1SetMaterialOutLineColor_x64( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialOutLineColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialOutLineColor_x86( MHandle , MaterialIndex , Color );
			}
			else
			{
				return dx_MV1SetMaterialOutLineColor_x64( MHandle , MaterialIndex , Color );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialOutLineColor")]
		extern static COLOR_F  dx_MV1GetMaterialOutLineColor_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialOutLineColor")]
		extern static COLOR_F  dx_MV1GetMaterialOutLineColor_x64( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialOutLineColor( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialOutLineColor_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialOutLineColor_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDrawBlendMode")]
		extern static int  dx_MV1SetMaterialDrawBlendMode_x86( int  MHandle, int  MaterialIndex, int  BlendMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialDrawBlendMode")]
		extern static int  dx_MV1SetMaterialDrawBlendMode_x64( int  MHandle, int  MaterialIndex, int  BlendMode);
		public static int  MV1SetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex, int  BlendMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialDrawBlendMode_x86( MHandle , MaterialIndex , BlendMode );
			}
			else
			{
				return dx_MV1SetMaterialDrawBlendMode_x64( MHandle , MaterialIndex , BlendMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDrawBlendMode")]
		extern static int  dx_MV1GetMaterialDrawBlendMode_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialDrawBlendMode")]
		extern static int  dx_MV1GetMaterialDrawBlendMode_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialDrawBlendMode_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialDrawBlendMode_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMaterialDrawBlendParam")]
		extern static int  dx_MV1SetMaterialDrawBlendParam_x86( int  MHandle, int  MaterialIndex, int  BlendParam);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMaterialDrawBlendParam")]
		extern static int  dx_MV1SetMaterialDrawBlendParam_x64( int  MHandle, int  MaterialIndex, int  BlendParam);
		public static int  MV1SetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex, int  BlendParam)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMaterialDrawBlendParam_x86( MHandle , MaterialIndex , BlendParam );
			}
			else
			{
				return dx_MV1SetMaterialDrawBlendParam_x64( MHandle , MaterialIndex , BlendParam );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMaterialDrawBlendParam")]
		extern static int  dx_MV1GetMaterialDrawBlendParam_x86( int  MHandle, int  MaterialIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMaterialDrawBlendParam")]
		extern static int  dx_MV1GetMaterialDrawBlendParam_x64( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMaterialDrawBlendParam_x86( MHandle , MaterialIndex );
			}
			else
			{
				return dx_MV1GetMaterialDrawBlendParam_x64( MHandle , MaterialIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureNum")]
		extern static int  dx_MV1GetTextureNum_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureNum")]
		extern static int  dx_MV1GetTextureNum_x64( int  MHandle);
		public static int  MV1GetTextureNum( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureNum_x86( MHandle );
			}
			else
			{
				return dx_MV1GetTextureNum_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureColorFilePath")]
		extern static int  dx_MV1SetTextureColorFilePath_x86( int  MHandle, int  TexIndex, string  FilePath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetTextureColorFilePath")]
		extern static int  dx_MV1SetTextureColorFilePath_x64( int  MHandle, int  TexIndex, string  FilePath);
		public static int  MV1SetTextureColorFilePath( int  MHandle, int  TexIndex, string  FilePath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetTextureColorFilePath_x86( MHandle , TexIndex , FilePath );
			}
			else
			{
				return dx_MV1SetTextureColorFilePath_x64( MHandle , TexIndex , FilePath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureAlphaFilePath")]
		extern static int  dx_MV1SetTextureAlphaFilePath_x86( int  MHandle, int  TexIndex, string  FilePath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetTextureAlphaFilePath")]
		extern static int  dx_MV1SetTextureAlphaFilePath_x64( int  MHandle, int  TexIndex, string  FilePath);
		public static int  MV1SetTextureAlphaFilePath( int  MHandle, int  TexIndex, string  FilePath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetTextureAlphaFilePath_x86( MHandle , TexIndex , FilePath );
			}
			else
			{
				return dx_MV1SetTextureAlphaFilePath_x64( MHandle , TexIndex , FilePath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureGraphHandle")]
		extern static int  dx_MV1SetTextureGraphHandle_x86( int  MHandle, int  TexIndex, int  GrHandle, int  SemiTransFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetTextureGraphHandle")]
		extern static int  dx_MV1SetTextureGraphHandle_x64( int  MHandle, int  TexIndex, int  GrHandle, int  SemiTransFlag);
		public static int  MV1SetTextureGraphHandle( int  MHandle, int  TexIndex, int  GrHandle, int  SemiTransFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetTextureGraphHandle_x86( MHandle , TexIndex , GrHandle , SemiTransFlag );
			}
			else
			{
				return dx_MV1SetTextureGraphHandle_x64( MHandle , TexIndex , GrHandle , SemiTransFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureGraphHandle")]
		extern static int  dx_MV1GetTextureGraphHandle_x86( int  MHandle, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureGraphHandle")]
		extern static int  dx_MV1GetTextureGraphHandle_x64( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureGraphHandle( int  MHandle, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureGraphHandle_x86( MHandle , TexIndex );
			}
			else
			{
				return dx_MV1GetTextureGraphHandle_x64( MHandle , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureAddressMode")]
		extern static int  dx_MV1SetTextureAddressMode_x86( int  MHandle, int  TexIndex, int  AddrUMode, int  AddrVMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetTextureAddressMode")]
		extern static int  dx_MV1SetTextureAddressMode_x64( int  MHandle, int  TexIndex, int  AddrUMode, int  AddrVMode);
		public static int  MV1SetTextureAddressMode( int  MHandle, int  TexIndex, int  AddrUMode, int  AddrVMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetTextureAddressMode_x86( MHandle , TexIndex , AddrUMode , AddrVMode );
			}
			else
			{
				return dx_MV1SetTextureAddressMode_x64( MHandle , TexIndex , AddrUMode , AddrVMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureAddressModeU")]
		extern static int  dx_MV1GetTextureAddressModeU_x86( int  MHandle, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureAddressModeU")]
		extern static int  dx_MV1GetTextureAddressModeU_x64( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureAddressModeU( int  MHandle, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureAddressModeU_x86( MHandle , TexIndex );
			}
			else
			{
				return dx_MV1GetTextureAddressModeU_x64( MHandle , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureAddressModeV")]
		extern static int  dx_MV1GetTextureAddressModeV_x86( int  MHandle, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureAddressModeV")]
		extern static int  dx_MV1GetTextureAddressModeV_x64( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureAddressModeV( int  MHandle, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureAddressModeV_x86( MHandle , TexIndex );
			}
			else
			{
				return dx_MV1GetTextureAddressModeV_x64( MHandle , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureWidth")]
		extern static int  dx_MV1GetTextureWidth_x86( int  MHandle, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureWidth")]
		extern static int  dx_MV1GetTextureWidth_x64( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureWidth( int  MHandle, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureWidth_x86( MHandle , TexIndex );
			}
			else
			{
				return dx_MV1GetTextureWidth_x64( MHandle , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureHeight")]
		extern static int  dx_MV1GetTextureHeight_x86( int  MHandle, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureHeight")]
		extern static int  dx_MV1GetTextureHeight_x64( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureHeight( int  MHandle, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureHeight_x86( MHandle , TexIndex );
			}
			else
			{
				return dx_MV1GetTextureHeight_x64( MHandle , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureSemiTransState")]
		extern static int  dx_MV1GetTextureSemiTransState_x86( int  MHandle, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureSemiTransState")]
		extern static int  dx_MV1GetTextureSemiTransState_x64( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureSemiTransState( int  MHandle, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureSemiTransState_x86( MHandle , TexIndex );
			}
			else
			{
				return dx_MV1GetTextureSemiTransState_x64( MHandle , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureBumpImageFlag")]
		extern static int  dx_MV1SetTextureBumpImageFlag_x86( int  MHandle, int  TexIndex, int  Flag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetTextureBumpImageFlag")]
		extern static int  dx_MV1SetTextureBumpImageFlag_x64( int  MHandle, int  TexIndex, int  Flag);
		public static int  MV1SetTextureBumpImageFlag( int  MHandle, int  TexIndex, int  Flag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetTextureBumpImageFlag_x86( MHandle , TexIndex , Flag );
			}
			else
			{
				return dx_MV1SetTextureBumpImageFlag_x64( MHandle , TexIndex , Flag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureBumpImageFlag")]
		extern static int  dx_MV1GetTextureBumpImageFlag_x86( int  MHandle, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureBumpImageFlag")]
		extern static int  dx_MV1GetTextureBumpImageFlag_x64( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureBumpImageFlag( int  MHandle, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureBumpImageFlag_x86( MHandle , TexIndex );
			}
			else
			{
				return dx_MV1GetTextureBumpImageFlag_x64( MHandle , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureBumpImageNextPixelLength")]
		extern static int  dx_MV1SetTextureBumpImageNextPixelLength_x86( int  MHandle, int  TexIndex, float  Length);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetTextureBumpImageNextPixelLength")]
		extern static int  dx_MV1SetTextureBumpImageNextPixelLength_x64( int  MHandle, int  TexIndex, float  Length);
		public static int  MV1SetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex, float  Length)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetTextureBumpImageNextPixelLength_x86( MHandle , TexIndex , Length );
			}
			else
			{
				return dx_MV1SetTextureBumpImageNextPixelLength_x64( MHandle , TexIndex , Length );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureBumpImageNextPixelLength")]
		extern static float  dx_MV1GetTextureBumpImageNextPixelLength_x86( int  MHandle, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureBumpImageNextPixelLength")]
		extern static float  dx_MV1GetTextureBumpImageNextPixelLength_x64( int  MHandle, int  TexIndex);
		public static float  MV1GetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureBumpImageNextPixelLength_x86( MHandle , TexIndex );
			}
			else
			{
				return dx_MV1GetTextureBumpImageNextPixelLength_x64( MHandle , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetTextureSampleFilterMode")]
		extern static int  dx_MV1SetTextureSampleFilterMode_x86( int  MHandle, int  TexIndex, int  FilterMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetTextureSampleFilterMode")]
		extern static int  dx_MV1SetTextureSampleFilterMode_x64( int  MHandle, int  TexIndex, int  FilterMode);
		public static int  MV1SetTextureSampleFilterMode( int  MHandle, int  TexIndex, int  FilterMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetTextureSampleFilterMode_x86( MHandle , TexIndex , FilterMode );
			}
			else
			{
				return dx_MV1SetTextureSampleFilterMode_x64( MHandle , TexIndex , FilterMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTextureSampleFilterMode")]
		extern static int  dx_MV1GetTextureSampleFilterMode_x86( int  MHandle, int  TexIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTextureSampleFilterMode")]
		extern static int  dx_MV1GetTextureSampleFilterMode_x64( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureSampleFilterMode( int  MHandle, int  TexIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTextureSampleFilterMode_x86( MHandle , TexIndex );
			}
			else
			{
				return dx_MV1GetTextureSampleFilterMode_x64( MHandle , TexIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1LoadTexture")]
		extern static int  dx_MV1LoadTexture_x86( string  FilePath);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1LoadTexture")]
		extern static int  dx_MV1LoadTexture_x64( string  FilePath);
		public static int  MV1LoadTexture( string  FilePath)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1LoadTexture_x86( FilePath );
			}
			else
			{
				return dx_MV1LoadTexture_x64( FilePath );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameNum")]
		extern static int  dx_MV1GetFrameNum_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameNum")]
		extern static int  dx_MV1GetFrameNum_x64( int  MHandle);
		public static int  MV1GetFrameNum( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameNum_x86( MHandle );
			}
			else
			{
				return dx_MV1GetFrameNum_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SearchFrame")]
		extern static int  dx_MV1SearchFrame_x86( int  MHandle, string  FrameName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SearchFrame")]
		extern static int  dx_MV1SearchFrame_x64( int  MHandle, string  FrameName);
		public static int  MV1SearchFrame( int  MHandle, string  FrameName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SearchFrame_x86( MHandle , FrameName );
			}
			else
			{
				return dx_MV1SearchFrame_x64( MHandle , FrameName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SearchFrameChild")]
		extern static int  dx_MV1SearchFrameChild_x86( int  MHandle, int  FrameIndex, string  ChildName);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SearchFrameChild")]
		extern static int  dx_MV1SearchFrameChild_x64( int  MHandle, int  FrameIndex, string  ChildName);
		public static int  MV1SearchFrameChild( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SearchFrameChild_x86( MHandle , -1 , null );
			}
			else
			{
				return dx_MV1SearchFrameChild_x64( MHandle , -1 , null );
			}
		}
		public static int  MV1SearchFrameChild( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SearchFrameChild_x86( MHandle , FrameIndex , null );
			}
			else
			{
				return dx_MV1SearchFrameChild_x64( MHandle , FrameIndex , null );
			}
		}
		public static int  MV1SearchFrameChild( int  MHandle, int  FrameIndex, string  ChildName)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SearchFrameChild_x86( MHandle , FrameIndex , ChildName );
			}
			else
			{
				return dx_MV1SearchFrameChild_x64( MHandle , FrameIndex , ChildName );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameParent")]
		extern static int  dx_MV1GetFrameParent_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameParent")]
		extern static int  dx_MV1GetFrameParent_x64( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameParent( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameParent_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameParent_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameChildNum")]
		extern static int  dx_MV1GetFrameChildNum_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameChildNum")]
		extern static int  dx_MV1GetFrameChildNum_x64( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameChildNum( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameChildNum_x86( MHandle , -1 );
			}
			else
			{
				return dx_MV1GetFrameChildNum_x64( MHandle , -1 );
			}
		}
		public static int  MV1GetFrameChildNum( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameChildNum_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameChildNum_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameChild")]
		extern static int  dx_MV1GetFrameChild_x86( int  MHandle, int  FrameIndex, int  ChildIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameChild")]
		extern static int  dx_MV1GetFrameChild_x64( int  MHandle, int  FrameIndex, int  ChildIndex);
		public static int  MV1GetFrameChild( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameChild_x86( MHandle , -1 , 0 );
			}
			else
			{
				return dx_MV1GetFrameChild_x64( MHandle , -1 , 0 );
			}
		}
		public static int  MV1GetFrameChild( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameChild_x86( MHandle , FrameIndex , 0 );
			}
			else
			{
				return dx_MV1GetFrameChild_x64( MHandle , FrameIndex , 0 );
			}
		}
		public static int  MV1GetFrameChild( int  MHandle, int  FrameIndex, int  ChildIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameChild_x86( MHandle , FrameIndex , ChildIndex );
			}
			else
			{
				return dx_MV1GetFrameChild_x64( MHandle , FrameIndex , ChildIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFramePosition")]
		extern static VECTOR  dx_MV1GetFramePosition_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFramePosition")]
		extern static VECTOR  dx_MV1GetFramePosition_x64( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFramePosition( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFramePosition_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFramePosition_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameBaseLocalMatrix")]
		extern static MATRIX  dx_MV1GetFrameBaseLocalMatrix_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameBaseLocalMatrix")]
		extern static MATRIX  dx_MV1GetFrameBaseLocalMatrix_x64( int  MHandle, int  FrameIndex);
		public static MATRIX  MV1GetFrameBaseLocalMatrix( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameBaseLocalMatrix_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameBaseLocalMatrix_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameLocalMatrix")]
		extern static MATRIX  dx_MV1GetFrameLocalMatrix_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameLocalMatrix")]
		extern static MATRIX  dx_MV1GetFrameLocalMatrix_x64( int  MHandle, int  FrameIndex);
		public static MATRIX  MV1GetFrameLocalMatrix( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameLocalMatrix_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameLocalMatrix_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameLocalWorldMatrix")]
		extern static MATRIX  dx_MV1GetFrameLocalWorldMatrix_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameLocalWorldMatrix")]
		extern static MATRIX  dx_MV1GetFrameLocalWorldMatrix_x64( int  MHandle, int  FrameIndex);
		public static MATRIX  MV1GetFrameLocalWorldMatrix( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameLocalWorldMatrix_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameLocalWorldMatrix_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameUserLocalMatrix")]
		extern static int  dx_MV1SetFrameUserLocalMatrix_x86( int  MHandle, int  FrameIndex, MATRIX  Matrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameUserLocalMatrix")]
		extern static int  dx_MV1SetFrameUserLocalMatrix_x64( int  MHandle, int  FrameIndex, MATRIX  Matrix);
		public static int  MV1SetFrameUserLocalMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameUserLocalMatrix_x86( MHandle , FrameIndex , Matrix );
			}
			else
			{
				return dx_MV1SetFrameUserLocalMatrix_x64( MHandle , FrameIndex , Matrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1ResetFrameUserLocalMatrix")]
		extern static int  dx_MV1ResetFrameUserLocalMatrix_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1ResetFrameUserLocalMatrix")]
		extern static int  dx_MV1ResetFrameUserLocalMatrix_x64( int  MHandle, int  FrameIndex);
		public static int  MV1ResetFrameUserLocalMatrix( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1ResetFrameUserLocalMatrix_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1ResetFrameUserLocalMatrix_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameMaxVertexLocalPosition")]
		extern static VECTOR  dx_MV1GetFrameMaxVertexLocalPosition_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameMaxVertexLocalPosition")]
		extern static VECTOR  dx_MV1GetFrameMaxVertexLocalPosition_x64( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFrameMaxVertexLocalPosition( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameMaxVertexLocalPosition_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameMaxVertexLocalPosition_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameMinVertexLocalPosition")]
		extern static VECTOR  dx_MV1GetFrameMinVertexLocalPosition_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameMinVertexLocalPosition")]
		extern static VECTOR  dx_MV1GetFrameMinVertexLocalPosition_x64( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFrameMinVertexLocalPosition( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameMinVertexLocalPosition_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameMinVertexLocalPosition_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameAvgVertexLocalPosition")]
		extern static VECTOR  dx_MV1GetFrameAvgVertexLocalPosition_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameAvgVertexLocalPosition")]
		extern static VECTOR  dx_MV1GetFrameAvgVertexLocalPosition_x64( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFrameAvgVertexLocalPosition( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameAvgVertexLocalPosition_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameAvgVertexLocalPosition_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameTriangleNum")]
		extern static int  dx_MV1GetFrameTriangleNum_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameTriangleNum")]
		extern static int  dx_MV1GetFrameTriangleNum_x64( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameTriangleNum( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameTriangleNum_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameTriangleNum_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameMeshNum")]
		extern static int  dx_MV1GetFrameMeshNum_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameMeshNum")]
		extern static int  dx_MV1GetFrameMeshNum_x64( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameMeshNum( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameMeshNum_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameMeshNum_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameMesh")]
		extern static int  dx_MV1GetFrameMesh_x86( int  MHandle, int  FrameIndex, int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameMesh")]
		extern static int  dx_MV1GetFrameMesh_x64( int  MHandle, int  FrameIndex, int  Index);
		public static int  MV1GetFrameMesh( int  MHandle, int  FrameIndex, int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameMesh_x86( MHandle , FrameIndex , Index );
			}
			else
			{
				return dx_MV1GetFrameMesh_x64( MHandle , FrameIndex , Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameVisible")]
		extern static int  dx_MV1SetFrameVisible_x86( int  MHandle, int  FrameIndex, int  VisibleFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameVisible")]
		extern static int  dx_MV1SetFrameVisible_x64( int  MHandle, int  FrameIndex, int  VisibleFlag);
		public static int  MV1SetFrameVisible( int  MHandle, int  FrameIndex, int  VisibleFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameVisible_x86( MHandle , FrameIndex , VisibleFlag );
			}
			else
			{
				return dx_MV1SetFrameVisible_x64( MHandle , FrameIndex , VisibleFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameVisible")]
		extern static int  dx_MV1GetFrameVisible_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameVisible")]
		extern static int  dx_MV1GetFrameVisible_x64( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameVisible( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameVisible_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameVisible_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameDifColorScale")]
		extern static int  dx_MV1SetFrameDifColorScale_x86( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameDifColorScale")]
		extern static int  dx_MV1SetFrameDifColorScale_x64( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameDifColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameDifColorScale_x86( MHandle , FrameIndex , Scale );
			}
			else
			{
				return dx_MV1SetFrameDifColorScale_x64( MHandle , FrameIndex , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameSpcColorScale")]
		extern static int  dx_MV1SetFrameSpcColorScale_x86( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameSpcColorScale")]
		extern static int  dx_MV1SetFrameSpcColorScale_x64( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameSpcColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameSpcColorScale_x86( MHandle , FrameIndex , Scale );
			}
			else
			{
				return dx_MV1SetFrameSpcColorScale_x64( MHandle , FrameIndex , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameEmiColorScale")]
		extern static int  dx_MV1SetFrameEmiColorScale_x86( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameEmiColorScale")]
		extern static int  dx_MV1SetFrameEmiColorScale_x64( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameEmiColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameEmiColorScale_x86( MHandle , FrameIndex , Scale );
			}
			else
			{
				return dx_MV1SetFrameEmiColorScale_x64( MHandle , FrameIndex , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameAmbColorScale")]
		extern static int  dx_MV1SetFrameAmbColorScale_x86( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameAmbColorScale")]
		extern static int  dx_MV1SetFrameAmbColorScale_x64( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameAmbColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameAmbColorScale_x86( MHandle , FrameIndex , Scale );
			}
			else
			{
				return dx_MV1SetFrameAmbColorScale_x64( MHandle , FrameIndex , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameDifColorScale")]
		extern static COLOR_F  dx_MV1GetFrameDifColorScale_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameDifColorScale")]
		extern static COLOR_F  dx_MV1GetFrameDifColorScale_x64( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameDifColorScale( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameDifColorScale_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameDifColorScale_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameSpcColorScale")]
		extern static COLOR_F  dx_MV1GetFrameSpcColorScale_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameSpcColorScale")]
		extern static COLOR_F  dx_MV1GetFrameSpcColorScale_x64( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameSpcColorScale( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameSpcColorScale_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameSpcColorScale_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameEmiColorScale")]
		extern static COLOR_F  dx_MV1GetFrameEmiColorScale_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameEmiColorScale")]
		extern static COLOR_F  dx_MV1GetFrameEmiColorScale_x64( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameEmiColorScale( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameEmiColorScale_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameEmiColorScale_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameAmbColorScale")]
		extern static COLOR_F  dx_MV1GetFrameAmbColorScale_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameAmbColorScale")]
		extern static COLOR_F  dx_MV1GetFrameAmbColorScale_x64( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameAmbColorScale( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameAmbColorScale_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameAmbColorScale_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameSemiTransState")]
		extern static int  dx_MV1GetFrameSemiTransState_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameSemiTransState")]
		extern static int  dx_MV1GetFrameSemiTransState_x64( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameSemiTransState( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameSemiTransState_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameSemiTransState_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameOpacityRate")]
		extern static int  dx_MV1SetFrameOpacityRate_x86( int  MHandle, int  FrameIndex, float  Rate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameOpacityRate")]
		extern static int  dx_MV1SetFrameOpacityRate_x64( int  MHandle, int  FrameIndex, float  Rate);
		public static int  MV1SetFrameOpacityRate( int  MHandle, int  FrameIndex, float  Rate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameOpacityRate_x86( MHandle , FrameIndex , Rate );
			}
			else
			{
				return dx_MV1SetFrameOpacityRate_x64( MHandle , FrameIndex , Rate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameOpacityRate")]
		extern static float  dx_MV1GetFrameOpacityRate_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameOpacityRate")]
		extern static float  dx_MV1GetFrameOpacityRate_x64( int  MHandle, int  FrameIndex);
		public static float  MV1GetFrameOpacityRate( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameOpacityRate_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameOpacityRate_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameBaseVisible")]
		extern static int  dx_MV1SetFrameBaseVisible_x86( int  MHandle, int  FrameIndex, int  VisibleFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameBaseVisible")]
		extern static int  dx_MV1SetFrameBaseVisible_x64( int  MHandle, int  FrameIndex, int  VisibleFlag);
		public static int  MV1SetFrameBaseVisible( int  MHandle, int  FrameIndex, int  VisibleFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameBaseVisible_x86( MHandle , FrameIndex , VisibleFlag );
			}
			else
			{
				return dx_MV1SetFrameBaseVisible_x64( MHandle , FrameIndex , VisibleFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetFrameBaseVisible")]
		extern static int  dx_MV1GetFrameBaseVisible_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetFrameBaseVisible")]
		extern static int  dx_MV1GetFrameBaseVisible_x64( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameBaseVisible( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetFrameBaseVisible_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1GetFrameBaseVisible_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameTextureAddressTransform")]
		extern static int  dx_MV1SetFrameTextureAddressTransform_x86( int  MHandle, int  FrameIndex, float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameTextureAddressTransform")]
		extern static int  dx_MV1SetFrameTextureAddressTransform_x64( int  MHandle, int  FrameIndex, float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate);
		public static int  MV1SetFrameTextureAddressTransform( int  MHandle, int  FrameIndex, float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameTextureAddressTransform_x86( MHandle , FrameIndex , TransU , TransV , ScaleU , ScaleV , RotCenterU , RotCenterV , Rotate );
			}
			else
			{
				return dx_MV1SetFrameTextureAddressTransform_x64( MHandle , FrameIndex , TransU , TransV , ScaleU , ScaleV , RotCenterU , RotCenterV , Rotate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetFrameTextureAddressTransformMatrix")]
		extern static int  dx_MV1SetFrameTextureAddressTransformMatrix_x86( int  MHandle, int  FrameIndex, MATRIX  Matrix);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetFrameTextureAddressTransformMatrix")]
		extern static int  dx_MV1SetFrameTextureAddressTransformMatrix_x64( int  MHandle, int  FrameIndex, MATRIX  Matrix);
		public static int  MV1SetFrameTextureAddressTransformMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetFrameTextureAddressTransformMatrix_x86( MHandle , FrameIndex , Matrix );
			}
			else
			{
				return dx_MV1SetFrameTextureAddressTransformMatrix_x64( MHandle , FrameIndex , Matrix );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1ResetFrameTextureAddressTransform")]
		extern static int  dx_MV1ResetFrameTextureAddressTransform_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1ResetFrameTextureAddressTransform")]
		extern static int  dx_MV1ResetFrameTextureAddressTransform_x64( int  MHandle, int  FrameIndex);
		public static int  MV1ResetFrameTextureAddressTransform( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1ResetFrameTextureAddressTransform_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1ResetFrameTextureAddressTransform_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshNum")]
		extern static int  dx_MV1GetMeshNum_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshNum")]
		extern static int  dx_MV1GetMeshNum_x64( int  MHandle);
		public static int  MV1GetMeshNum( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshNum_x86( MHandle );
			}
			else
			{
				return dx_MV1GetMeshNum_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshMaterial")]
		extern static int  dx_MV1GetMeshMaterial_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshMaterial")]
		extern static int  dx_MV1GetMeshMaterial_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshMaterial( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshMaterial_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshMaterial_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshTriangleNum")]
		extern static int  dx_MV1GetMeshTriangleNum_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshTriangleNum")]
		extern static int  dx_MV1GetMeshTriangleNum_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshTriangleNum( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshTriangleNum_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshTriangleNum_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshVisible")]
		extern static int  dx_MV1SetMeshVisible_x86( int  MHandle, int  MeshIndex, int  VisibleFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshVisible")]
		extern static int  dx_MV1SetMeshVisible_x64( int  MHandle, int  MeshIndex, int  VisibleFlag);
		public static int  MV1SetMeshVisible( int  MHandle, int  MeshIndex, int  VisibleFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshVisible_x86( MHandle , MeshIndex , VisibleFlag );
			}
			else
			{
				return dx_MV1SetMeshVisible_x64( MHandle , MeshIndex , VisibleFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshVisible")]
		extern static int  dx_MV1GetMeshVisible_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshVisible")]
		extern static int  dx_MV1GetMeshVisible_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshVisible( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshVisible_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshVisible_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshDifColorScale")]
		extern static int  dx_MV1SetMeshDifColorScale_x86( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshDifColorScale")]
		extern static int  dx_MV1SetMeshDifColorScale_x64( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshDifColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshDifColorScale_x86( MHandle , MeshIndex , Scale );
			}
			else
			{
				return dx_MV1SetMeshDifColorScale_x64( MHandle , MeshIndex , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshSpcColorScale")]
		extern static int  dx_MV1SetMeshSpcColorScale_x86( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshSpcColorScale")]
		extern static int  dx_MV1SetMeshSpcColorScale_x64( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshSpcColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshSpcColorScale_x86( MHandle , MeshIndex , Scale );
			}
			else
			{
				return dx_MV1SetMeshSpcColorScale_x64( MHandle , MeshIndex , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshEmiColorScale")]
		extern static int  dx_MV1SetMeshEmiColorScale_x86( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshEmiColorScale")]
		extern static int  dx_MV1SetMeshEmiColorScale_x64( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshEmiColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshEmiColorScale_x86( MHandle , MeshIndex , Scale );
			}
			else
			{
				return dx_MV1SetMeshEmiColorScale_x64( MHandle , MeshIndex , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshAmbColorScale")]
		extern static int  dx_MV1SetMeshAmbColorScale_x86( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshAmbColorScale")]
		extern static int  dx_MV1SetMeshAmbColorScale_x64( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshAmbColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshAmbColorScale_x86( MHandle , MeshIndex , Scale );
			}
			else
			{
				return dx_MV1SetMeshAmbColorScale_x64( MHandle , MeshIndex , Scale );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshDifColorScale")]
		extern static COLOR_F  dx_MV1GetMeshDifColorScale_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshDifColorScale")]
		extern static COLOR_F  dx_MV1GetMeshDifColorScale_x64( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshDifColorScale( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshDifColorScale_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshDifColorScale_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshSpcColorScale")]
		extern static COLOR_F  dx_MV1GetMeshSpcColorScale_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshSpcColorScale")]
		extern static COLOR_F  dx_MV1GetMeshSpcColorScale_x64( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshSpcColorScale( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshSpcColorScale_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshSpcColorScale_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshEmiColorScale")]
		extern static COLOR_F  dx_MV1GetMeshEmiColorScale_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshEmiColorScale")]
		extern static COLOR_F  dx_MV1GetMeshEmiColorScale_x64( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshEmiColorScale( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshEmiColorScale_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshEmiColorScale_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshAmbColorScale")]
		extern static COLOR_F  dx_MV1GetMeshAmbColorScale_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshAmbColorScale")]
		extern static COLOR_F  dx_MV1GetMeshAmbColorScale_x64( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshAmbColorScale( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshAmbColorScale_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshAmbColorScale_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshOpacityRate")]
		extern static int  dx_MV1SetMeshOpacityRate_x86( int  MHandle, int  MeshIndex, float  Rate);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshOpacityRate")]
		extern static int  dx_MV1SetMeshOpacityRate_x64( int  MHandle, int  MeshIndex, float  Rate);
		public static int  MV1SetMeshOpacityRate( int  MHandle, int  MeshIndex, float  Rate)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshOpacityRate_x86( MHandle , MeshIndex , Rate );
			}
			else
			{
				return dx_MV1SetMeshOpacityRate_x64( MHandle , MeshIndex , Rate );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshOpacityRate")]
		extern static float  dx_MV1GetMeshOpacityRate_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshOpacityRate")]
		extern static float  dx_MV1GetMeshOpacityRate_x64( int  MHandle, int  MeshIndex);
		public static float  MV1GetMeshOpacityRate( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshOpacityRate_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshOpacityRate_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshDrawBlendMode")]
		extern static int  dx_MV1SetMeshDrawBlendMode_x86( int  MHandle, int  MeshIndex, int  BlendMode);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshDrawBlendMode")]
		extern static int  dx_MV1SetMeshDrawBlendMode_x64( int  MHandle, int  MeshIndex, int  BlendMode);
		public static int  MV1SetMeshDrawBlendMode( int  MHandle, int  MeshIndex, int  BlendMode)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshDrawBlendMode_x86( MHandle , MeshIndex , BlendMode );
			}
			else
			{
				return dx_MV1SetMeshDrawBlendMode_x64( MHandle , MeshIndex , BlendMode );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshDrawBlendParam")]
		extern static int  dx_MV1SetMeshDrawBlendParam_x86( int  MHandle, int  MeshIndex, int  BlendParam);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshDrawBlendParam")]
		extern static int  dx_MV1SetMeshDrawBlendParam_x64( int  MHandle, int  MeshIndex, int  BlendParam);
		public static int  MV1SetMeshDrawBlendParam( int  MHandle, int  MeshIndex, int  BlendParam)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshDrawBlendParam_x86( MHandle , MeshIndex , BlendParam );
			}
			else
			{
				return dx_MV1SetMeshDrawBlendParam_x64( MHandle , MeshIndex , BlendParam );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshDrawBlendMode")]
		extern static int  dx_MV1GetMeshDrawBlendMode_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshDrawBlendMode")]
		extern static int  dx_MV1GetMeshDrawBlendMode_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshDrawBlendMode( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshDrawBlendMode_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshDrawBlendMode_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshDrawBlendParam")]
		extern static int  dx_MV1GetMeshDrawBlendParam_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshDrawBlendParam")]
		extern static int  dx_MV1GetMeshDrawBlendParam_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshDrawBlendParam( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshDrawBlendParam_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshDrawBlendParam_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshBaseVisible")]
		extern static int  dx_MV1SetMeshBaseVisible_x86( int  MHandle, int  MeshIndex, int  VisibleFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshBaseVisible")]
		extern static int  dx_MV1SetMeshBaseVisible_x64( int  MHandle, int  MeshIndex, int  VisibleFlag);
		public static int  MV1SetMeshBaseVisible( int  MHandle, int  MeshIndex, int  VisibleFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshBaseVisible_x86( MHandle , MeshIndex , VisibleFlag );
			}
			else
			{
				return dx_MV1SetMeshBaseVisible_x64( MHandle , MeshIndex , VisibleFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshBaseVisible")]
		extern static int  dx_MV1GetMeshBaseVisible_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshBaseVisible")]
		extern static int  dx_MV1GetMeshBaseVisible_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshBaseVisible( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshBaseVisible_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshBaseVisible_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshBackCulling")]
		extern static int  dx_MV1SetMeshBackCulling_x86( int  MHandle, int  MeshIndex, int  CullingFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshBackCulling")]
		extern static int  dx_MV1SetMeshBackCulling_x64( int  MHandle, int  MeshIndex, int  CullingFlag);
		public static int  MV1SetMeshBackCulling( int  MHandle, int  MeshIndex, int  CullingFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshBackCulling_x86( MHandle , MeshIndex , CullingFlag );
			}
			else
			{
				return dx_MV1SetMeshBackCulling_x64( MHandle , MeshIndex , CullingFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshBackCulling")]
		extern static int  dx_MV1GetMeshBackCulling_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshBackCulling")]
		extern static int  dx_MV1GetMeshBackCulling_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshBackCulling( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshBackCulling_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshBackCulling_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshMaxPosition")]
		extern static VECTOR  dx_MV1GetMeshMaxPosition_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshMaxPosition")]
		extern static VECTOR  dx_MV1GetMeshMaxPosition_x64( int  MHandle, int  MeshIndex);
		public static VECTOR  MV1GetMeshMaxPosition( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshMaxPosition_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshMaxPosition_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshMinPosition")]
		extern static VECTOR  dx_MV1GetMeshMinPosition_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshMinPosition")]
		extern static VECTOR  dx_MV1GetMeshMinPosition_x64( int  MHandle, int  MeshIndex);
		public static VECTOR  MV1GetMeshMinPosition( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshMinPosition_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshMinPosition_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshTListNum")]
		extern static int  dx_MV1GetMeshTListNum_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshTListNum")]
		extern static int  dx_MV1GetMeshTListNum_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshTListNum( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshTListNum_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshTListNum_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshTList")]
		extern static int  dx_MV1GetMeshTList_x86( int  MHandle, int  MeshIndex, int  Index);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshTList")]
		extern static int  dx_MV1GetMeshTList_x64( int  MHandle, int  MeshIndex, int  Index);
		public static int  MV1GetMeshTList( int  MHandle, int  MeshIndex, int  Index)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshTList_x86( MHandle , MeshIndex , Index );
			}
			else
			{
				return dx_MV1GetMeshTList_x64( MHandle , MeshIndex , Index );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshSemiTransState")]
		extern static int  dx_MV1GetMeshSemiTransState_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshSemiTransState")]
		extern static int  dx_MV1GetMeshSemiTransState_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshSemiTransState( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshSemiTransState_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshSemiTransState_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshUseVertDifColor")]
		extern static int  dx_MV1SetMeshUseVertDifColor_x86( int  MHandle, int  MeshIndex, int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshUseVertDifColor")]
		extern static int  dx_MV1SetMeshUseVertDifColor_x64( int  MHandle, int  MeshIndex, int  UseFlag);
		public static int  MV1SetMeshUseVertDifColor( int  MHandle, int  MeshIndex, int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshUseVertDifColor_x86( MHandle , MeshIndex , UseFlag );
			}
			else
			{
				return dx_MV1SetMeshUseVertDifColor_x64( MHandle , MeshIndex , UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetMeshUseVertSpcColor")]
		extern static int  dx_MV1SetMeshUseVertSpcColor_x86( int  MHandle, int  MeshIndex, int  UseFlag);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetMeshUseVertSpcColor")]
		extern static int  dx_MV1SetMeshUseVertSpcColor_x64( int  MHandle, int  MeshIndex, int  UseFlag);
		public static int  MV1SetMeshUseVertSpcColor( int  MHandle, int  MeshIndex, int  UseFlag)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetMeshUseVertSpcColor_x86( MHandle , MeshIndex , UseFlag );
			}
			else
			{
				return dx_MV1SetMeshUseVertSpcColor_x64( MHandle , MeshIndex , UseFlag );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshUseVertDifColor")]
		extern static int  dx_MV1GetMeshUseVertDifColor_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshUseVertDifColor")]
		extern static int  dx_MV1GetMeshUseVertDifColor_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshUseVertDifColor( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshUseVertDifColor_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshUseVertDifColor_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetMeshUseVertSpcColor")]
		extern static int  dx_MV1GetMeshUseVertSpcColor_x86( int  MHandle, int  MeshIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetMeshUseVertSpcColor")]
		extern static int  dx_MV1GetMeshUseVertSpcColor_x64( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshUseVertSpcColor( int  MHandle, int  MeshIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetMeshUseVertSpcColor_x86( MHandle , MeshIndex );
			}
			else
			{
				return dx_MV1GetMeshUseVertSpcColor_x64( MHandle , MeshIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTriangleListNum")]
		extern static int  dx_MV1GetTriangleListNum_x86( int  MHandle);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTriangleListNum")]
		extern static int  dx_MV1GetTriangleListNum_x64( int  MHandle);
		public static int  MV1GetTriangleListNum( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTriangleListNum_x86( MHandle );
			}
			else
			{
				return dx_MV1GetTriangleListNum_x64( MHandle );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTriangleListVertexType")]
		extern static int  dx_MV1GetTriangleListVertexType_x86( int  MHandle, int  TListIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTriangleListVertexType")]
		extern static int  dx_MV1GetTriangleListVertexType_x64( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListVertexType( int  MHandle, int  TListIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTriangleListVertexType_x86( MHandle , TListIndex );
			}
			else
			{
				return dx_MV1GetTriangleListVertexType_x64( MHandle , TListIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTriangleListPolygonNum")]
		extern static int  dx_MV1GetTriangleListPolygonNum_x86( int  MHandle, int  TListIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTriangleListPolygonNum")]
		extern static int  dx_MV1GetTriangleListPolygonNum_x64( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListPolygonNum( int  MHandle, int  TListIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTriangleListPolygonNum_x86( MHandle , TListIndex );
			}
			else
			{
				return dx_MV1GetTriangleListPolygonNum_x64( MHandle , TListIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1GetTriangleListVertexNum")]
		extern static int  dx_MV1GetTriangleListVertexNum_x86( int  MHandle, int  TListIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1GetTriangleListVertexNum")]
		extern static int  dx_MV1GetTriangleListVertexNum_x64( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListVertexNum( int  MHandle, int  TListIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1GetTriangleListVertexNum_x86( MHandle , TListIndex );
			}
			else
			{
				return dx_MV1GetTriangleListVertexNum_x64( MHandle , TListIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetupCollInfo")]
		extern static int  dx_MV1SetupCollInfo_x86( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum, int  ZDivNum);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetupCollInfo")]
		extern static int  dx_MV1SetupCollInfo_x64( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum, int  ZDivNum);
		public static int  MV1SetupCollInfo( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetupCollInfo_x86( MHandle , -1 , 32 , 8 , 32 );
			}
			else
			{
				return dx_MV1SetupCollInfo_x64( MHandle , -1 , 32 , 8 , 32 );
			}
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetupCollInfo_x86( MHandle , FrameIndex , 32 , 8 , 32 );
			}
			else
			{
				return dx_MV1SetupCollInfo_x64( MHandle , FrameIndex , 32 , 8 , 32 );
			}
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetupCollInfo_x86( MHandle , FrameIndex , XDivNum , 8 , 32 );
			}
			else
			{
				return dx_MV1SetupCollInfo_x64( MHandle , FrameIndex , XDivNum , 8 , 32 );
			}
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetupCollInfo_x86( MHandle , FrameIndex , XDivNum , YDivNum , 32 );
			}
			else
			{
				return dx_MV1SetupCollInfo_x64( MHandle , FrameIndex , XDivNum , YDivNum , 32 );
			}
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum, int  ZDivNum)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetupCollInfo_x86( MHandle , FrameIndex , XDivNum , YDivNum , ZDivNum );
			}
			else
			{
				return dx_MV1SetupCollInfo_x64( MHandle , FrameIndex , XDivNum , YDivNum , ZDivNum );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1TerminateCollInfo")]
		extern static int  dx_MV1TerminateCollInfo_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1TerminateCollInfo")]
		extern static int  dx_MV1TerminateCollInfo_x64( int  MHandle, int  FrameIndex);
		public static int  MV1TerminateCollInfo( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1TerminateCollInfo_x86( MHandle , -1 );
			}
			else
			{
				return dx_MV1TerminateCollInfo_x64( MHandle , -1 );
			}
		}
		public static int  MV1TerminateCollInfo( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1TerminateCollInfo_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1TerminateCollInfo_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1RefreshCollInfo")]
		extern static int  dx_MV1RefreshCollInfo_x86( int  MHandle, int  FrameIndex);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1RefreshCollInfo")]
		extern static int  dx_MV1RefreshCollInfo_x64( int  MHandle, int  FrameIndex);
		public static int  MV1RefreshCollInfo( int  MHandle)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1RefreshCollInfo_x86( MHandle , -1 );
			}
			else
			{
				return dx_MV1RefreshCollInfo_x64( MHandle , -1 );
			}
		}
		public static int  MV1RefreshCollInfo( int  MHandle, int  FrameIndex)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1RefreshCollInfo_x86( MHandle , FrameIndex );
			}
			else
			{
				return dx_MV1RefreshCollInfo_x64( MHandle , FrameIndex );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_Line")]
		extern static MV1_COLL_RESULT_POLY  dx_MV1CollCheck_Line_x86( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1CollCheck_Line")]
		extern static MV1_COLL_RESULT_POLY  dx_MV1CollCheck_Line_x64( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd);
		public static MV1_COLL_RESULT_POLY  MV1CollCheck_Line( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1CollCheck_Line_x86( MHandle , FrameIndex , PosStart , PosEnd );
			}
			else
			{
				return dx_MV1CollCheck_Line_x64( MHandle , FrameIndex , PosStart , PosEnd );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_LineDim")]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_LineDim_x86( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1CollCheck_LineDim")]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_LineDim_x64( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_LineDim( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1CollCheck_LineDim_x86( MHandle , FrameIndex , PosStart , PosEnd );
			}
			else
			{
				return dx_MV1CollCheck_LineDim_x64( MHandle , FrameIndex , PosStart , PosEnd );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_Sphere")]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_Sphere_x86( int  MHandle, int  FrameIndex, VECTOR  CenterPos, float  r);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1CollCheck_Sphere")]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_Sphere_x64( int  MHandle, int  FrameIndex, VECTOR  CenterPos, float  r);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Sphere( int  MHandle, int  FrameIndex, VECTOR  CenterPos, float  r)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1CollCheck_Sphere_x86( MHandle , FrameIndex , CenterPos , r );
			}
			else
			{
				return dx_MV1CollCheck_Sphere_x64( MHandle , FrameIndex , CenterPos , r );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_Capsule")]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_Capsule_x86( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, float  r);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1CollCheck_Capsule")]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_Capsule_x64( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, float  r);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Capsule( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, float  r)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1CollCheck_Capsule_x86( MHandle , FrameIndex , Pos1 , Pos2 , r );
			}
			else
			{
				return dx_MV1CollCheck_Capsule_x64( MHandle , FrameIndex , Pos1 , Pos2 , r );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollCheck_GetResultPoly")]
		extern static MV1_COLL_RESULT_POLY  dx_MV1CollCheck_GetResultPoly_x86( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim, int  PolyNo);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1CollCheck_GetResultPoly")]
		extern static MV1_COLL_RESULT_POLY  dx_MV1CollCheck_GetResultPoly_x64( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim, int  PolyNo);
		public static MV1_COLL_RESULT_POLY  MV1CollCheck_GetResultPoly( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim, int  PolyNo)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1CollCheck_GetResultPoly_x86( ResultPolyDim , PolyNo );
			}
			else
			{
				return dx_MV1CollCheck_GetResultPoly_x64( ResultPolyDim , PolyNo );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1CollResultPolyDimTerminate")]
		extern static int  dx_MV1CollResultPolyDimTerminate_x86( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1CollResultPolyDimTerminate")]
		extern static int  dx_MV1CollResultPolyDimTerminate_x64( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim);
		public static int  MV1CollResultPolyDimTerminate( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1CollResultPolyDimTerminate_x86( ResultPolyDim );
			}
			else
			{
				return dx_MV1CollResultPolyDimTerminate_x64( ResultPolyDim );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1SetupReferenceMesh")]
		extern static int  dx_MV1SetupReferenceMesh_x86( int  MHandle, int  FrameIndex, int  IsTransform);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1SetupReferenceMesh")]
		extern static int  dx_MV1SetupReferenceMesh_x64( int  MHandle, int  FrameIndex, int  IsTransform);
		public static int  MV1SetupReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1SetupReferenceMesh_x86( MHandle , FrameIndex , IsTransform );
			}
			else
			{
				return dx_MV1SetupReferenceMesh_x64( MHandle , FrameIndex , IsTransform );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1TerminateReferenceMesh")]
		extern static int  dx_MV1TerminateReferenceMesh_x86( int  MHandle, int  FrameIndex, int  IsTransform);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1TerminateReferenceMesh")]
		extern static int  dx_MV1TerminateReferenceMesh_x64( int  MHandle, int  FrameIndex, int  IsTransform);
		public static int  MV1TerminateReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1TerminateReferenceMesh_x86( MHandle , FrameIndex , IsTransform );
			}
			else
			{
				return dx_MV1TerminateReferenceMesh_x64( MHandle , FrameIndex , IsTransform );
			}
		}

		[DllImport("DxLib.dll", EntryPoint="dx_MV1RefreshReferenceMesh")]
		extern static int  dx_MV1RefreshReferenceMesh_x86( int  MHandle, int  FrameIndex, int  IsTransform);
		[DllImport("DxLib_x64.dll", EntryPoint="dx_MV1RefreshReferenceMesh")]
		extern static int  dx_MV1RefreshReferenceMesh_x64( int  MHandle, int  FrameIndex, int  IsTransform);
		public static int  MV1RefreshReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform)
		{
			if( System.IntPtr.Size == 4 )
			{
				return dx_MV1RefreshReferenceMesh_x86( MHandle , FrameIndex , IsTransform );
			}
			else
			{
				return dx_MV1RefreshReferenceMesh_x64( MHandle , FrameIndex , IsTransform );
			}
		}



	}
}
