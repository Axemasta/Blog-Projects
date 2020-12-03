//
//  ViewController.m
//  View To Image Objc
//
//  Created by Alex Duffell on 18/12/2017.
//  Copyright © 2017 Alex Duffell. All rights reserved.
//
// Project files are from of my UIView -> UIImage tutorial on wordpress
// https://alexduffell.wordpress.com/2017/12/19/how-to-make-a-uiimage-from-a-uiview-gradients/

#import "ViewController.h"
#import <Foundation/Foundation.h>

@interface ViewController ()

@property (weak, nonatomic) IBOutlet UIProgressView *progressView;
@property (weak, nonatomic) IBOutlet UIView *containerView;

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    _progressView.transform = CGAffineTransformScale(CGAffineTransformIdentity, 1, 20);
    
    _containerView.layer.cornerRadius = 10;
    _containerView.layer.masksToBounds = true;
    
    CAGradientLayer *gradientLayer = [CAGradientLayer layer];
    
    UIColor *primary = [UIColor yellowColor];
    UIColor *highlight = [UIColor redColor];
    
    gradientLayer.frame = _containerView.bounds;
    gradientLayer.colors = @[(id)primary.CGColor, (id)highlight.CGColor];
    gradientLayer.startPoint = CGPointMake(0.0, 0.5);
    gradientLayer.endPoint = CGPointMake(1.0, 0.5);
    
    UIView *gradientView = [[UIView alloc] initWithFrame:_containerView.bounds];
    [gradientView.layer addSublayer:gradientLayer];
    
    UIGraphicsImageRenderer *renderer = [[UIGraphicsImageRenderer alloc] initWithSize:gradientView.bounds.size];
    UIImage *gradientImage = [renderer imageWithActions:^(UIGraphicsImageRendererContext * _Nonnull rendererContext) {
        [gradientView drawViewHierarchyInRect:gradientView.bounds afterScreenUpdates:true];
    }];
    
    _progressView.progressImage = gradientImage;

}




@end
