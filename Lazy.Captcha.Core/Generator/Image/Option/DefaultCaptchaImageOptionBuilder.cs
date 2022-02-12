﻿using Lazy.Captcha.Core.Generator;
using Lazy.Captcha.Core.Generator.Code;
using SixLabors.Fonts;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy.Captcha.Core.Generator.Image.Option
{
    public class DefaultCaptchaImageOptionBuilder : ICaptchaImageOptionBuilder
    {
        private CaptchaImageGeneratorOption _option = new CaptchaImageGeneratorOption();

        public static DefaultCaptchaImageOptionBuilder Create()
        { 
            return new DefaultCaptchaImageOptionBuilder();
        }

        /// <summary>
        /// 背景色
        /// </summary>
        /// <param name="backgroundColor"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder CaptchaType(Color backgroundColor)
        {
            this._option.BackgroundColor = backgroundColor;
            return this;
        }

        /// <summary>
        /// 字体
        /// </summary>
        /// <param name="fontFamily"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder FontFamily(FontFamily fontFamily)
        {
            this._option.FontFamily = fontFamily;
            return this;
        }

        /// <summary>
        /// 字体大小
        /// </summary>
        /// <param name="fontSize"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder FontFamily(float fontSize)
        {
            this._option.FontSize = fontSize;
            return this;
        }

        /// <summary>
        /// fontStyle
        /// </summary>
        /// <param name="fontStyle"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder FontFamily(FontStyle fontStyle)
        {
            this._option.FontStyle = fontStyle;
            return this;
        }

        /// <summary>
        /// 验证码的宽高
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder Size(int width, int height)
        {
            this._option.Width = width;
            this._option.Height = height;
            return this;
        }

        /// <summary>
        /// 验证码长度
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder Length(int length)
        {
            this._option.Length = length;
            return this;
        }

        /// <summary>
        /// 是否绘制气泡
        /// </summary>
        /// <param name="drawBubble"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder DrawBubble(bool drawBubble)
        {
            this._option.DrawBubble = drawBubble;
            return this;
        }

        /// <summary>
        /// 气泡数量
        /// </summary>
        /// <param name="bubbleCount"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder BubbleCount(int bubbleCount)
        {
            this._option.BubbleCount = bubbleCount;
            return this;
        }

        /// <summary>
        /// 气泡边沿厚度
        /// </summary>
        /// <param name="bubbleThickness"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder BubbleCount(float bubbleThickness)
        {
            this._option.BubbleThickness = bubbleThickness;
            return this;
        }

        /// <summary>
        /// 是否绘制干扰线
        /// </summary>
        /// <param name="drawInterferenceLine"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder DrawInterferenceLine(bool drawInterferenceLine)
        {
            this._option.DrawInterferenceLine = drawInterferenceLine;
            return this;
        }

        /// <summary>
        /// 干扰线数量
        /// </summary>
        /// <param name="drawInterferenceLine"></param>
        /// <returns></returns>
        public DefaultCaptchaImageOptionBuilder InterferenceLineCount(int interferenceLineCount)
        {
            this._option.InterferenceLineCount = interferenceLineCount;
            return this;
        }


        public CaptchaImageGeneratorOption Build()
        {
            return this._option;
        }
    }
}
