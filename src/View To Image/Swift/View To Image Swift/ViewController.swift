//
//  ViewController.swift
//  View To Image Swift
//
//  Created by Alex Duffell on 18/12/2017.
//  Copyright © 2017 Alex Duffell. All rights reserved.
//
// Project files are from of my UIView -> UIImage tutorial on wordpress
// https://alexduffell.wordpress.com/2017/12/19/how-to-make-a-uiimage-from-a-uiview-gradients/

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var progressView: UIProgressView!
    @IBOutlet weak var containerView: UIView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        //Increase height of progress view
        progressView.transform = CGAffineTransform(scaleX: 1, y: 20)
        
        //Round the corners of the progress view (using its container view)
        containerView.layer.cornerRadius = 10
        containerView.layer.masksToBounds = true
        
        //Create a gradient
        let colour1 = UIColor.yellow.cgColor
        let colour2 = UIColor.red.cgColor
        
        let gradientLayer = CAGradientLayer()
        gradientLayer.frame = containerView.bounds
        gradientLayer.colors = [colour1, colour2]
        gradientLayer.startPoint = CGPoint(x: 0.0, y: 0.5)
        gradientLayer.endPoint = CGPoint(x: 1.0, y: 0.5)
        
        //Create a view
        let gradientView = UIView(frame: containerView.bounds)
        gradientView.layer.addSublayer(gradientLayer)
        
        let renderer = UIGraphicsImageRenderer(size: gradientView.bounds.size)
        let image = renderer.image { ctx in
            gradientView.drawHierarchy(in: gradientView.bounds, afterScreenUpdates: true)
        }
        
        progressView.progressImage = image
    }
    
}

