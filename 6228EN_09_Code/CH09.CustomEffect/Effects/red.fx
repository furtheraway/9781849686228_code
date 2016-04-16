sampler2D input : register(s0);

float4 main(float2 uv : TEXCOORD) : COLOR {
	float4 src = tex2D(input, uv);

	float4 dst = src;
	dst.gb = 0;
	
	return dst;
}